using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class VentasCN
    {
        private VentasDAO ventas = new VentasDAO();

        public Boolean EnviarVentaYDetalle(int idCliente, string fecha, double total, DataTable detalleData, int idEmpleado, string opcion)
        {
            return ventas.EnviarVentaYDetalle(idCliente, fecha, total, detalleData, idEmpleado, opcion);
        }

        public int nuevaVenta()
        {
            return ventas.nuevaVenta();
        }

        public DataSet consultaVentas(string opcion, string valor)
        {
            return ventas.consultaVentas(opcion, valor);
        }

        public DataSet consultaDetalleVenta(int idVenta)
        {
            return ventas.consultaDetalleVenta(idVenta);
        }

    }
}
