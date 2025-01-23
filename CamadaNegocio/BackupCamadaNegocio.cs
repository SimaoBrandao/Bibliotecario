using CamadaDados;
using System;
using System.IO;

namespace CamadaNegocio
{
    public class BackupCamadaNegocio : IBackupCamadaNegocio
    {
        private IBackupCamadaDados backupCamadaDados = new BackupCamadaDados();
        public void FazerBackup(string caminhoBackup)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(caminhoBackup))
                {
                    throw new ArgumentException("Caminho do arquivo de backup não pode ser vazio.");
                }
                else
                {
                    string CaminhoBackup = Path.Combine(caminhoBackup, $"Backup_{DateTime.Now:yyyyMMddHHmmss}.sql");
                    backupCamadaDados.FazerBackup(CaminhoBackup);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao realizar o backup. " + ex.Message);
            }

        }

        public void RestaurarBackup(string caminhoBackup)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(caminhoBackup) || !File.Exists(caminhoBackup))
                {
                    throw new FileNotFoundException("Arquivo de backup não encontrado.");
                }
                else
                {
                    backupCamadaDados.RestaurarBackup(caminhoBackup);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao restaurar o backup. " + ex.Message);
            }
            
        }
    }
}
