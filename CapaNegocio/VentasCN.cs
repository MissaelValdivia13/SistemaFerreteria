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

        public void insertarVenta(int idCliente, int idEmpleado, string fecha, double total, DataTable table)
        {
            ventas.insertarVenta(idCliente, idEmpleado, fecha, total, table);
        }

        public int nuevaVenta()
        {
            return ventas.nuevaVenta();
        }
    }
}
