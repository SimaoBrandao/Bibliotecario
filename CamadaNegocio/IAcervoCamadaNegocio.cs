using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaNegocio
{
    public interface IAcervoCamadaNegocio
    {
        void AdicionarAcervo(Acervo acervo);
        void AtualizarAcervo(Acervo acervo);
        void ExcluirAcervo(int CodigoAcervo);
        Acervo ObterAcervo(int CodigoAcervo);
        List<Acervo> ObterTodosAcervos();
        List<Acervo> ObterAcervoPorCDD(string CDDAcervo);
        List<Acervo> ObterAcervoPorTitulo(string TituloAcervo);
        List<Acervo> ObterAcervoPorNomeCategoria(string NomeCategoria);
        List<Acervo> ObterAcervoPorLocalizacao(string LocalizacaoAcervo);
        string GerarProximoCDD(int CodigoCategoriaAcervo, string CDDAcervo = "");
    }
}
