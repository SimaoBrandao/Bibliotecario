using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaDados
{
    public interface IModalidadeCamadaDados
    {
        void AdicionarModalidade(Modalidade modalidade);
        void AtualizarModalidade(Modalidade modalidade);
        void ExcluirModalidade(int CodigoModalidade);
        Modalidade ObterModalidadePorCodigo(int CodigoModalidade);
        List<Modalidade> ObterTodasModalidade();
    }
}
