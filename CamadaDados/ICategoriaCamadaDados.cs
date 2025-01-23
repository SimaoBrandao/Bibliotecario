using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaDados
{
    public interface ICategoriaCamadaDados
    {
        void AdicionarCategoria(Categoria categoria);
        void AtualizarCategoria(Categoria categoria);
        void ExcluirCategoria(int CodigoCategoria);
        Categoria ObterCategoriaPorCodigo(int CodigoCategoria);
        List<Categoria> ObterTodasCategorias();
        List<Categoria> ObterCategoriaPorNome(string NomeCategoria);
    }
}
