using System;
using System.Collections.Generic;

namespace CamadaEntidade
{
    public class Cliente
    {
        public int CodigoCliente { get; set; }
        public string NomeCliente { get; set; }
        public string GeneroCliente { get; set; }
        public Modalidade Modalidade { get; set; }
        public string NumeroBilheteIdentidadeCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string TelemovelCliente { get; set; }        
        public string EmailCliente { get; set; }
        public Utilizador Utilizador { get; set; }
        public DateTime DataHoraCliente { get; set; }
        public int EstadoCliente { get; set; }

        public List<Cliente> ListaCliente = new List<Cliente>();
        public static int CodigoClienteTransferencia { get; set; }
        public Cliente()
        {
            Utilizador = new Utilizador();
            Modalidade = new Modalidade();
        }
    }
}
