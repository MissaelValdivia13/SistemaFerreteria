using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public  class ClienteCN
    {
        ClienteDAO objCliente =  new ClienteDAO();
        Cliente cliente;

        public DataSet consultaClientes()
        {
            return objCliente.consultaClientes();
        }

        public void insertaCliente(string nombre, string telefono, string email, string domicilio)
        {
            objCliente.insertaCliente(nombre,telefono,email,domicilio);
        }

        public int nuevoCLiente()
        {
            return objCliente.nuevoCliente();
        }

        public void actualizarCliente(int idCliente, string nombre, string Telefono, string email, string domicilio)
        {
            objCliente.actualizaCliente(idCliente, nombre, Telefono, email, domicilio);
        }

        public DataSet consultaClientesD(string opcion, string valor)
        {
            return objCliente.consultaClientesD(opcion, valor);
        }
    }
}
