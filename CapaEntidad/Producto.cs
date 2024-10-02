using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        private int idProducto;
        private int idCategoria;
        private string nombre;
        private double precio;
        private double costoPromedio;
        private int existencia;
        private int maximo;
        private int minimo;
        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public double CostoPromedio
        {
            get { return costoPromedio; }
            set { costoPromedio = value; }
        }

        public int Existencia
        {
            get { return existencia; }
            set { existencia = value; }
        }

        public int Maximo
        {
            get { return maximo; }
            set { maximo = value; }
        }

        public int Minimo
        {
            get { return minimo; }
            set { minimo = value; }
        }
    }
}
