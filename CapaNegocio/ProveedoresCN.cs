using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class ProveedoresCN
    {
        ProveedoresDAO objProveedor = new ProveedoresDAO();

        public DataSet consultaProveedores()
        {
            return objProveedor.consultaProveedores();
        }

        public void subeProveedor(string empresa, string contacto, string telefono, string domicilio)
        {
            objProveedor.subeProveedor(empresa, contacto,telefono,domicilio);
        }

        public int nuevoProveedor()
        {
            return objProveedor.nuevoProveedor();
        }

        public void actualizaProveedor(int idProveedor, string empresa, string contacto, string telefono, string direccion)
        {
            objProveedor.actualizaProveedor(idProveedor,empresa,contacto,telefono,direccion);
        }

        public DataSet consultaProveedor(string opcion, string valor)
        {
            return objProveedor.consultaProveedores(opcion, valor);
        }
    }
}
