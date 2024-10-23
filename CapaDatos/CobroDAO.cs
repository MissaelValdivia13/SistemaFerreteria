using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public  class CobroDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;

        public int nuevaCobro()
        {
            conec = objConecta.Conecta();
            adaptador = new SqlDataAdapter("NUEVOCOBRO", conec);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            int registros = Convert.ToInt32(adaptador.SelectCommand.ExecuteScalar()) + 1;
            conec.Close();
            return registros;
        }

        public DataSet ObtenerVentasPorCliente(int idCliente)
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta())
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter("ObtenerVentasPorCliente", conec);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.SelectCommand.Parameters.AddWithValue("@IdCliente", idCliente);
                    adaptador.Fill(data, "VentasPorCliente");
                    conec.Close();
                }
                return data;
            }
        }

        public void RealizarCobro(int idCliente, int idVenta, double monto,double cantidad, int idEmpleado)
        {
            using (SqlConnection conec = objConecta.Conecta())
            {
                using (SqlCommand cmd = new SqlCommand("RealizarCobro", conec))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    cmd.ExecuteNonQuery();
                    conec.Close();
                }
            }
        }

        public DataSet ConsultarCobrosDinamicamente(string opcion, string valor)
        {
            using (SqlConnection conec = objConecta.Conecta())
            {
                using (adaptador = new SqlDataAdapter("CONSULTACOBROSDINAMICA", conec))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                    adaptador.SelectCommand.Parameters.AddWithValue("@Opcion", opcion);
                    adaptador.SelectCommand.Parameters.AddWithValue("@Valor", valor);

                    DataSet data = new DataSet();
                    adaptador.Fill(data, "Cobros");
                    return data;
                }
            }
        }


    }
}
