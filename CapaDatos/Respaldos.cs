using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Respaldos
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;

        public void BackupDatabase()
        {
                conec = objConecta.Conecta();
                SqlCommand command = new SqlCommand("BackupSistemaFerreteria", conec);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    command.ExecuteNonQuery();
                    conec.Close();

                }catch (SqlException ex)
                {
                    throw;
                }
            
        }

        public void RestoreDatabase(string backupFilePath)
        {
                try
                {
                conec = objConecta.ConectaMantenimiento();

                    using (SqlCommand command = new SqlCommand("RestoreSistemaFerreteria", conec))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BackupFileName", backupFilePath);

                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("Restauración completada exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error al restaurar la base de datos: " + ex.Message);
                    throw;
                }
                finally
                {
                    if (conec.State == ConnectionState.Open)
                    {
                        conec.Close();
                    }
                }
        }

        public void InsertarError(int idEmpleado, string opcion, string descripcion)
        {
                try
                {
                conec = objConecta.ConectaMantenimiento();

                    using (SqlCommand command = new SqlCommand("insertarError", conec))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@IdEmpleado", SqlDbType.Int)).Value = idEmpleado;

                        command.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar, 40)).Value = opcion;

                        command.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 255)).Value = descripcion;

                    command.ExecuteNonQuery();
                    }
                conec.Close();
            }
            catch (SqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
        }

    }
}
