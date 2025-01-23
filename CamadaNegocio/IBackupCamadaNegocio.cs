using System;

namespace CamadaNegocio
{
    public interface IBackupCamadaNegocio
    {
        void FazerBackup(string caminhoBackup);
        void RestaurarBackup(string caminhoBackup);
    }
}
