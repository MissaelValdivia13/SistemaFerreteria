using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocio;

namespace CapaNegocio
{
    public class ComprasCN
    {
        ComprasDAO compra = new ComprasDAO();
        public void EnviarCompraYDetalle(int idProveedor, string facturas, string fecha, double iva, double subtotal, DataTable detalleData)
        {
            compra.EnviarCompraYDetalle(idProveedor, facturas, fecha, iva, subtotal, detalleData);
        }

        public int nuevaCompra()
        {
            return compra.nuevaCompra();
        }
    }
}
