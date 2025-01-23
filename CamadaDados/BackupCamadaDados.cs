using MySql.Data.MySqlClient;
using System;

namespace CamadaDados
{
    public class BackupCamadaDados : IBackupCamadaDados
    {
        private string connectionString = DatabaseConnection.ConnectionString();       

        public BackupCamadaDados()
        {
            connectionString += "charset=utf8mb4;convertzerodatetime=true;";
        }
       
        public void FazerBackup(string caminhoBackup)
        {
            try
            { 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(caminhoBackup);
                            conn.Close();
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar o backup: " + ex.Message);
            }   

        }

        public void RestaurarBackup(string caminhoBackup)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(caminhoBackup);
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao restaurar o backup: " + ex.Message);
            }
        }
       
    }
}
