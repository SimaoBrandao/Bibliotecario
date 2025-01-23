using System;
using System.Collections.Generic;
using CamadaEntidade;
using MySql.Data.MySqlClient;

namespace CamadaDados
{
    public class ModalidadeCamadaDados : IModalidadeCamadaDados
    {
        private readonly string connectionString = DatabaseConnection.ConnectionString();
        public void AdicionarModalidade(Modalidade modalidade)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "INSERT INTO Modalidade (NomeModalidade) VALUES (@NomeModalidade)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeModalidade", modalidade.NomeModalidade);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarModalidade(Modalidade modalidade)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Modalidade SET NomeModalidade = @NomeModalidade WHERE CodigoModalidade = @CodigoModalidade";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeModalidade", modalidade.NomeModalidade);
                        cmd.Parameters.AddWithValue("@CodigoModalidade", modalidade.CodigoModalidade);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirModalidade(int CodigoModalidade)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Modalidade SET EstadoModalidade = 0 WHERE CodigoModalidade = @CodigoModalidade";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoModalidade", CodigoModalidade);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Modalidade ObterModalidadePorCodigo(int CodigoModalidade)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoModalidade,NomeModalidade FROM Modalidade WHERE CodigoModalidade = @codigoModalidade AND EstadoModalidade = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoModalidade", CodigoModalidade);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Modalidade modalidade = new Modalidade();

                            if (reader.Read())
                            {
                                modalidade.CodigoModalidade = reader.GetInt32("CodigoModalidade");
                                modalidade.NomeModalidade = reader.GetString("NomeModalidade");
                            }

                            return modalidade;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Modalidade> ObterTodasModalidade()
        {
            try
            {
                List<Modalidade> listaModalidade = new List<Modalidade>();

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoModalidade,NomeModalidade FROM Modalidade WHERE EstadoModalidade = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Modalidade modalidade = new Modalidade();
                                modalidade.CodigoModalidade = reader.GetInt32("CodigoModalidade");
                                modalidade.NomeModalidade = reader.GetString("NomeModalidade");
                                listaModalidade.Add(modalidade);
                            }
                        }
                    }
                }
                return listaModalidade;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
