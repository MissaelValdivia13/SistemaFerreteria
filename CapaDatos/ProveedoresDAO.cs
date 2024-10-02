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
    public class ProveedoresDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;

        public DataSet consultaProveedores()
        {
            using (DataSet data= new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("CONSULTAPROVEEDORES", conec);
                adaptador.Fill(data, "SUBE");
                conec.Close();
                return data;
            }
        }

        public void subeProveedor(string empresa, string contacto, string telefono, string domicilio)
        {
            try
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("SUBEPROVEEDOR", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = empresa;
                adaptador.SelectCommand.Parameters.Add("@Contacto", SqlDbType.VarChar).Value = contacto;
                adaptador.SelectCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = telefono;
                adaptador.SelectCommand.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = domicilio;
                adaptador.SelectCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                adaptador.Dispose();
                conec.Close();
            }
        }

        public int nuevoProveedor()
        {
            int totalRegistros = -1;
            try
            {
                conec = objConecta.Conecta();
                comando = new SqlCommand("NUEVOPROVEEDOR", conec);
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
        public void actualizaProveedor(int idProveedor, string empresa, string contacto, string telefono, string direccion)
        {
            try
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("MODIFICAPROVEEDOR", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = idProveedor;
                adaptador.SelectCommand.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = empresa;
                adaptador.SelectCommand.Parameters.Add("@Contacto", SqlDbType.VarChar).Value = contacto;
                adaptador.SelectCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = telefono;
                adaptador.SelectCommand.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = direccion;
                adaptador.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conec.Close();
            }
        }

        public DataSet consultaProveedores(string opcion, string valor)
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta())
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("CONSULTAPROV", conec))
                    {
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adaptador.SelectCommand.Parameters.AddWithValue("@Opcion", opcion);
                        adaptador.SelectCommand.Parameters.AddWithValue("@Valor", valor);
                        adaptador.Fill(data, "Proveedores");
                        conec.Close();
                    }
                }
                return data;
            }
        }

    }
}
