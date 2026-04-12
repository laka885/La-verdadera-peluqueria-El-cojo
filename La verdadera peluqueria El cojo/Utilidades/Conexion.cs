using System.Data.SqlClient;

public class Conexion
{
    public static SqlConnection Conectar()
    {
      
        string cadena = "Data Source=.;Initial Catalog=PeluqueriaDB;Integrated Security=True";

        SqlConnection cn = new SqlConnection(cadena);

        return cn; 
    }
}