using System;
using System.Collections.Generic;

namespace CamadaEntidade
{
    public class Emprestimo
    {
        public int CodigoEmprestimo { get; set; }
        public Cliente Cliente { get; set; }
        public Acervo Acervo { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataPrevistaDevolucaoEmprestimo { get; set; }
        public DateTime? DataRealDevolucaoEmprestimo { get; set; }
        public Utilizador Utilizador { get; set; } 
        public DateTime DataHoraEmprestimo { get; set; }
        public string EstadoEmprestimo { get; set; }

        public List<Emprestimo> ListaEmprestimo = new List<Emprestimo>();
        public Emprestimo()
        {
            Cliente = new Cliente();
            Acervo = new Acervo();
            Utilizador = new Utilizador();
        }
    }
}
