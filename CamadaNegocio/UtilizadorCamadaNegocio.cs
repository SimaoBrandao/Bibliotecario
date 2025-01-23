using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using CamadaDados;
using CamadaEntidade;

namespace CamadaNegocio
{
    public class UtilizadorCamadaNegocio : IUtilizadorCamadaNegocio
    {
        private readonly IUtilizadorCamadaDados utilizadorCamadaDados = new UtilizadorCamadaDados();
        private ValidacaoCamadaNegocio validacaoCamadaNegocio = new ValidacaoCamadaNegocio();
        public void NovaContaUtilizador(Utilizador utilizador)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(utilizador))
                {
                    utilizador.Perfil.CodigoPerfil = 1;
                    utilizador.SenhaUtilizador = GerarHashSenhaUtilizador(utilizador.SenhaUtilizador);
                    utilizadorCamadaDados.AdicionarUtilizador(utilizador);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao Criar a Conta do utilizador. " + ex.Message);
            }
        }
        public void AdicionarUtilizador(Utilizador utilizador)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(utilizador))
                {
                    utilizador.SenhaUtilizador = GerarHashSenhaUtilizador(utilizador.SenhaUtilizador);
                    utilizadorCamadaDados.AdicionarUtilizador(utilizador);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao adicionar o utilizador " + ex.Message);
            }
        }

        public void AtualizarUtilizador(Utilizador utilizador)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(utilizador))
                {
                    utilizadorCamadaDados.AtualizarUtilizador(utilizador);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao atualizar o utilizador. " + ex.Message);
            }
        }
        public void ExcluirUtilizador(int CodigoUtilizador)
        {
            try
            {
                if (CodigoUtilizador > 0)
                {
                    utilizadorCamadaDados.ExcluirUtilizador(CodigoUtilizador);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao excluir o utilizador. " + ex.Message);
            }
        }
        public List<Utilizador> ObterTodosUtilizador()
        {
            try
            {
                return utilizadorCamadaDados.ObterTodosUtilizador();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o utilizador. " + ex.Message);
            }
        }
        public Utilizador ObterUtilizadorPorCodigo(int CodigoUtilizador)
        {
            try
            {
                Utilizador utilizador = new Utilizador();

                if (CodigoUtilizador > 0)
                {
                    utilizador = utilizadorCamadaDados.ObterUtilizadorPorCodigo(CodigoUtilizador);
                }

                return utilizador;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o utilizador. " + ex.Message);
            }
        }
        public Utilizador ObterUtilizadorPorEmail(string EmailUtilizador)
        {
            try
            {
                Utilizador utilizador = new Utilizador();

                if (!string.IsNullOrEmpty(EmailUtilizador))
                {
                    utilizador = utilizadorCamadaDados.ObterUtilizadorPorEmail(EmailUtilizador);
                }

                return utilizador;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o utilizador. " + ex.Message);
            }
        }

        public bool Login(string EmailUtilizador, string SenhaUtilizador)
        {
            try
            {
                Utilizador.CodigoUtilizadorLogado = 0;
                SenhaUtilizador = GerarHashSenhaUtilizador(SenhaUtilizador);

                bool Autenticado = utilizadorCamadaDados.Login(EmailUtilizador, SenhaUtilizador);

                if (Autenticado)
                {
                    return Autenticado;
                }
                else
                {
                    throw new ArgumentException("E-mail ou Senha inválida");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private string GerarHashSenhaUtilizador(string senhaUtilizador)
        {
            try
            {
                //Criptografa a Senha se não estiver em branco e se foi alterada.
                if (!string.IsNullOrEmpty(senhaUtilizador))
                {
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        // Converter a senha em bytes
                        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senhaUtilizador));

                        // Converter bytes em string hexadecimal
                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            builder.Append(bytes[i].ToString("x2"));
                        }

                        return builder.ToString();
                    }
                }
                else
                {
                    return senhaUtilizador;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao criptografar a senha do utilizador. " + ex.Message);
            }
        }

        private bool ValidarSenhaUtilizador(Utilizador utilizador)
        {
            try
            {
                bool estado = true;
                //obtem a senha do utilizador armazenada na bd.
                var db = utilizadorCamadaDados.ObterUtilizadorPorCodigo(utilizador.CodigoUtilizador);
                //Criptografar a senha inserida pelo utilizador.
                string senhaAtualInseridaPeloUtilizador = GerarHashSenhaUtilizador(utilizador.SenhaUtilizador);

                if (db.SenhaUtilizador != senhaAtualInseridaPeloUtilizador)
                {
                    estado = false;
                    throw new ArgumentException("A Senha atual é Inválida");
                }
                if (utilizador.NovaSenhaUtilizador != utilizador.ConfirmarNovaSenhaUtilizador)
                {
                    estado = false;
                    throw new ArgumentException("As Senhas não Coincidem");
                }

                return estado;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void AlterarSenhaUtilizador(Utilizador utilizador)
        {
            try
            {
                if (ValidarSenhaUtilizador(utilizador))
                {
                    utilizador.NovaSenhaUtilizador = GerarHashSenhaUtilizador(utilizador.NovaSenhaUtilizador);
                    utilizadorCamadaDados.AlterarSenhaUtilizador(utilizador.CodigoUtilizador, utilizador.NovaSenhaUtilizador);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void VerificarSeExisteUtilizador()
        {
            try
            {
                bool existeUtilizador = utilizadorCamadaDados.VerificarSeExisteUtilizador();

                if (existeUtilizador)
                {
                    throw new ArgumentException("Entre em contato com o Administrador para criar uma conta! ");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private string GerarSenhaTemporaria()
        {
            int numeroCaracteres = 9;// Gerar senha temporária única com 9 caracteres
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string senha;

            do
            {
                StringBuilder senhaBuilder = new StringBuilder();
                for (int i = 0; i < numeroCaracteres; i++)
                {
                    int index = random.Next(caracteres.Length);
                    senhaBuilder.Append(caracteres[index]);
                }
                senha = senhaBuilder.ToString();
            } while (!ValidarSenhaTemporaria(senha));

            return senha;
        }

        private bool ValidarSenhaTemporaria(string senha)
        {
            // Verificar se contém pelo menos uma letra maiúscula, uma minúscula e um número
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char c in senha)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasUpper && hasLower && hasDigit;
        }

        private void EnviarSenhaPorEmail(string EmailUtilizador, string SenhaTemporaria)
        {
            try
            {
                // Configuração do cliente SMTP
                string servidorSmtp = ClienteSMTP.CarregarDadosClienteSMTP("data1.dat");  
                int portaSmtp = int.Parse(ClienteSMTP.CarregarDadosClienteSMTP("data2.dat"));
                string emailRemetente = ClienteSMTP.CarregarDadosClienteSMTP("data3.dat");
                string senhaRemetente = ClienteSMTP.CarregarDadosClienteSMTP("data4.dat");

                SmtpClient clienteSmtp = new SmtpClient(servidorSmtp, portaSmtp)
                {
                    Credentials = new NetworkCredential(emailRemetente, senhaRemetente),
                    EnableSsl = true
                };

                // Criando a mensagem de e-mail
                string emailDestinatario = EmailUtilizador;
                string assuntoEmail = "Redefinição de senha";
                string corpoEmail = "Olá,\n\nSua senha temporária é: " + SenhaTemporaria + "\nPor favor, use-a para acessar o sistema e redefinir sua senha.\n\nAtenciosamente,\nEquipe de Suporte";

                MailMessage mensagem = new MailMessage(emailRemetente, emailDestinatario, assuntoEmail, corpoEmail);

                // Enviando o e-mail de forma assíncrona
                clienteSmtp.SendMailAsync(mensagem);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }


        public void RedefinirSenhaUtilizador(int CodigoUtilizador)
        {
            try
            {
                if (CodigoUtilizador > 0)
                {
                    // Gerar senha temporária única com 9 caracteres
                    string senhaTemporaria = GerarSenhaTemporaria();

                    //Obter o Email do Utilizador
                    var utilizador = ObterUtilizadorPorCodigo(CodigoUtilizador);

                    // Enviar a senha temporária por e-mail
                    EnviarSenhaPorEmail(utilizador.EmailUtilizador, senhaTemporaria);

                    // Gerar hash da senha temporária e salvar no banco de dados
                    string hashSenhaTemporaria = GerarHashSenhaUtilizador(senhaTemporaria);
                    utilizadorCamadaDados.RedefinirSenhaUtilizador(CodigoUtilizador, hashSenhaTemporaria);
                }
                else
                {
                    throw new ArgumentException("Selecione o Utilizador");
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void RedefinirSenhaUtilizador(string EmailUtilizador)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(EmailUtilizador))
                {
                    // Gerar senha temporária única com 9 caracteres
                    string senhaTemporaria = GerarSenhaTemporaria();

                    //Obter o Codigo do Utilizador
                    var utilizador = ObterUtilizadorPorEmail(EmailUtilizador);

                    if(utilizador.CodigoUtilizador <= 0)
                    {
                        throw new ArgumentException("Email Inválido");
                    }

                    // Enviar a senha temporária no e-mail do utilizador
                    EnviarSenhaPorEmail(EmailUtilizador, senhaTemporaria);

                    // Gerar hash da senha temporária e salvar no banco de dados
                    string hashSenhaTemporaria = GerarHashSenhaUtilizador(senhaTemporaria);
                    utilizadorCamadaDados.RedefinirSenhaUtilizador(utilizador.CodigoUtilizador, hashSenhaTemporaria);

                }
                else
                {
                    throw new ArgumentException("Email Inválido");
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void BloquearUtilizador(int CodigoUtilizador)
        {
            try
            {
                if (CodigoUtilizador > 0)
                {
                    var utilizador = ObterUtilizadorPorCodigo(CodigoUtilizador);
                    if(utilizador.EstadoUtilizador == "Bloqueado")
                    {
                        throw new ArgumentException("O utilizador já encontra-se Bloqueado.");
                    }
                    else
                    {
                        utilizadorCamadaDados.BloquearUtilizador(CodigoUtilizador);
                    }                   
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void DesbloquearUtilizador(int CodigoUtilizador)
        {
            try
            {
                if (CodigoUtilizador > 0)
                {
                    var utilizador = ObterUtilizadorPorCodigo(CodigoUtilizador);
                    if (utilizador.EstadoUtilizador == "Ativo")
                    {
                        throw new ArgumentException("O utilizador já encontra-se Desbloqueado.");
                    }
                    else
                    {
                        utilizadorCamadaDados.DesbloquearUtilizador(CodigoUtilizador);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
