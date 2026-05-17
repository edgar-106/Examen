using Examen.Modelo;
using Examen.Vista;

namespace Examen.Presentador;

public class PersonaPresentador
{
    private readonly IPersonaVista vista;

    public PersonaPresentador(IPersonaVista vista)
    {
        this.vista = vista;
    }

    public void CrearPersona()
    {
        Persona? persona = CrearPersonaDesdeVista();

        if (persona is null)
        {
            return;
        }

        try
        {
            persona.Guardar();
            vista.MostrarMensaje("Persona creada correctamente en PostgreSQL.");
            VerPersonas();
            vista.LimpiarFormulario();
        }
        catch (Exception ex)
        {
            vista.MostrarMensaje($"No se pudo crear la persona: {ex.Message}");
        }
    }

    public void GuardarPersonaEnBaseDatos()
    {
        CrearPersona();
    }

    public void VerPersonas()
    {
        try
        {
            vista.MostrarPersonas(Persona.ObtenerTodas());
        }
        catch (Exception ex)
        {
            vista.MostrarMensaje($"No se pudieron consultar las personas: {ex.Message}");
        }
    }

    public void VerPersonaSeleccionada()
    {
        Persona? persona = ObtenerPersonaSeleccionada();

        if (persona is null)
        {
            return;
        }

        vista.MostrarPersona(persona);
    }

    public void ActualizarPersona()
    {
        int id = vista.IdPersonaSeleccionada;

        if (id <= 0)
        {
            vista.MostrarMensaje("Selecciona una persona de la tabla para actualizarla.");
            return;
        }

        Persona? persona = CrearPersonaDesdeVista();

        if (persona is null)
        {
            return;
        }

        persona.Id = id;

        try
        {
            persona.Actualizar();
            vista.MostrarMensaje("Persona actualizada correctamente en PostgreSQL.");
            VerPersonas();
            vista.LimpiarFormulario();
        }
        catch (Exception ex)
        {
            vista.MostrarMensaje($"No se pudo actualizar la persona: {ex.Message}");
        }
    }

    public void EliminarPersona()
    {
        int id = vista.IdPersonaSeleccionada;

        if (id <= 0)
        {
            vista.MostrarMensaje("Selecciona una persona de la tabla para eliminarla.");
            return;
        }

        try
        {
            Persona.Eliminar(id);
            vista.MostrarMensaje("Persona eliminada correctamente de PostgreSQL.");
            VerPersonas();
            vista.LimpiarFormulario();
        }
        catch (Exception ex)
        {
            vista.MostrarMensaje($"No se pudo eliminar la persona: {ex.Message}");
        }
    }

    private Persona? CrearPersonaDesdeVista()
    {
        string nombre = vista.Nombre.Trim();
        string apellidoPaterno = vista.ApellidoPaterno.Trim();
        string apellidoMaterno = vista.ApellidoMaterno.Trim();

        if (string.IsNullOrWhiteSpace(nombre))
        {
            vista.MostrarMensaje("Ingresa el nombre de la persona.");
            return null;
        }

        return new Persona
        {
            Nombre = nombre,
            ApellidoPaterno = apellidoPaterno,
            ApellidoMaterno = apellidoMaterno
        };
    }

    private Persona? ObtenerPersonaSeleccionada()
    {
        int id = vista.IdPersonaSeleccionada;

        if (id <= 0)
        {
            vista.MostrarMensaje("Selecciona una persona de la tabla.");
            return null;
        }

        try
        {
            return Persona.ObtenerTodas().FirstOrDefault(persona => persona.Id == id);
        }
        catch (Exception ex)
        {
            vista.MostrarMensaje($"No se pudo consultar la persona seleccionada: {ex.Message}");
            return null;
        }
    }
}
