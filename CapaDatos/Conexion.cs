using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public SqlConnection Conecta()
        {
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conection"].ConnectionString);
            SqlConnection con = new SqlConnection("server=MISSAEL\\SQLEXPRESS;database=SistemaFerreteria;user=root; integrated security= true");
            try
            {
                con.Open(); // Prueba abrir la conexión
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al conectar: {ex.Message}");
                // Manejo de errores según sea necesario
            }
            return con;
        }

    }
}
