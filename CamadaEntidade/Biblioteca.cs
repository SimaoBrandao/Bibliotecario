using System;

namespace CamadaEntidade
{
    public class Biblioteca
    {
        public int CodigoBiblioteca { get; set; }
        public string NomeBiblioteca { get; set; }
        public string NifBiblioteca { get; set; }
        public string TelemovelBiblioteca { get; set; }
        public string EmailBiblioteca { get; set; }
        public string EnderecoBiblioteca { get; set; }       
        public string CaminhoDiretorioLogotipoBiblioteca { get; set; } = "";
        public DateTime DataHoraBiblioteca { get; set; }
        public bool EstadoBiblioteca { get; set; }
    }
}
