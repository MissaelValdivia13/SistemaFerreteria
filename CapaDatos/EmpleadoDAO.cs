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
    public class EmpleadoDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;

        public DataSet consultaEmpleados()
        {
            using (DataSet data =  new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("CONSULTAEMPLEADO", conec);
                adaptador.Fill(data, "SUBE");
                conec.Close();
                return data;
            }
        }

        public void subeEmpleado(string nombre, string puesto, string telefono)
        {
            try
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("SUBEEMPLEADO", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                adaptador.SelectCommand.Parameters.Add("@Puesto", SqlDbType.VarChar).Value = puesto;
                adaptador.SelectCommand.Parameters.Add("Telefono", SqlDbType.VarChar).Value = telefono;
                adaptador.SelectCommand.ExecuteNonQuery();

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                adaptador.Dispose();
                conec.Close();
            }
        }

        public int nuevoEmpleado()
        {
            int totalRegistros = -1;
            try
            {
                conec = objConecta.Conecta();
                comando = new SqlCommand("NUEVOEMPLEADO", conec);
                totalRegistros = Convert.ToInt32(comando.ExecuteScalar());
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

    }
}
