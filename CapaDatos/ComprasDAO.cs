using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class ComprasDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;

        public void EnviarCompraYDetalle(int idProveedor, string facturas, string fecha, double iva, double subtotal, DataTable detalleData, int idEmpleado, string opcion)
        {
            conec = objConecta.Conecta();
                using (SqlCommand com = new SqlCommand("GuardarCompraYDetalle", conec))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@IdProveedor", idProveedor);
                    com.Parameters.AddWithValue("@Facturas", facturas);
                    com.Parameters.AddWithValue("@Fecha", fecha);
                    com.Parameters.AddWithValue("@Iva", iva);
                    com.Parameters.AddWithValue("@Subtotal", subtotal);

                    SqlParameter parameter = com.Parameters.AddWithValue("@DP", detalleData);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "DETAL";

                    // Parametros del error por si llega a surgir
                    com.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    com.Parameters.AddWithValue("@Opcion", opcion);

                   
                    com.ExecuteNonQuery();
                    conec.Close();
                
            }
        }




        public int nuevaCompra()
        {
            int totalRegistros = -1;

            try
            {
                conec = objConecta.Conecta();
                comando = new SqlCommand("NUEVACOMPRA", conec);
                totalRegistros = Convert.ToInt32(comando.ExecuteScalar()) + 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conec.Close();
            }
            return totalRegistros;
        }

        public DataSet consultaCompras(string opcion, string valor)
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta()) 
                {
                    using (SqlCommand comando = new SqlCommand("CONSULTACOMPRAS", conec))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Opcion", opcion);
                        comando.Parameters.AddWithValue("@Valor", valor);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(data, "Compras"); 
                        }
                    }
                    conec.Close(); 
                }
                return data; 
            }
        }

        public DataSet consultaDetalleCompra(int idCompra)
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta()) 
                {
                    using (SqlCommand comando = new SqlCommand("CONSULTADETALLECOMPRA", conec))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Id", idCompra); 

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(data, "DetalleCompra"); 
                        }
                    }
                    conec.Close(); 
                }
                return data; 
            }
        }


    }
}
