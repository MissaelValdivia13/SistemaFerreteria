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
    public class VentasDAO
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

        public Boolean EnviarVentaYDetalle(int idCliente, string fecha, double total, DataTable detalleData, int idEmpleado, string opcion)
        {
            Boolean aux = false;
            SqlTransaction transaction = null;

            try
            {
                conec = objConecta.Conecta();
                transaction = conec.BeginTransaction();

                using (SqlCommand com = new SqlCommand("GuardarVentaYDetalles", conec, transaction))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@IdCliente", idCliente);
                    com.Parameters.AddWithValue("@Fecha", fecha);
                    com.Parameters.AddWithValue("@Total", total);

                    SqlParameter parameter = com.Parameters.AddWithValue("@DV", detalleData);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "DETAL";

                    com.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    com.Parameters.AddWithValue("@Opcion", opcion);

                    com.ExecuteNonQuery();

                    transaction.Commit();
                    conec.Close();
                }
            }
            catch (SqlException ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                aux = true;
            }
            return aux;
        }

        public DataSet consultaVentas(string opcion, string valor)
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta())
                {
                    using (SqlCommand comando = new SqlCommand("CONSULTAVENTAS", conec))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Opcion", opcion);
                        comando.Parameters.AddWithValue("@Valor", valor);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(data, "Ventas");
                        }
                    }
                    conec.Close();
                }
                return data;
            }

        }
        public DataSet consultaDetalleVenta(int idVenta)
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta()) 
                {
                    using (SqlCommand comando = new SqlCommand("CONSULTADETALLEVENTA", conec)) 
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Id", idVenta); 

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(data, "DetalleVenta");
                        }
                    }
                    conec.Close(); 
                }
                return data; 
            }
        }


    }
}
