using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CobroCN
    {
        CobroDAO cobro = new CobroDAO();
        public int nuevaCobro()
        {
            return cobro.nuevaCobro();
        }
        public DataSet ObtenerVentasPorCliente(int idCliente)
        {
            return cobro.ObtenerVentasPorCliente(idCliente);
        }


        public void RealizarCobro(int idCliente, int idVenta, double monto, double cantidad,int idEmpleado)
        {
             cobro.RealizarCobro(idCliente,idVenta, monto,cantidad, idEmpleado);
        }

        public DataSet ConsultarCobrosDinamicamente(string opcion, string valor)
        {
            return cobro.ConsultarCobrosDinamicamente(opcion, valor);
        }
    }
}
