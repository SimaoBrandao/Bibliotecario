using System;

namespace CamadaDados
{
    public interface IBackupCamadaDados
    {
        void FazerBackup(string caminhoBackup);
        void RestaurarBackup(string caminhoBackup);
    }
}
