using Npgsql;

namespace Examen.Modelo;

public class Persona
{
    private readonly Conexion miConexion = new();

    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public string ApellidoPaterno { get; set; } = string.Empty;

    public string ApellidoMaterno { get; set; } = string.Empty;

    public string NombreCompleto => $"{Nombre} {ApellidoPaterno} {ApellidoMaterno}".Trim();

    public void Guardar()
    {
        using NpgsqlConnection conn = miConexion.GetConexion();
        conn.Open();

        const string sql = """
            INSERT INTO personas (nombre, apellido_paterno, apellido_materno)
            VALUES (@nombre, @apellidoPaterno, @apellidoMaterno)
            """;

        using NpgsqlCommand cmd = new(sql, conn);
        cmd.Parameters.AddWithValue("nombre", Nombre);
        cmd.Parameters.AddWithValue("apellidoPaterno", ApellidoPaterno);
        cmd.Parameters.AddWithValue("apellidoMaterno", ApellidoMaterno);
        cmd.ExecuteNonQuery();
    }

    public void Actualizar()
    {
        using NpgsqlConnection conn = miConexion.GetConexion();
        conn.Open();

        const string sql = """
            UPDATE personas
            SET nombre = @nombre,
                apellido_paterno = @apellidoPaterno,
                apellido_materno = @apellidoMaterno
            WHERE id = @id
            """;

        using NpgsqlCommand cmd = new(sql, conn);
        cmd.Parameters.AddWithValue("id", Id);
        cmd.Parameters.AddWithValue("nombre", Nombre);
        cmd.Parameters.AddWithValue("apellidoPaterno", ApellidoPaterno);
        cmd.Parameters.AddWithValue("apellidoMaterno", ApellidoMaterno);
        cmd.ExecuteNonQuery();
    }

    public static void Eliminar(int id)
    {
        Conexion conexion = new();

        using NpgsqlConnection conn = conexion.GetConexion();
        conn.Open();

        const string sql = "DELETE FROM personas WHERE id = @id";

        using NpgsqlCommand cmd = new(sql, conn);
        cmd.Parameters.AddWithValue("id", id);
        cmd.ExecuteNonQuery();
    }

    public static List<Persona> ObtenerTodas()
    {
        Conexion conexion = new();
        List<Persona> personas = new();

        using NpgsqlConnection conn = conexion.GetConexion();
        conn.Open();

        const string sql = """
            SELECT id, nombre, apellido_paterno, apellido_materno
            FROM personas
            ORDER BY id
            """;

        using NpgsqlCommand cmd = new(sql, conn);
        using NpgsqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            personas.Add(new Persona
            {
                Id = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                ApellidoPaterno = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                ApellidoMaterno = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
            });
        }

        return personas;
    }

    public override string ToString()
    {
        return NombreCompleto;
    }
}
