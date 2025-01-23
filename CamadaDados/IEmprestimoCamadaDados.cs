using CamadaEntidade;
using System;
using System.Collections.Generic;

namespace CamadaDados
{
    public interface IEmprestimoCamadaDados
    {
        void AdicionarEmprestimo(Emprestimo emprestimo);
        void AtualizarEmprestimo(Emprestimo emprestimo);
        void ExcluirEmprestimo(int CodigoEmprestimo);
        void DevolucaoEmprestimo(Emprestimo emprestimo);
        void AnularDevolucaoEmprestimo(int CodigoEmprestimo);
        List<Emprestimo> ObterTodosEmprestimo();
        Emprestimo ObterEmprestimoPorCodigo(int CodigoEmprestimo);
        List<Emprestimo> ObterEmprestimoPorNomeCliente(string NomeCliente);
        List<Emprestimo> ObterEmprestimoPorCDDAcervo(int CDDAcervo);
        List<Emprestimo> ObterEmprestimoPorTituloAcervo(string TituloAcervo);
        List<Emprestimo> ObterEmprestimoPorDataEmprestimo(DateTime DataEmprestimo);
        bool VerificarAcervoEmprestado(int CodigoAcervo);
        bool VerificarSeEmprestimoFoiDevolvido(int CodigoEmprestimo);
    }
}
