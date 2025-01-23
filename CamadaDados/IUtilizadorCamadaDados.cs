using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaDados
{
    public interface IUtilizadorCamadaDados 
    {
        void AdicionarUtilizador(Utilizador utilizador);
        void AtualizarUtilizador(Utilizador utilizador);
        void ExcluirUtilizador(int CodigoUtilizador);
        List<Utilizador> ObterTodosUtilizador();
        Utilizador ObterUtilizadorPorCodigo(int CodigoUtilizador);
        Utilizador ObterUtilizadorPorEmail(string EmailUtilizador);
        bool Login(string EmailUtilizador, string SenhaUtilizador);
        void AlterarSenhaUtilizador(int CodigoUtilizador, string NovaSenhaUtilizador);
        void RedefinirSenhaUtilizador(int CodigoUtilizador, string NovaSenhaUtilizador);
        bool VerificarSeExisteUtilizador();
        void BloquearUtilizador(int CodigoUtilizador);
        void DesbloquearUtilizador(int CodigoUtilizador);
    }
}
