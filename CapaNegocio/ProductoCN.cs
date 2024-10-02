using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ProductoCN
    {
        ProductosDAO productsDAO  = new ProductosDAO();

        public DataSet consultaProcutos()
        {
            return productsDAO.consultaProductos();
        }

        public void subeProducto(int idCategoria, string nombre, double precio, double costoPromedio, int existencias, int maximo, int minimo)
        {
            productsDAO.insertProducto(idCategoria,nombre,precio,costoPromedio,existencias,maximo,minimo);
        }

        public void actualizaProducto(int idProducto, int idCategoria, string nombre, double precio,int maximo, int minimo)
        {
            productsDAO.actualizaProducto(idProducto, idCategoria, nombre, precio, maximo, minimo);
        }

        public int nuevoProducto()
        {
            return productsDAO.nuevoProducto();
        }

        public DataSet ConsultaProd(string opcion, string valor)
        {
            return productsDAO.consultaProductos(opcion, valor);
        }
    }
}
