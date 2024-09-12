using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CategoriaCN
    {
        CategoriaDAO objCategoria = new CategoriaDAO();

        public DataSet consultarCategoria()
        {
            return objCategoria.consultarCategoria();
        }

        public void subeCategoria(string concepto)
        {
            objCategoria.subeCategoria(concepto);
        }

        public int nuevaCategoria()
        {
            return objCategoria.nuevaCategoria();
        }
    }
}
