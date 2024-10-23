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

        public Boolean EnviarVentaYDetalle(int idCliente, int idEmpleado, string fecha, double total, double saldo , char estado,DataTable detalleData, string opcion)
        {
            return ventas.EnviarVentaYDetalle(idCliente, idEmpleado, fecha, total, saldo, estado, detalleData, opcion);
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

        public DataSet ObtenerVentaPorId(int idVenta)
        {
            return ventas.ObtenerVentaPorId(idVenta);
        }

    }
}
