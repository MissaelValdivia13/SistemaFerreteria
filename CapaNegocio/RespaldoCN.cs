using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class RespaldoCN
    {
        Respaldos Respaldos = new Respaldos();
        public void BackupDatabase()
        {
            Respaldos.BackupDatabase();
        }

        public void RestoreDatabase(string backupFilePath)
        {
            Respaldos.RestoreDatabase(backupFilePath);
        }

        public void InsertarError(int idEmpleado, string opcion, String descripcion)
        {
            Respaldos.InsertarError(idEmpleado, opcion, descripcion);
        }
    }
}
