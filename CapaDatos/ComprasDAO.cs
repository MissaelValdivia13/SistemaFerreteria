using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace CapaDatos
{
    public class ComprasDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;

        public Boolean EnviarCompraYDetalle(int idProveedor, string facturas, string fecha, double iva, double subtotal, DataTable detalleData, int idEmpleado, string opcion)
        {
            Boolean aux = false;
            SqlTransaction transaction = null;

            try
            {
                conec = objConecta.Conecta();
                //transaction = conec.BeginTransaction();

                using (SqlCommand com = new SqlCommand("GuardarCompraYDetalle", conec, transaction))
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

                    com.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    com.Parameters.AddWithValue("@Opcion", opcion);

                    com.ExecuteNonQuery();

                    //transaction.Commit();
                    conec.Close();
                }
            }
            catch (SqlException ex)
            {
                /*if (transaction != null)
                {
                    transaction.Rollback();
                }*/
                aux = true;
            }
            return aux;
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

        public DataSet ComprasPorCategoria(string fechaInicio, string fechaFin)
        {
            using (DataSet data = new DataSet())
            {
                SqlConnection conec = objConecta.Conecta();
                using (SqlCommand comando = new SqlCommand("ComprasPorCategoriaPorPeriodo", conec))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@FechaFin", fechaFin);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(data, "ComprasPorCategoria");
                    }
                }
                conec.Close();
                return data;
            }
        }

        public DataSet ComprasPorProveedor(string fechaInicio, string fechaFin, int idProveedor)
        {
            using (DataSet data = new DataSet())
            {
                SqlConnection conec = objConecta.Conecta();
                using (SqlCommand comando = new SqlCommand("ComprasPorProveedorPorPeriodo", conec))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@FechaFin", fechaFin);
                    comando.Parameters.AddWithValue("@IdProveedor", idProveedor);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(data, "ComprasPorProveedor");
                    }
                }
                conec.Close();
                return data;
            }
        }

        public DataSet ComparacionComprasMensuales()
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta()) 
                {
                    using (SqlCommand comando = new SqlCommand("ComparacionComprasMensuales", conec))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(data, "ComparacionComprasMensuales");
                        }
                    }
                    conec.Close();
                }
                return data;
            }
        }

    }
}
