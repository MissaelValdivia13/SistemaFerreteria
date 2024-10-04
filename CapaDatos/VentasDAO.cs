using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public  class VentasDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;

        public int nuevaVenta()
        {
            conec = objConecta.Conecta();
            adaptador = new SqlDataAdapter("NUEVAVENTA", conec);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            int registros = Convert.ToInt32(adaptador.SelectCommand.ExecuteScalar());
            conec.Close();
            return registros;
        }

        public void insertarVenta(int idCliente, int idEmpleado, string fecha, double total, DataTable table)
        {
            using (SqlConnection conn = objConecta.Conecta())
            {
                using (SqlCommand com = new SqlCommand("GUARDARVENTAYDETALLE", conn))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@IdCliente", idCliente);
                    com.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    com.Parameters.AddWithValue("@Fecha", fecha);
                    com.Parameters.AddWithValue("@Total", total);

                    SqlParameter parameter = com.Parameters.AddWithValue("@DP", table);
                    parameter.SqlDbType = SqlDbType.Structured; 
                    parameter.TypeName = "DETALLE"; 
                    com.ExecuteNonQuery();
                }
            }
        }

    }
}
