using System;
using System.Collections.Generic;

namespace CamadaEntidade
{
    public class Acervo
    {
        public int CodigoAcervo { get; set; }       
        public string TituloAcervo { get; set; }       
        public Categoria Categoria { get; set; }
        public string CDDAcervo { get; set; }
        public Formato Formato { get; set; }
        public string IdiomaAcervo { get; set; }
        public string AutorAcervo { get; set; }
        public string EditoraAcervo { get; set; }
        public int AnoPublicacaoAcervo { get; set; }
        public string ISBNAcervo { get; set; }
        public int QuantidadeAcervo { get; set; }       
        public string LocalizacaoAcervo { get; set; }
        public int QuantidadeAnteriorAcervo { get; set; }
        public string CodigoIdentificadorAcervo { get; set; }
        public Utilizador Utilizador { get; set; }
        public DateTime DataHoraAcervo { get; set; }
        public string EstadoAcervo { get; set; }
        public static int CodigoAcervoTransferencia { get; set; }

        public List<Acervo> ListaAcervos = new List<Acervo>();
        public Acervo()
        {
            Categoria = new Categoria();
            Formato = new Formato();
            Utilizador = new Utilizador();
        }
    }
}
