using System;
using System.Collections.Generic;

namespace CamadaEntidade
{
    public class Categoria
    {
        public int CodigoCategoria { get; set; }
        public string CDDCategoria { get; set; }
        public string NomeCategoria { get; set; }        
        public Utilizador Utilizador { get; set; }
        public DateTime DataHoraCategoria { get; set; }
        public string EstadoCategoria { get; set; }

        public List<Categoria> ListaCategoria = new List<Categoria>();
        public Categoria()
        {
            Utilizador = new Utilizador();
        }
    }
}
