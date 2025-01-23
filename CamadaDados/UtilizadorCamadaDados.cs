using System;
using System.Collections.Generic;
using CamadaEntidade;
using MySql.Data.MySqlClient;

namespace CamadaDados
{
    public class UtilizadorCamadaDados : IUtilizadorCamadaDados
    {
        private readonly string connectionString = DatabaseConnection.ConnectionString();
        public void AdicionarUtilizador(Utilizador utilizador)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "INSERT INTO utilizador (NomeUtilizador,EmailUtilizador,SenhaUtilizador,codigoPerfilUtilizador) VALUES (@NomeUtilizador,@EmailUtilizador,@SenhaUtilizador,@codigoPerfilUtilizador)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeUtilizador", utilizador.NomeUtilizador);
                        cmd.Parameters.AddWithValue("@EmailUtilizador", utilizador.EmailUtilizador);
                        cmd.Parameters.AddWithValue("@SenhaUtilizador", utilizador.SenhaUtilizador);
                        cmd.Parameters.AddWithValue("@codigoPerfilUtilizador", utilizador.Perfil.CodigoPerfil);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarUtilizador(Utilizador utilizador)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE utilizador SET NomeUtilizador = @NomeUtilizador,EmailUtilizador = @EmailUtilizador,codigoPerfilUtilizador = @codigoPerfilUtilizador WHERE CodigoUtilizador = @CodigoUtilizador";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeUtilizador", utilizador.NomeUtilizador);
                        cmd.Parameters.AddWithValue("@EmailUtilizador", utilizador.EmailUtilizador);
                        cmd.Parameters.AddWithValue("@CodigoPerfilUtilizador", utilizador.Perfil.CodigoPerfil);
                        cmd.Parameters.AddWithValue("@CodigoUtilizador", utilizador.CodigoUtilizador);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ExcluirUtilizador(int CodigoUtilizador)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE utilizador SET EstadoUtilizador = 'Inativo' WHERE CodigoUtilizador = @CodigoUtilizador";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoUtilizador", CodigoUtilizador);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Utilizador> ObterTodosUtilizador()
        {
            try
            {
                List<Utilizador> listaUtilizador = new List<Utilizador>();
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoUtilizador,nomeUtilizador,emailUtilizador, senhaUtilizador, Perfil.NomePerfil,EstadoUtilizador FROM utilizador inner join Perfil on Utilizador.CodigoPerfilUtilizador = Perfil.CodigoPerfil WHERE EstadoUtilizador != 'Inativo'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Utilizador utilizador = new Utilizador();
                                utilizador.CodigoUtilizador = reader.GetInt32("CodigoUtilizador");
                                utilizador.NomeUtilizador = reader.GetString("nomeUtilizador");
                                utilizador.EmailUtilizador = reader.GetString("EmailUtilizador");
                                utilizador.SenhaUtilizador = reader.GetString("SenhaUtilizador");
                                utilizador.Perfil.NomePerfil = reader.GetString("NomePerfil");
                                utilizador.EstadoUtilizador = reader.GetString("EstadoUtilizador");
                                listaUtilizador.Add(utilizador);
                            }
                        }
                    }
                }
                return listaUtilizador;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Utilizador ObterUtilizadorPorCodigo(int CodigoUtilizador)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoUtilizador,nomeUtilizador,emailUtilizador,senhaUtilizador,Perfil.NomePerfil, estadoUtilizador FROM utilizador inner join Perfil on Utilizador.CodigoPerfilUtilizador = Perfil.CodigoPerfil WHERE CodigoUtilizador = @codigoUtilizador AND EstadoUtilizador = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoUtilizador", CodigoUtilizador);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Utilizador utilizador = new Utilizador();
                            if (reader.Read())
                            {
                                utilizador.CodigoUtilizador = reader.GetInt32("CodigoUtilizador");
                                utilizador.NomeUtilizador = reader.GetString("nomeUtilizador");
                                utilizador.EmailUtilizador = reader.GetString("EmailUtilizador");
                                utilizador.SenhaUtilizador = reader.GetString("SenhaUtilizador");
                                utilizador.Perfil.NomePerfil = reader.GetString("NomePerfil");
                                utilizador.EstadoUtilizador = reader.GetString("EstadoUtilizador");
                            }
                            return utilizador;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Utilizador ObterUtilizadorPorEmail(string EmailUtilizador)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoUtilizador,nomeUtilizador,emailUtilizador,senhaUtilizador,Perfil.NomePerfil FROM utilizador inner join Perfil on Utilizador.CodigoPerfilUtilizador = Perfil.CodigoPerfil WHERE EmailUtilizador = @EmailUtilizador AND EstadoUtilizador = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@EmailUtilizador", EmailUtilizador);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Utilizador utilizador = new Utilizador();
                            if (reader.Read())
                            {
                                utilizador.CodigoUtilizador = reader.GetInt32("CodigoUtilizador");
                                utilizador.NomeUtilizador = reader.GetString("nomeUtilizador");
                                utilizador.EmailUtilizador = reader.GetString("EmailUtilizador");
                                utilizador.SenhaUtilizador = reader.GetString("SenhaUtilizador");
                                utilizador.Perfil.NomePerfil = reader.GetString("NomePerfil");
                            }
                            return utilizador;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Login(string EmailUtilizador, string SenhaUtilizador)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoUtilizador, alterarSenhaAposLogin FROM utilizador WHERE emailUtilizador = @EmailUtilizador AND senhaUtilizador = @SenhaUtilizador AND EstadoUtilizador = 'Ativo'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@EmailUtilizador", EmailUtilizador);
                        cmd.Parameters.AddWithValue("@SenhaUtilizador", SenhaUtilizador);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            bool Autenticado = false;

                            if (reader.Read())
                            {
                                Utilizador.CodigoUtilizadorLogado = reader.GetInt32("CodigoUtilizador");
                                Utilizador.AlterarSenhaAposLogin = reader.GetBoolean("alterarSenhaAposLogin");
                                Autenticado = true;
                            }

                            return Autenticado;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AlterarSenhaUtilizador(int CodigoUtilizador, string NovaSenhaUtilizador)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE utilizador SET SenhaUtilizador = @NovaSenhaUtilizador, alterarSenhaAposLogin = false WHERE CodigoUtilizador = @CodigoUtilizador";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NovaSenhaUtilizador", NovaSenhaUtilizador);
                        cmd.Parameters.AddWithValue("@CodigoUtilizador", CodigoUtilizador);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerificarSeExisteUtilizador()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT COUNT(*) FROM utilizador WHERE EstadoUtilizador = 'Ativo'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        // Se count > 0, existe utilizador cadastrado
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RedefinirSenhaUtilizador(int CodigoUtilizador, string SenhaTemporaria)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE utilizador SET SenhaUtilizador = @SenhaTemporaria, alterarSenhaAposLogin = true WHERE CodigoUtilizador = @CodigoUtilizador";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@SenhaTemporaria", SenhaTemporaria);
                        cmd.Parameters.AddWithValue("@CodigoUtilizador", CodigoUtilizador);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void BloquearUtilizador(int CodigoUtilizador)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE utilizador SET EstadoUtilizador = 'Bloqueado' WHERE CodigoUtilizador = @CodigoUtilizador";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoUtilizador", CodigoUtilizador);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DesbloquearUtilizador(int CodigoUtilizador)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE utilizador SET EstadoUtilizador = 'Ativo' WHERE CodigoUtilizador = @CodigoUtilizador";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoUtilizador", CodigoUtilizador);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
