using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaNegocio
{
    public interface IUtilizadorCamadaNegocio 
    {
        void NovaContaUtilizador(Utilizador utilizador);
        void AdicionarUtilizador(Utilizador utilizador);
        void AtualizarUtilizador(Utilizador utilizador);
        void ExcluirUtilizador(int CodigoUtilizador);
        List<Utilizador> ObterTodosUtilizador();
        Utilizador ObterUtilizadorPorCodigo(int CodigoUtilizador);
        Utilizador ObterUtilizadorPorEmail(string EmailUtilizador);
        bool Login(string EmailUtilizador, string SenhaUtilizador);
        void AlterarSenhaUtilizador(Utilizador utilizador);
        void RedefinirSenhaUtilizador(int CodigoUtilizador);
        void RedefinirSenhaUtilizador(string EmailUtilizador);
        void VerificarSeExisteUtilizador();
        void BloquearUtilizador(int CodigoUtilizador);
        void DesbloquearUtilizador(int CodigoUtilizador);
    }
}
