using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaDados
{
    public interface IFormatoCamadaDados
    {
        void AdicionarFormato(Formato formato);
        void AtualizarFormato(Formato formato);
        void ExcluirFormato(int CodigoFormato);
        Formato ObterFormatoPorCodigo(int CodigoFormato);
        List<Formato> ObterTodosFormatos();
        List<Formato> ObterFormatoPorNome(string NomeFormato);
    }
}
