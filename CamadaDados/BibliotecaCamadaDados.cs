using System;
using CamadaEntidade;
using MySql.Data.MySqlClient;

namespace CamadaDados
{
    public class BibliotecaCamadaDados : IBibliotecaCamadaDados
    {
        private readonly string connectionString = DatabaseConnection.ConnectionString();
        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "INSERT INTO Biblioteca (NomeBiblioteca,nifBiblioteca,enderecoBiblioteca,telemovelBiblioteca,emailBiblioteca) VALUES (@NomeBiblioteca,@nifBiblioteca,@enderecoBiblioteca,@telemovelBiblioteca,@emailBiblioteca)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nomeBiblioteca", biblioteca.NomeBiblioteca);
                        cmd.Parameters.AddWithValue("@nifBiblioteca", biblioteca.NifBiblioteca);
                        cmd.Parameters.AddWithValue("@enderecoBiblioteca", biblioteca.EnderecoBiblioteca);
                        cmd.Parameters.AddWithValue("@telemovelBiblioteca", biblioteca.TelemovelBiblioteca);
                        cmd.Parameters.AddWithValue("@emailBiblioteca", biblioteca.EmailBiblioteca);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }       

        public void AtualizarBiblioteca(Biblioteca biblioteca)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Biblioteca SET NomeBiblioteca = @NomeBiblioteca,nifBiblioteca = @nifBiblioteca,enderecoBiblioteca = @enderecoBiblioteca,telemovelBiblioteca = @telemovelBiblioteca,emailBiblioteca = @emailBiblioteca WHERE CodigoBiblioteca = @CodigoBiblioteca";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nomeBiblioteca", biblioteca.NomeBiblioteca);
                        cmd.Parameters.AddWithValue("@nifBiblioteca", biblioteca.NifBiblioteca);
                        cmd.Parameters.AddWithValue("@enderecoBiblioteca", biblioteca.EnderecoBiblioteca);
                        cmd.Parameters.AddWithValue("@telemovelBiblioteca", biblioteca.TelemovelBiblioteca);
                        cmd.Parameters.AddWithValue("@emailBiblioteca", biblioteca.EmailBiblioteca);
                        cmd.Parameters.AddWithValue("@codigoBiblioteca", biblioteca.CodigoBiblioteca);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public Biblioteca ObterBiblioteca()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoBiblioteca,NomeBiblioteca,nifBiblioteca,enderecoBiblioteca,telemovelBiblioteca,emailBiblioteca FROM Biblioteca WHERE CodigoBiblioteca = @CodigoBiblioteca AND EstadoBiblioteca = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoBiblioteca", 1);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Biblioteca biblioteca = new Biblioteca();

                            if (reader.Read())
                            {
                                biblioteca.CodigoBiblioteca = reader.GetInt32("codigoBiblioteca");
                                biblioteca.NomeBiblioteca = reader.GetString("nomeBiblioteca");
                                biblioteca.NifBiblioteca = reader.GetString("nifBiblioteca");
                                biblioteca.EnderecoBiblioteca = reader.GetString("enderecoBiblioteca");
                                biblioteca.EmailBiblioteca = reader.GetString("emailBiblioteca");
                                biblioteca.TelemovelBiblioteca = reader.GetString("telemovelBiblioteca");
                            }

                            return biblioteca;
                        }
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
