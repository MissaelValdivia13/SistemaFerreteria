using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
     public class Compras
    {
        public class Proveedor
        {
            private int idProveedor;
            private string facturas;
            private string fecha;
            private double iva;
            private double subtotal;

            public Proveedor(int idProveedor, string facturas, string fecha, double iva, double subtotal)
            {
                this.idProveedor = idProveedor;
                this.facturas = facturas;
                this.fecha = fecha;
                this.iva = iva;
                this.subtotal = subtotal;
            }

            public int IdProveedor
            {
                get { return idProveedor; }
                set { idProveedor = value; }
            }

            public string Facturas
            {
                get { return facturas; }
                set { facturas = value; }
            }

            public string Fecha
            {
                get { return fecha; }
                set { fecha = value; }
            }

            public double Iva
            {
                get { return iva; }
                set { iva = value; }
            }

            public double Subtotal
            {
                get { return subtotal; }
                set { subtotal = value; }
            }
        }


    }
}
