using System;
using System.Collections.Generic;
using CamadaEntidade;
using MySql.Data.MySqlClient;

namespace CamadaDados
{
    public class ClienteCamadaDados : IClienteCamadaDados
    {
        private readonly string connectionString = DatabaseConnection.ConnectionString();
        public void AdicionarCliente(Cliente cliente)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "INSERT INTO Cliente (nomeCliente,generoCliente,codigoModalidadeCliente,NumeroBilheteIdentidadeCliente,EnderecoCliente,TelemovelCliente,EmailCliente,codigoUtilizadorCliente) VALUES (@nomeCliente,@generoCliente,@codigoModalidadeCliente,@NumeroBilheteIdentidadeCliente,@EnderecoCliente,@TelemovelCliente,@EmailCliente,@codigoUtilizadorCliente)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente);
                        cmd.Parameters.AddWithValue("@GeneroCliente", cliente.GeneroCliente);
                        cmd.Parameters.AddWithValue("@codigoModalidadeCliente", cliente.Modalidade.CodigoModalidade);
                        cmd.Parameters.AddWithValue("@NumeroBilheteIdentidadeCliente", cliente.NumeroBilheteIdentidadeCliente);
                        cmd.Parameters.AddWithValue("@EnderecoCliente", cliente.EnderecoCliente);
                        cmd.Parameters.AddWithValue("@TelemovelCliente", cliente.TelemovelCliente);
                        cmd.Parameters.AddWithValue("@EmailCliente", cliente.EmailCliente);
                        cmd.Parameters.AddWithValue("@CodigoUtilizadorCliente", Utilizador.CodigoUtilizadorLogado);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarCliente(Cliente cliente)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Cliente SET NomeCliente = @NomeCliente, GeneroCliente = @GeneroCliente,codigoModalidadeCliente = @codigoModalidadeCliente,NumeroBilheteIdentidadeCliente = @NumeroBilheteIdentidadeCliente,EnderecoCliente = @EnderecoCliente,TelemovelCliente = @TelemovelCliente,EmailCliente = @EmailCliente, CodigoUtilizadorCliente = @CodigoUtilizadorCliente WHERE CodigoCliente = @CodigoCliente";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente);
                        cmd.Parameters.AddWithValue("@GeneroCliente", cliente.GeneroCliente);
                        cmd.Parameters.AddWithValue("@codigoModalidadeCliente", cliente.Modalidade.CodigoModalidade);
                        cmd.Parameters.AddWithValue("@NumeroBilheteIdentidadeCliente", cliente.NumeroBilheteIdentidadeCliente);
                        cmd.Parameters.AddWithValue("@EnderecoCliente", cliente.EnderecoCliente);
                        cmd.Parameters.AddWithValue("@TelemovelCliente", cliente.TelemovelCliente);
                        cmd.Parameters.AddWithValue("@EmailCliente", cliente.EmailCliente);
                        cmd.Parameters.AddWithValue("@CodigoUtilizadorCliente", Utilizador.CodigoUtilizadorLogado);
                        cmd.Parameters.AddWithValue("@CodigoCliente", cliente.CodigoCliente);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirCliente(int CodigoCliente)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Cliente SET EstadoCliente = 0 WHERE CodigoCliente = @CodigoCliente";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Cliente ObterClientePorCodigo(int CodigoCliente)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoCliente,NomeCliente,GeneroCliente,Modalidade.NomeModalidade,NumeroBilheteIdentidadeCliente,EnderecoCliente,TelemovelCliente,EmailCliente,Utilizador.NomeUtilizador FROM Cliente inner join Modalidade on Cliente.CodigoModalidadeCliente = Modalidade.CodigoModalidade inner join Utilizador on Cliente.codigoUtilizadorCliente = utilizador.codigoUtilizador WHERE CodigoCliente = @CodigoCliente AND EstadoCliente = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Cliente cliente = new Cliente();

                            if (reader.Read())
                            {
                                cliente.CodigoCliente = reader.GetInt32("CodigoCliente");
                                cliente.NomeCliente = reader.GetString("nomeCliente");
                                cliente.GeneroCliente = reader.GetString("GeneroCliente");
                                cliente.Modalidade.NomeModalidade = reader.GetString("NomeModalidade");
                                cliente.NumeroBilheteIdentidadeCliente = reader.GetString("NumeroBilheteIdentidadeCliente");
                                cliente.EnderecoCliente = reader.GetString("EnderecoCliente");
                                cliente.TelemovelCliente = reader.GetString("TelemovelCliente");
                                cliente.EmailCliente = reader.GetString("EmailCliente");                                                          
                                cliente.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador"); 
                            }

                            return cliente;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Cliente> BuscarCliente(string PesquizarCliente)
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoCliente,NomeCliente,GeneroCliente,Modalidade.NomeModalidade,NumeroBilheteIdentidadeCliente,EnderecoCliente,TelemovelCliente,EmailCliente,Utilizador.NomeUtilizador FROM Cliente inner join Modalidade on Cliente.CodigoModalidadeCliente = Modalidade.CodigoModalidade inner join Utilizador on Cliente.codigoUtilizadorCliente = utilizador.codigoUtilizador WHERE nomeCliente LIKE CONCAT('%', :PesquizarCliente, '%') OR telemovelCliente LIKE CONCAT('%', :PesquizarCliente, '%') OR codigoCliente = :PesquizarCliente AND EstadoCliente = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@PesquizarCliente", PesquizarCliente);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente();
                                cliente.CodigoCliente = reader.GetInt32("CodigoCliente");
                                cliente.NomeCliente = reader.GetString("nomeCliente");
                                cliente.GeneroCliente = reader.GetString("GeneroCliente");
                                cliente.Modalidade.NomeModalidade = reader.GetString("NomeModalidade");
                                cliente.NumeroBilheteIdentidadeCliente = reader.GetString("NumeroBilheteIdentidadeCliente");
                                cliente.EnderecoCliente = reader.GetString("EnderecoCliente");
                                cliente.TelemovelCliente = reader.GetString("TelemovelCliente");
                                cliente.EmailCliente = reader.GetString("EmailCliente");
                                cliente.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                listaClientes.Add(cliente);
                            }
                        }
                    }
                }
                return listaClientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Cliente> ObterTodosCliente()
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoCliente,NomeCliente,GeneroCliente,Modalidade.NomeModalidade,NumeroBilheteIdentidadeCliente,EnderecoCliente,TelemovelCliente,EmailCliente,Utilizador.NomeUtilizador FROM Cliente inner join Modalidade on Cliente.CodigoModalidadeCliente = Modalidade.CodigoModalidade inner join Utilizador on Cliente.codigoUtilizadorCliente = utilizador.codigoUtilizador WHERE EstadoCliente = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente();
                                cliente.CodigoCliente = reader.GetInt32("CodigoCliente");
                                cliente.NomeCliente = reader.GetString("nomeCliente");
                                cliente.GeneroCliente = reader.GetString("GeneroCliente");
                                cliente.Modalidade.NomeModalidade = reader.GetString("NomeModalidade");
                                cliente.NumeroBilheteIdentidadeCliente = reader.GetString("NumeroBilheteIdentidadeCliente");
                                cliente.EnderecoCliente = reader.GetString("EnderecoCliente");
                                cliente.TelemovelCliente = reader.GetString("TelemovelCliente");
                                cliente.EmailCliente = reader.GetString("EmailCliente");
                                cliente.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                listaClientes.Add(cliente);
                            }
                        }
                    }
                }
                return listaClientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
