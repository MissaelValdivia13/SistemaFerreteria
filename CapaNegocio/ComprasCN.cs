using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaNegocio
{
    public class ComprasCN
    {
        ComprasDAO compra = new ComprasDAO();
        public Boolean EnviarCompraYDetalle(int idProveedor, string facturas, string fecha, double iva, double subtotal, DataTable detalleData, int idEmpleado, string opcion)
        {
            return compra.EnviarCompraYDetalle(idProveedor, facturas, fecha, iva, subtotal, detalleData, idEmpleado, opcion);
        }

        public int nuevaCompra()
        {
            return compra.nuevaCompra();
        }

        public DataSet consultaCompra(string opcion, string valor)
        {
            return compra.consultaCompras(opcion, valor);
        }

        public DataSet consultaDetalleCompra(int id)
        {
            return compra.consultaDetalleCompra(id);
        }
    }
}
