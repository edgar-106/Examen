using Examen.Modelo;
using Examen.Presentador;

namespace Examen.Vista;

public partial class PersonaFormulario : Form, IPersonaVista
{
    private readonly PersonaPresentador presentador;

    public PersonaFormulario()
    {
        InitializeComponent();
        presentador = new PersonaPresentador(this);
        presentador.VerPersonas();
    }

    public string Nombre => txtNombre.Text;

    public string ApellidoPaterno => txtApellidoPaterno.Text;

    public string ApellidoMaterno => txtApellidoMaterno.Text;

    public int IdPersonaSeleccionada
    {
        get
        {
            if (dgvPersonas.SelectedRows.Count == 0)
            {
                return 0;
            }

            object? valor = dgvPersonas.SelectedRows[0].Cells["colId"].Value;
            return valor is int id ? id : 0;
        }
    }

    public void MostrarMensaje(string mensaje)
    {
        MessageBox.Show(mensaje, "Registro de personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void MostrarPersona(Persona persona)
    {
        txtNombre.Text = persona.Nombre;
        txtApellidoPaterno.Text = persona.ApellidoPaterno;
        txtApellidoMaterno.Text = persona.ApellidoMaterno;
    }

    public void MostrarPersonas(IReadOnlyList<Persona> personas)
    {
        dgvPersonas.Rows.Clear();

        foreach (Persona persona in personas)
        {
            dgvPersonas.Rows.Add(persona.Id, persona.Nombre, persona.ApellidoPaterno, persona.ApellidoMaterno);
        }
    }

    public void LimpiarFormulario()
    {
        txtNombre.Clear();
        txtApellidoPaterno.Clear();
        txtApellidoMaterno.Clear();
        dgvPersonas.ClearSelection();
        txtNombre.Focus();
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        presentador.GuardarPersonaEnBaseDatos();
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        presentador.EliminarPersona();
    }

    private void btnCrear_Click(object? sender, EventArgs e)
    {
        presentador.CrearPersona();
    }

    private void btnVer_Click(object? sender, EventArgs e)
    {
        presentador.VerPersonas();
    }

    private void btnActualizar_Click(object? sender, EventArgs e)
    {
        presentador.ActualizarPersona();
    }

    private void dgvPersonas_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvPersonas.SelectedRows.Count == 0)
        {
            return;
        }

        DataGridViewRow fila = dgvPersonas.SelectedRows[0];
        txtNombre.Text = fila.Cells["colNombre"].Value?.ToString() ?? string.Empty;
        txtApellidoPaterno.Text = fila.Cells["colApellidoPaterno"].Value?.ToString() ?? string.Empty;
        txtApellidoMaterno.Text = fila.Cells["colApellidoMaterno"].Value?.ToString() ?? string.Empty;
    }

    private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
