using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ErroresDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;

        public DataSet consultaClientes()
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.ConectaMantenimiento();
                adaptador = new SqlDataAdapter("CONSULTARERRORES", conec);
                adaptador.Fill(data, "SUBE");
                conec.Close();
                return data;
            }
        }
    }
}
