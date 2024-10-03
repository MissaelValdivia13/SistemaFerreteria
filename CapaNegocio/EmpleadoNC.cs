using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class EmpleadoNC
    {
        EmpleadoDAO empleado = new EmpleadoDAO();

        public DataSet consultaEmpleados()
        {
            return empleado.consultaEmpleados();
        }

        public void subeEmpleado(string nombre, string puesto, string telefono, string contra)
        {
            empleado.subeEmpleado(nombre,puesto,telefono, contra);
        }

        public int nuevoEmpleado()
        {
            return empleado.nuevoEmpleado();
        }

        public void actualizaEmpleado(int idEmpleado, string nombre, string puesto, string telefono, string contra)
        {
            empleado.actualizaEmpleado(idEmpleado, nombre, puesto, telefono, contra);
        }

        public int ValidarEmpleado(string nombre, string contra)
        {
            return empleado.ValidarEmpleado(nombre, contra);
        }

    }
}
