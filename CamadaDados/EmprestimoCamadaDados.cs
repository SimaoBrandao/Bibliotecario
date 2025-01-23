using System;
using System.Collections.Generic;
using CamadaEntidade;
using MySql.Data.MySqlClient;

namespace CamadaDados
{
    public class EmprestimoCamadaDados : IEmprestimoCamadaDados
    {
        private readonly string connectionString = DatabaseConnection.ConnectionString();
        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "INSERT INTO Emprestimo (codigoClienteEmprestimo,codigoAcervoEmprestimo,dataEmprestimo,dataPrevistaDevolucaoEmprestimo,codigoUtilizadorEmprestimo) VALUES (@codigoClienteEmprestimo,@codigoAcervoEmprestimo,@dataEmprestimo,@dataPrevistaDevolucaoEmprestimo,@codigoUtilizadorEmprestimo)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@codigoClienteEmprestimo", emprestimo.Cliente.CodigoCliente);
                        cmd.Parameters.AddWithValue("@codigoAcervoEmprestimo", emprestimo.Acervo.CodigoAcervo);                      
                        cmd.Parameters.AddWithValue("@dataEmprestimo", emprestimo.DataEmprestimo);
                        cmd.Parameters.AddWithValue("@dataPrevistaDevolucaoEmprestimo", emprestimo.DataPrevistaDevolucaoEmprestimo);                       
                        cmd.Parameters.AddWithValue("@codigoUtilizadorEmprestimo", Utilizador.CodigoUtilizadorLogado);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Emprestimo SET codigoClienteEmprestimo = @codigoClienteEmprestimo,codigoAcervoEmprestimo = @codigoAcervoEmprestimo,dataEmprestimo = @dataEmprestimo,dataPrevistaDevolucaoEmprestimo = @dataPrevistaDevolucaoEmprestimo,codigoUtilizadorEmprestimo = @codigoUtilizadorEmprestimo WHERE CodigoEmprestimo = @CodigoEmprestimo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@codigoClienteEmprestimo", emprestimo.Cliente.CodigoCliente);
                        cmd.Parameters.AddWithValue("@codigoAcervoEmprestimo", emprestimo.Acervo.CodigoAcervo);
                        cmd.Parameters.AddWithValue("@dataEmprestimo", emprestimo.DataEmprestimo);
                        cmd.Parameters.AddWithValue("@dataPrevistaDevolucaoEmprestimo", emprestimo.DataPrevistaDevolucaoEmprestimo);
                        cmd.Parameters.AddWithValue("@codigoUtilizadorEmprestimo", Utilizador.CodigoUtilizadorLogado);
                        cmd.Parameters.AddWithValue("@codigoEmprestimo", emprestimo.CodigoEmprestimo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirEmprestimo(int CodigoEmprestimo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Emprestimo SET EstadoEmprestimo = 'Inativo' WHERE CodigoEmprestimo = @CodigoEmprestimo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoEmprestimo", CodigoEmprestimo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DevolucaoEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Emprestimo SET DataRealDevolucaoEmprestimo = @DataRealDevolucaoEmprestimo,estadoEmprestimo = 'Devolvido',codigoUtilizadorEmprestimo = @codigoUtilizadorEmprestimo WHERE CodigoEmprestimo = @CodigoEmprestimo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@DataRealDevolucaoEmprestimo", emprestimo.DataRealDevolucaoEmprestimo);
                        cmd.Parameters.AddWithValue("@codigoUtilizadorEmprestimo", Utilizador.CodigoUtilizadorLogado);
                        cmd.Parameters.AddWithValue("@codigoEmprestimo", emprestimo.CodigoEmprestimo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AnularDevolucaoEmprestimo(int CodigoEmprestimo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Emprestimo SET DataRealDevolucaoEmprestimo = NULL, estadoEmprestimo = 'Emprestado',codigoUtilizadorEmprestimo = @codigoUtilizadorEmprestimo WHERE CodigoEmprestimo = @CodigoEmprestimo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {                       
                        cmd.Parameters.AddWithValue("@codigoUtilizadorEmprestimo", Utilizador.CodigoUtilizadorLogado);
                        cmd.Parameters.AddWithValue("@codigoEmprestimo", CodigoEmprestimo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Emprestimo ObterEmprestimoPorCodigo(int CodigoEmprestimo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoEmprestimo,Cliente.NomeCliente,Acervo.TituloAcervo,dataEmprestimo,DATE(dataPrevistaDevolucaoEmprestimo) As dataPrevistaDevolucaoEmprestimo,dataRealDevolucaoEmprestimo,Utilizador.NomeUtilizador, EstadoEmprestimo FROM Emprestimo inner join Cliente on Emprestimo.codigoClienteEmprestimo = Cliente.codigoCliente inner join Acervo on Emprestimo.codigoAcervoEmprestimo = Acervo.codigoAcervo inner join Utilizador on Emprestimo.codigoUtilizadorEmprestimo = utilizador.codigoUtilizador WHERE Emprestimo.CodigoEmprestimo = @codigoEmprestimo AND EstadoEmprestimo != 'Inativo'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoEmprestimo", CodigoEmprestimo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Emprestimo emprestimo = new Emprestimo();

                            if (reader.Read())
                            {
                                emprestimo.CodigoEmprestimo = reader.GetInt32("CodigoEmprestimo");
                                emprestimo.Cliente.NomeCliente = reader.GetString("NomeCliente");
                                emprestimo.Acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                emprestimo.DataEmprestimo = reader.GetDateTime("DataEmprestimo");
                                emprestimo.DataPrevistaDevolucaoEmprestimo = reader.GetDateTime("DataPrevistaDevolucaoEmprestimo");
                                // Verificar se o valor de DataRealDevolucaoEmprestimo é NULL
                                emprestimo.DataRealDevolucaoEmprestimo = reader.IsDBNull(reader.GetOrdinal("DataRealDevolucaoEmprestimo")) ? (DateTime?)null : reader.GetDateTime("DataRealDevolucaoEmprestimo");
                                emprestimo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                emprestimo.EstadoEmprestimo = reader.GetString("EstadoEmprestimo");
                            }

                            return emprestimo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Emprestimo> ObterTodosEmprestimo()
        {
            try
            {
                List<Emprestimo> listaEmprestimo = new List<Emprestimo>();

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoEmprestimo,Cliente.NomeCliente,Acervo.TituloAcervo,dataEmprestimo,DATE(dataPrevistaDevolucaoEmprestimo) as dataPrevistaDevolucaoEmprestimo, emprestimo.dataRealDevolucaoEmprestimo,Utilizador.NomeUtilizador, EstadoEmprestimo FROM Emprestimo inner join Cliente on Emprestimo.codigoClienteEmprestimo = Cliente.codigoCliente inner join Acervo on Emprestimo.codigoAcervoEmprestimo = Acervo.codigoAcervo inner join Utilizador on Emprestimo.codigoUtilizadorEmprestimo = utilizador.codigoUtilizador WHERE EstadoEmprestimo != 'Inativo'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo();
                                emprestimo.CodigoEmprestimo = reader.GetInt32("CodigoEmprestimo");
                                emprestimo.Cliente.NomeCliente = reader.GetString("NomeCliente");
                                emprestimo.Acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                emprestimo.DataEmprestimo = reader.GetDateTime("DataEmprestimo");
                                emprestimo.DataPrevistaDevolucaoEmprestimo = reader.GetDateTime("DataPrevistaDevolucaoEmprestimo");
                                // Verificar se o valor de DataRealDevolucaoEmprestimo é NULL
                                emprestimo.DataRealDevolucaoEmprestimo = reader.IsDBNull(reader.GetOrdinal("DataRealDevolucaoEmprestimo")) ? (DateTime?)null : reader.GetDateTime("DataRealDevolucaoEmprestimo");
                                emprestimo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                emprestimo.EstadoEmprestimo = reader.GetString("EstadoEmprestimo");
                                listaEmprestimo.Add(emprestimo);
                            }
                        }
                    }
                }
                return listaEmprestimo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Emprestimo> ObterEmprestimoPorNomeCliente(string NomeCliente)
        {
            try
            {
                List<Emprestimo> listaEmprestimo = new List<Emprestimo>();

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoEmprestimo,Cliente.NomeCliente,Acervo.TituloAcervo,dataEmprestimo,DATE(dataPrevistaDevolucaoEmprestimo) as dataPrevistaDevolucaoEmprestimo,dataRealDevolucaoEmprestimo,Utilizador.NomeUtilizador,EstadoEmprestimo FROM Emprestimo inner join Cliente on Emprestimo.codigoClienteEmprestimo = Cliente.codigoCliente inner join Acervo on Emprestimo.codigoAcervoEmprestimo = Acervo.codigoAcervo inner join Utilizador on Emprestimo.codigoUtilizadorEmprestimo = utilizador.codigoUtilizador WHERE Cliente.NomeCliente LIKE CONCAT('%',@NomeCliente,'%') AND EstadoEmprestimo != 'Inativo'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeCliente", NomeCliente);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo();
                                emprestimo.CodigoEmprestimo = reader.GetInt32("CodigoEmprestimo");
                                emprestimo.Cliente.NomeCliente = reader.GetString("NomeCliente");
                                emprestimo.Acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                emprestimo.DataEmprestimo = reader.GetDateTime("DataEmprestimo");
                                emprestimo.DataPrevistaDevolucaoEmprestimo = reader.GetDateTime("DataPrevistaDevolucaoEmprestimo");
                                // Verificar se o valor de DataRealDevolucaoEmprestimo é NULL
                                emprestimo.DataRealDevolucaoEmprestimo = reader.IsDBNull(reader.GetOrdinal("DataRealDevolucaoEmprestimo")) ? (DateTime?)null : reader.GetDateTime("DataRealDevolucaoEmprestimo");
                                emprestimo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                emprestimo.EstadoEmprestimo = reader.GetString("EstadoEmprestimo");
                                listaEmprestimo.Add(emprestimo);
                            }
                        }
                    }
                }
                return listaEmprestimo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Emprestimo> ObterEmprestimoPorCDDAcervo(int CDDAcervo)
        {
            try
            {
                List<Emprestimo> listaEmprestimo = new List<Emprestimo>();

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoEmprestimo,Cliente.NomeCliente,Acervo.TituloAcervo,dataEmprestimo,DATE(dataPrevistaDevolucaoEmprestimo) as dataPrevistaDevolucaoEmprestimo,dataRealDevolucaoEmprestimo,Utilizador.NomeUtilizador,EstadoEmprestimo FROM Emprestimo inner join Cliente on Emprestimo.codigoClienteEmprestimo = Cliente.codigoCliente inner join Acervo on Emprestimo.codigoAcervoEmprestimo = Acervo.codigoAcervo inner join Utilizador on Emprestimo.codigoUtilizadorEmprestimo = utilizador.codigoUtilizador WHERE Acervo.CDDAcervo = @CDDAcervo AND EstadoEmprestimo != 'Inativo'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CDDAcervo", CDDAcervo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo();
                                emprestimo.CodigoEmprestimo = reader.GetInt32("CodigoEmprestimo");
                                emprestimo.Cliente.NomeCliente = reader.GetString("NomeCliente");
                                emprestimo.Acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                emprestimo.DataEmprestimo = reader.GetDateTime("DataEmprestimo");
                                emprestimo.DataPrevistaDevolucaoEmprestimo = reader.GetDateTime("DataPrevistaDevolucaoEmprestimo");
                                // Verificar se o valor de DataRealDevolucaoEmprestimo é NULL
                                emprestimo.DataRealDevolucaoEmprestimo = reader.IsDBNull(reader.GetOrdinal("DataRealDevolucaoEmprestimo")) ? (DateTime?)null : reader.GetDateTime("DataRealDevolucaoEmprestimo");
                                emprestimo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                emprestimo.EstadoEmprestimo = reader.GetString("EstadoEmprestimo");
                                listaEmprestimo.Add(emprestimo);
                            }
                        }
                    }
                }
                return listaEmprestimo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Emprestimo> ObterEmprestimoPorTituloAcervo(string TituloAcervo)
        {
            try
            {
                List<Emprestimo> listaEmprestimo = new List<Emprestimo>();

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoEmprestimo,Cliente.NomeCliente,Acervo.TituloAcervo,dataEmprestimo,DATE(dataPrevistaDevolucaoEmprestimo) as dataPrevistaDevolucaoEmprestimo,dataRealDevolucaoEmprestimo,Utilizador.NomeUtilizador,EstadoEmprestimo FROM Emprestimo inner join Cliente on Emprestimo.codigoClienteEmprestimo = Cliente.codigoCliente inner join Acervo on Emprestimo.codigoAcervoEmprestimo = Acervo.codigoAcervo inner join Utilizador on Emprestimo.codigoUtilizadorEmprestimo = utilizador.codigoUtilizador WHERE Acervo.TituloAcervo LIKE CONCAT('%',@TituloAcervo,'%') AND EstadoEmprestimo != 'Inativo'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@TituloAcervo", TituloAcervo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo();
                                emprestimo.CodigoEmprestimo = reader.GetInt32("CodigoEmprestimo");
                                emprestimo.Cliente.NomeCliente = reader.GetString("NomeCliente");
                                emprestimo.Acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                emprestimo.DataEmprestimo = reader.GetDateTime("DataEmprestimo");
                                emprestimo.DataPrevistaDevolucaoEmprestimo = reader.GetDateTime("DataPrevistaDevolucaoEmprestimo");
                                // Verificar se o valor de DataRealDevolucaoEmprestimo é NULL
                                emprestimo.DataRealDevolucaoEmprestimo = reader.IsDBNull(reader.GetOrdinal("DataRealDevolucaoEmprestimo")) ? (DateTime?)null : reader.GetDateTime("DataRealDevolucaoEmprestimo");
                                emprestimo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                emprestimo.EstadoEmprestimo = reader.GetString("EstadoEmprestimo");
                                listaEmprestimo.Add(emprestimo);
                            }
                        }
                    }
                }
                return listaEmprestimo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Emprestimo> ObterEmprestimoPorDataEmprestimo(DateTime DataEmprestimo)
        {
            try
            {
                List<Emprestimo> listaEmprestimo = new List<Emprestimo>();

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoEmprestimo,Cliente.NomeCliente,Acervo.TituloAcervo,dataEmprestimo,DATE(dataPrevistaDevolucaoEmprestimo) as dataPrevistaDevolucaoEmprestimo,dataRealDevolucaoEmprestimo,Utilizador.NomeUtilizador,EstadoEmprestimo FROM Emprestimo inner join Cliente on Emprestimo.codigoClienteEmprestimo = Cliente.codigoCliente inner join Acervo on Emprestimo.codigoAcervoEmprestimo = Acervo.codigoAcervo inner join Utilizador on Emprestimo.codigoUtilizadorEmprestimo = utilizador.codigoUtilizador WHERE DATE(DataEmprestimo) = @DataEmprestimo AND EstadoEmprestimo != 'Inativo'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@DataEmprestimo", DataEmprestimo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo();
                                emprestimo.CodigoEmprestimo = reader.GetInt32("CodigoEmprestimo");
                                emprestimo.Cliente.NomeCliente = reader.GetString("NomeCliente");
                                emprestimo.Acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                emprestimo.DataEmprestimo = reader.GetDateTime("DataEmprestimo");
                                emprestimo.DataPrevistaDevolucaoEmprestimo = reader.GetDateTime("DataPrevistaDevolucaoEmprestimo");
                                // Verificar se o valor de DataRealDevolucaoEmprestimo é NULL
                                emprestimo.DataRealDevolucaoEmprestimo = reader.IsDBNull(reader.GetOrdinal("DataRealDevolucaoEmprestimo")) ? (DateTime?)null : reader.GetDateTime("DataRealDevolucaoEmprestimo");
                                emprestimo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                emprestimo.EstadoEmprestimo = reader.GetString("EstadoEmprestimo");
                                listaEmprestimo.Add(emprestimo);
                            }
                        }
                    }
                }
                return listaEmprestimo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        

        //O Método verifica se o acervo selecionado já foi emprestado.
        public bool VerificarAcervoEmprestado(int CodigoAcervo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT COUNT(*) FROM Emprestimo WHERE CodigoAcervoEmprestimo = @CodigoAcervo AND DataRealDevolucaoEmprestimo IS NULL AND EstadoEmprestimo != 'Inativo' ";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoAcervo", CodigoAcervo);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        // Se count > 0, o acervo já está emprestado
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public bool VerificarSeEmprestimoFoiDevolvido(int CodigoEmprestimo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT COUNT(*) FROM Emprestimo WHERE CodigoEmprestimo = @CodigoEmprestimo AND DataRealDevolucaoEmprestimo IS NOT NULL AND EstadoEmprestimo != 'Inativo' ";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoEmprestimo", CodigoEmprestimo);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        // Se count > 0, o acervo já foi devolvido
                        return count > 0;
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
