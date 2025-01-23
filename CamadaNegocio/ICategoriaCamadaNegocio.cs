using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaNegocio
{
    public interface ICategoriaCamadaNegocio
    {
        void AdicionarCategoria(Categoria categoria);
        void AtualizarCategoria(Categoria categoria);
        void ExcluirCategoria(int CodigoCategoria);
        Categoria ObterCategoriaPorCodigo(int CodigoCategoria);
        List<Categoria> ObterTodasCategorias();
        List<Categoria> ObterCategoriaPorNome(string NomeCategoria);
    }
}
