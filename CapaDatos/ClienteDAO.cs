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
    public class ClienteDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;

        public DataSet consultaClientes()
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("CONSULTACLIENTES", conec);
                adaptador.Fill(data, "SUBE");
                conec.Close();
                return data;
            }        
        }

        public void insertaCliente(string nombre, string telefono, string email, string domicilio, double saldo)
        {
            try
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("SUBECLIENTE", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                adaptador.SelectCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = telefono;
                adaptador.SelectCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                adaptador.SelectCommand.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = domicilio;
                adaptador.SelectCommand.Parameters.Add("@Saldo", SqlDbType.Money).Value = saldo;
                adaptador.SelectCommand.ExecuteNonQuery();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                adaptador.Dispose();
                conec.Close() ;
            }
        }

        public int nuevoCliente()
        {
            int totalRegistros = -1;

            try
            {
                conec = objConecta.Conecta();
                comando = new SqlCommand("NUEVOCLIENTE", conec);
                totalRegistros = Convert.ToInt32(comando.ExecuteScalar()) + 1;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conec.Close();
            }
            return totalRegistros;
        }

        public void actualizaCliente(int id, string nombre, string telefono, string email, string domicilio)
        {
            try
            {
                conec =  objConecta.Conecta();
                adaptador = new SqlDataAdapter("ACTUALIZACLIENTE", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = id;
                adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                adaptador.SelectCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = telefono;
                adaptador.SelectCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                adaptador.SelectCommand.Parameters.Add("@Domiclio", SqlDbType.VarChar).Value = domicilio;
                adaptador.SelectCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conec.Close();
            }
        }

        public DataSet consultaClientesD(string opcion, string valor)
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("CONSULTACLIENTESDINAMICA", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.AddWithValue("@Opcion", opcion);
                adaptador.SelectCommand.Parameters.AddWithValue("@Valor", valor);
                adaptador.Fill(data, "SUBE");
                conec.Close();
                return data;
            }
        }

        public DataSet consultaClientesConSaldo(string opcion, string valor)
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("ObtenerClientesConSaldo", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.AddWithValue("@Opcion", opcion);
                adaptador.SelectCommand.Parameters.AddWithValue("@Valor", valor);

                adaptador.Fill(data, "ClientesConSaldo");
                conec.Close();
                return data;
            }
        }

        public DataSet ObtenerCobrosPorCliente(int idCliente)
        {
            using (DataSet data = new DataSet())
            {
                SqlConnection conec = objConecta.Conecta();
                using (SqlCommand comando = new SqlCommand("ReporteCobrosPorCliente", conec))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idCliente", idCliente);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(data, "CobrosCliente");
                    }
                }
                conec.Close();
                return data;
            }
        }

        public DataSet ReporteClientesConSaldoPendiente()
        {
            using (DataSet data = new DataSet())
            {
                SqlConnection conec = objConecta.Conecta();
                using (SqlCommand comando = new SqlCommand("ReporteClientesConSaldoPendiente", conec))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(data, "ClientesConSaldoPendiente");
                    }
                }
                conec.Close();
                return data;
            }
        }

        public DataSet RankingClientesPorTotalVentas()
        {
            using (DataSet data = new DataSet())
            {
                SqlConnection conec = objConecta.Conecta();
                using (SqlCommand comando = new SqlCommand("RankingClientesPorTotalVentas", conec))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(data, "ClientesRankingVentas");
                    }
                }
                conec.Close();
                return data;
            }
        }



    }
}
