using System;
using System.Collections.Generic;
using CamadaEntidade;
using MySql.Data.MySqlClient;

namespace CamadaDados
{
    public class CategoriaCamadaDados : ICategoriaCamadaDados
    {
        private readonly string connectionString = DatabaseConnection.ConnectionString();
        public void AdicionarCategoria(Categoria categoria)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "INSERT INTO Categoria (NomeCategoria,CDDCategoria,CodigoUtilizadorCategoria) VALUES (@NomeCategoria,@CDDCategoria,@CodigoUtilizadorCategoria)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeCategoria", categoria.NomeCategoria);
                        cmd.Parameters.AddWithValue("@CDDCategoria", categoria.CDDCategoria);
                        cmd.Parameters.AddWithValue("@CodigoUtilizadorCategoria", Utilizador.CodigoUtilizadorLogado);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Categoria SET NomeCategoria = @NomeCategoria,CDDCategoria = @CDDCategoria,CodigoUtilizadorCategoria = @CodigoUtilizadorCategoria WHERE CodigoCategoria = @CodigoCategoria";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeCategoria", categoria.NomeCategoria);
                        cmd.Parameters.AddWithValue("@CDDCategoria", categoria.CDDCategoria);
                        cmd.Parameters.AddWithValue("@CodigoUtilizadorCategoria", Utilizador.CodigoUtilizadorLogado);
                        cmd.Parameters.AddWithValue("@CodigoCategoria", categoria.CodigoCategoria);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirCategoria(int CodigoCategoria)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Categoria SET EstadoCategoria = 0 WHERE CodigoCategoria = @CodigoCategoria";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoCategoria", CodigoCategoria);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Categoria ObterCategoriaPorCodigo(int CodigoCategoria)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoCategoria,NomeCategoria,CDDCategoria,Utilizador.NomeUtilizador FROM Categoria inner join Utilizador on Categoria.codigoUtilizadorCategoria = utilizador.codigoUtilizador WHERE Categoria.CodigoCategoria = @codigoCategoria AND EstadoCategoria = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoCategoria", CodigoCategoria);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Categoria categoria = new Categoria();

                            if (reader.Read())
                            {
                                categoria.CodigoCategoria = reader.GetInt32("CodigoCategoria");
                                categoria.NomeCategoria = reader.GetString("NomeCategoria");
                                categoria.CDDCategoria = reader.GetString("CDDCategoria");
                                categoria.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                            }

                            return categoria;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Categoria> ObterTodasCategorias()
        {
            try
            {
                List<Categoria> listaCategoria = new List<Categoria>();

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoCategoria,NomeCategoria,CDDCategoria,Utilizador.NomeUtilizador FROM Categoria inner join Utilizador on Categoria.codigoUtilizadorCategoria = utilizador.codigoUtilizador WHERE EstadoCategoria = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Categoria categoria = new Categoria();
                                categoria.CodigoCategoria = reader.GetInt32("CodigoCategoria");
                                categoria.NomeCategoria = reader.GetString("NomeCategoria");
                                categoria.CDDCategoria = reader.GetString("CDDCategoria");
                                categoria.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                listaCategoria.Add(categoria);
                            }
                        }
                    }
                }
                return listaCategoria;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Categoria> ObterCategoriaPorNome(string NomeCategoria)
        {
            try
            {
                List<Categoria> listaCategoria = new List<Categoria>();

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoCategoria,NomeCategoria,CDDCategoria,Utilizador.NomeUtilizador FROM Categoria inner join Utilizador on Categoria.codigoUtilizadorCategoria = utilizador.codigoUtilizador WHERE NomeCategoria LIKE CONCAT('%',@NomeCategoria,'%') AND EstadoCategoria = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeCategoria", NomeCategoria);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Categoria categoria = new Categoria();
                                categoria.CodigoCategoria = reader.GetInt32("CodigoCategoria");
                                categoria.NomeCategoria = reader.GetString("NomeCategoria");
                                categoria.CDDCategoria = reader.GetString("CDDCategoria");
                                categoria.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                listaCategoria.Add(categoria);
                            }
                        }
                    }
                }
                return listaCategoria;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
