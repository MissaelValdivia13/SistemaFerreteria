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
    public class ProductosDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;

        public DataSet consultaProductos()
        {
            using (DataSet data =  new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("CONSULTAPRODUCTO", conec);
                adaptador.Fill(data,"SUBE");
                conec.Close();
                return data;
            }
        }

        public int nuevoProducto()
        {
            int totalRegistros = -1;
            try
            {
                conec = objConecta.Conecta();
                comando =  new SqlCommand("NUEVOPRODUCTO",conec);
                totalRegistros = Convert.ToInt32(comando.ExecuteScalar()) + 1;


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conec.Close();
            }
            return totalRegistros;
        }

        public void insertProducto(int idCategoria, string nombre, double precio,double costoPromedio, int existencias, int maximo, int minimo)
        {
            try
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("SUBEPRODUCTO", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = idCategoria;
                adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                adaptador.SelectCommand.Parameters.Add("@Precio", SqlDbType.Money).Value = precio;
                adaptador.SelectCommand.Parameters.Add("@CostoPromedio", SqlDbType.Money).Value = costoPromedio;
                adaptador.SelectCommand.Parameters.Add("@Existencia", SqlDbType.Int).Value = existencias;
                adaptador.SelectCommand.Parameters.Add("@Maximo", SqlDbType.Int).Value = maximo;
                adaptador.SelectCommand.Parameters.Add("@Minimo", SqlDbType.Int).Value = minimo;
                adaptador.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally{
                conec.Close();
            }
        }

        public void actualizaProducto(int idProducto, int idCategoria, string nombre, double precio, int maximo, int minimo)
        {
            try
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("ACTUALIZAPRODUCTO", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add("@IdProducto", SqlDbType.Int).Value = idProducto;
                adaptador.SelectCommand.Parameters.Add("@Idcategoria", SqlDbType.Int).Value = idCategoria;
                adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                adaptador.SelectCommand.Parameters.Add("@Precio", SqlDbType.Money).Value = precio;
                adaptador.SelectCommand.Parameters.Add("@Maximo", SqlDbType.Int).Value = maximo;
                adaptador.SelectCommand.Parameters.Add("@Minimo", SqlDbType.Int).Value = minimo;
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

        public DataSet consultaProductos(string opcion, string valor)
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta())
                {
                    using (SqlCommand comando = new SqlCommand("CONSULTAPRODUCTOS", conec))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Opcion", opcion);
                        comando.Parameters.AddWithValue("@Valor", valor);
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(data, "Productos");
                        }
                    }
                    conec.Close(); 
                }
                return data;
            }
        }

        public DataSet ObtenerRankingProductos()
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("RankingProductosPorCategoria", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.Fill(data, "RankingProductos");
                conec.Close();
                return data;
            }
        }

        public DataSet ObtenerProductosMasRentables()
        {
            using (DataSet data = new DataSet())
            {
                using (SqlConnection conec = objConecta.Conecta())
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("ReporteProductosMasRentables", conec))
                    {
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adaptador.Fill(data, "ProductosMasRentables");
                    }
                }
                return data;
            }
        }

    }
}
        