using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class Cliente
    {
        private int idCliente;
        private string nombre;
        private string telefono;
        private string email;
        private string domicilio;

        public Cliente(string nombre, string telefono, string email, string domicilio)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.email = email;
            this.domicilio = domicilio;
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

    }
}
