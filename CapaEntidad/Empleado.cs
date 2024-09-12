using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleado
    {
        private int idEmpleado;
        private string nombre;
        private string puesto;
        private string telefono;

        private int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        private string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        private string Telefono
        {
            get { return  telefono; }
            set { telefono = value; }
        }

    }
}
