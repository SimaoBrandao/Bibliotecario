using System;
using System.Collections.Generic;
using CamadaEntidade;
using MySql.Data.MySqlClient;

namespace CamadaDados
{
    public class FormatoCamadaDados : IFormatoCamadaDados
    {
        private readonly string connectionString = DatabaseConnection.ConnectionString();
        public void AdicionarFormato(Formato formato)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "INSERT INTO Formato (NomeFormato,CodigoUtilizadorFormato) VALUES (@NomeFormato,@CodigoUtilizadorFormato)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeFormato", formato.NomeFormato);
                        cmd.Parameters.AddWithValue("@CodigoUtilizadorFormato", Utilizador.CodigoUtilizadorLogado);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarFormato(Formato formato)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Formato SET NomeFormato = @NomeFormato,CodigoUtilizadorFormato = @CodigoUtilizadorFormato WHERE CodigoFormato = @CodigoFormato";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeFormato", formato.NomeFormato);
                        cmd.Parameters.AddWithValue("@CodigoUtilizadorFormato", Utilizador.CodigoUtilizadorLogado);
                        cmd.Parameters.AddWithValue("@CodigoFormato", formato.CodigoFormato);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirFormato(int CodigoFormato)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Formato SET EstadoFormato = 0 WHERE CodigoFormato = @CodigoFormato";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoFormato", CodigoFormato);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Formato ObterFormatoPorCodigo(int CodigoFormato)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoFormato,NomeFormato,Utilizador.NomeUtilizador FROM Formato inner join Utilizador on Formato.codigoUtilizadorFormato = utilizador.codigoUtilizador WHERE Formato.CodigoFormato = @codigoFormato AND EstadoFormato = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoFormato", CodigoFormato);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Formato formato = new Formato();

                            if (reader.Read())
                            {
                                formato.CodigoFormato = reader.GetInt32("CodigoFormato");
                                formato.NomeFormato = reader.GetString("NomeFormato");
                                formato.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                            }

                            return formato;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Formato> ObterTodosFormatos()
        {
            try
            {
                List<Formato> listaFormato = new List<Formato>();

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoFormato,NomeFormato,Utilizador.NomeUtilizador FROM Formato inner join Utilizador on Formato.codigoUtilizadorFormato = utilizador.codigoUtilizador WHERE EstadoFormato = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Formato formato = new Formato();
                                formato.CodigoFormato = reader.GetInt32("CodigoFormato");
                                formato.NomeFormato = reader.GetString("NomeFormato");
                                formato.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                listaFormato.Add(formato);
                            }
                        }
                    }
                }
                return listaFormato;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Formato> ObterFormatoPorNome(string NomeFormato)
        {
            try
            {
                List<Formato> listaFormato = new List<Formato>();

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoFormato,NomeFormato,Utilizador.NomeUtilizador FROM Formato inner join Utilizador on Formato.codigoUtilizadorFormato = utilizador.codigoUtilizador WHERE NomeFormato LIKE CONCAT('%',@NomeFormato,'%') AND EstadoFormato = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeFormato", NomeFormato);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Formato formato = new Formato();
                                formato.CodigoFormato = reader.GetInt32("CodigoFormato");
                                formato.NomeFormato = reader.GetString("NomeFormato");
                                formato.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                listaFormato.Add(formato);
                            }
                        }
                    }
                }
                return listaFormato;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
