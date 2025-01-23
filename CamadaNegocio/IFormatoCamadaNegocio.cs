using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaNegocio
{
    public interface IFormatoCamadaNegocio
    {
        void AdicionarFormato(Formato formato);
        void AtualizarFormato(Formato formato);
        void ExcluirFormato(int CodigoFormato);
        Formato ObterFormatoPorCodigo(int CodigoFormato);
        List<Formato> ObterTodosFormatos();
        List<Formato> ObterFormatoPorNome(string NomeFormato);
    }
}
