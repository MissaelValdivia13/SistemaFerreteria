﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ErroresCN
    {
        ErroresDAO error = new ErroresDAO();
        public DataSet consultaClientes()
        {
            return error.consultaClientes();
        }

    }
}
