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
            int registros = Convert.ToInt32(adaptador.SelectCommand.ExecuteScalar()) + 1;
            conec.Close();
            return registros;
        }

        public Boolean EnviarVentaYDetalle(int idCliente, int idEmpleado, string fecha, double total,double saldo, char estado, DataTable detalleData, string opcion)
        {
            Boolean aux = false;
            SqlTransaction transaction = null;

            try
            {
                conec = objConecta.Conecta();

                using (SqlCommand com = new SqlCommand("GuardarVentaYDetalles", conec, transaction))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@IdCliente", idCliente);
                    com.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    com.Parameters.AddWithValue("@Fecha", fecha);
                    com.Parameters.AddWithValue("@Total", total);
                    com.Parameters.AddWithValue("@Saldo", saldo);
                    com.Parameters.AddWithValue("@Estado", estado);

                    SqlParameter parameter = com.Parameters.AddWithValue("@DV", detalleData);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "DETAL"; 

                    com.Parameters.AddWithValue("@Opcion", opcion);

                    com.ExecuteNonQuery();

                    aux = false;
                }
            }
            catch (SqlException ex)
            {
                aux = true;  
            }
            finally
            {
                if (conec != null && conec.State == ConnectionState.Open)
                {
                    conec.Close();
                }
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


        public DataSet reportePeriodo(string inicio, string fin)
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                using (SqlCommand comando = new SqlCommand("VentasPorPeriodo", conec))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@FechaInicio", inicio);
                    comando.Parameters.AddWithValue("@FechaFin", fin);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(data, "VentasPeriodo");
                    }
                }
                conec.Close();
                return data;
            }
        }

        public DataSet reporteEmpleadoPeriodo(string empleado, string inicio, string fin)
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                using (SqlCommand comando = new SqlCommand("VentasPorEmpleadoEnPeriodo", conec))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NombreEmpleado", empleado);
                    comando.Parameters.AddWithValue("@FechaInicio", inicio);
                    comando.Parameters.AddWithValue("@FechaFin", fin);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(data, "VentasEmpleadoPeriodo");
                    }
                }
                conec.Close();
                return data;
            }
        }

        public DataSet rankingVentasEmpleado(string inicio, string fin)
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                using (SqlCommand comando = new SqlCommand("RankingEmpleadosPorVentasEnPeriodo", conec))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@FechaInicio", inicio);
                    comando.Parameters.AddWithValue("@FechaFin", fin);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(data, "VentasEmpleadoPeriodo");
                    }
                }
                conec.Close();
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

        public DataSet ObtenerVentaPorId(int idVenta)
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta())
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter("ObtenerVentaPorId", conec);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.SelectCommand.Parameters.AddWithValue("@IdVenta", idVenta);
                    adaptador.Fill(data, "VentaPorId");
                    conec.Close();
                }
                return data;
            }
        }
        public DataSet ObtenerComparacionVentasMensuales()
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta())
                {
                    using (SqlCommand comando = new SqlCommand("ComparacionVentasMensuales", conec))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(data, "ComparacionVentasMensuales");
                        }
                    }
                    conec.Close();
                }
                return data;
            }
        }
    }
}
