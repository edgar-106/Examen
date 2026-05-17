using Examen.Modelo;

namespace Examen.Vista;

public interface IPersonaVista
{
    string Nombre { get; }

    string ApellidoPaterno { get; }

    string ApellidoMaterno { get; }

    int IdPersonaSeleccionada { get; }

    void MostrarMensaje(string mensaje);

    void MostrarPersona(Persona persona);

    void MostrarPersonas(IReadOnlyList<Persona> personas);

    void LimpiarFormulario();
}
