using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Categoria
    {
        private int idCategoria;
        private string concepto;


        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

    }
}
