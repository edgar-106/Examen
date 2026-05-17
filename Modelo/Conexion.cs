using Npgsql;

namespace Examen.Modelo;

public class Conexion
{
    private readonly string cadena = "Host=localhost;Port=5432;Database=Examen;Username=postgres;Password=postgres";

    public NpgsqlConnection GetConexion()
    {
        return new NpgsqlConnection(cadena);
    }



}
