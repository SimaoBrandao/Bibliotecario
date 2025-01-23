using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaDados
{
    public interface IAcervoCamadaDados
    {
        void AdicionarAcervo(Acervo acervo);
        void AtualizarAcervo(Acervo acervo);
        void ExcluirAcervo(int CodigoAcervo);
        Acervo ObterAcervoPorCodigo(int CodigoAcervo);
        List<Acervo> ObterTodosAcervos();        
        List<Acervo> ObterAcervoPorTitulo(string TituloAcervo);
        List<Acervo> ObterAcervoPorCDD(string CDDAcervo);
        List<Acervo> ObterAcervoPorNomeCategoria(string NomeCategoria);
        List<Acervo> ObterAcervoPorLocalizacao(string LocalizacaoAcervo);
        string ObterUltimoCDDAcervo(int CodigoCategoriaAcervo);
        bool VerificarSeCDDExiste(string CDDAcervo, int CodigoCategoriaAcervo);
    }
}
