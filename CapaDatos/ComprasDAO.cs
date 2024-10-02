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

        public void EnviarCompraYDetalle(int idProveedor, string facturas, string fecha, double iva, double subtotal, DataTable detalleData)
        {
            using (SqlConnection conec = objConecta.Conecta())
            {
                using (SqlCommand com = new SqlCommand("GuardarCompraYDetalle", conec))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@IdProveedor", idProveedor);
                    com.Parameters.AddWithValue("@Facturas", facturas);
                    com.Parameters.AddWithValue("@Fecha", fecha);
                    com.Parameters.AddWithValue("@Iva", iva);
                    com.Parameters.AddWithValue("@Subtotal", subtotal);

                    // Agregar el parámetro de tipo tabla
                    SqlParameter parameter = com.Parameters.AddWithValue("@DP", detalleData);
                    parameter.SqlDbType = SqlDbType.Structured; 
                    parameter.TypeName = "DETAL"; 

                    com.ExecuteNonQuery();
                }
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

    }
}
