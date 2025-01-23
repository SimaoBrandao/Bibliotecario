using System;
using System.ComponentModel.DataAnnotations;

namespace CamadaEntidade
{
    public class Utilizador 
    {
        public int CodigoUtilizador { get; set; }
        //NomeUtilizador
        [Required(ErrorMessage = "Informe o Nome do utilizador.")]
        public string NomeUtilizador { get; set; }
        //EmailUtilizador
        [Required(ErrorMessage = "Informe o E-mail.")]
        [EmailAddress(ErrorMessage = "Informe um E-mail válido.")]
        public string EmailUtilizador { get; set; }
        public string SenhaUtilizador { get; set; }
        public string NovaSenhaUtilizador { get; set; }
        public string ConfirmarNovaSenhaUtilizador { get; set; }
        public string SenhaAnteriorUtilizador { get; set; }
        public Perfil Perfil { get; set; }
        public DateTime DataHoraUtilizador { get; set; }
        public string EstadoUtilizador { get; set; }
        public static int CodigoUtilizadorLogado { get; set; }
        public static bool AlterarSenhaAposLogin { get; set; }
        public Utilizador()
        {
            Perfil = new Perfil();
        }
    }
}
