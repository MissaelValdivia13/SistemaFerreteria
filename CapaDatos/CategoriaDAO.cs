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
    public class CategoriaDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;
        public DataSet consultarCategoria()
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("CONSULTACATEGORIAS", conec);
                adaptador.Fill(data, "SUBE");
                conec.Close();
                return data;
            }
        }

        public void subeCategoria(string concepto)
        {
            try
            {
                conec = objConecta.Conecta();
                adaptador =  new SqlDataAdapter("SUBECATEGORIA",conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add("@Concepto", SqlDbType.VarChar).Value = concepto;
                adaptador.SelectCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                adaptador.Dispose();
                conec.Close();
            }
        }

        public int nuevaCategoria()
        {
            int totalRegistros = -1;
            try
            {
                conec = objConecta.Conecta();
                comando = new SqlCommand("NUEVACATEGORIA",conec);
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
