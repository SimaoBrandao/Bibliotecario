using System;
using System.Collections.Generic;

namespace CamadaEntidade
{
    public class Formato
    {
        public int CodigoFormato { get; set; }
        public string NomeFormato { get; set; }
        public Utilizador Utilizador { get; set; }
        public DateTime DataHoraFormato { get; set; }
        public string EstadoFormato { get; set; }

        public List<Formato> ListaFormato = new List<Formato>();
        public Formato()
        {
            Utilizador = new Utilizador();
        }
    }
}
