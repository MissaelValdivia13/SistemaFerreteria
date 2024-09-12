using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedores
    {
        private int idProveedor;
        private string empresa;
        private string contacto;
        private string telefono;
        private string domicilio;

        public int IdProveedor 
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }
        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

    }
}
