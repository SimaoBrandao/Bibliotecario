using System;
using System.Collections.Generic;
using CamadaEntidade;
using MySql.Data.MySqlClient;

namespace CamadaDados
{
    public class AcervoCamadaDados : IAcervoCamadaDados
    {
        private readonly string connectionString = DatabaseConnection.ConnectionString();
        public void AdicionarAcervo(Acervo acervo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "INSERT INTO Acervo (CDDAcervo,tituloAcervo,autorAcervo,editoraAcervo,anoPublicacaoAcervo,codigoCategoriaAcervo,codigoFormatoAcervo,IdiomaAcervo,ISBNAcervo,quantidadeAcervo,codigoIdentificadorAcervo,LocalizacaoAcervo,codigoUtilizadorAcervo) VALUES (@CDDAcervo,@tituloAcervo,@autorAcervo,@editoraAcervo,@anoPublicacaoAcervo,@codigoCategoriaAcervo,@codigoFormatoAcervo,@IdiomaAcervo,@ISBNAcervo,@quantidadeAcervo,@codigoIdentificadorAcervo,@LocalizacaoAcervo,@codigoUtilizadorAcervo)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CDDAcervo", acervo.CDDAcervo);
                        cmd.Parameters.AddWithValue("@tituloAcervo", acervo.TituloAcervo);
                        cmd.Parameters.AddWithValue("@autorAcervo", acervo.AutorAcervo);
                        cmd.Parameters.AddWithValue("@editoraAcervo", acervo.EditoraAcervo);
                        cmd.Parameters.AddWithValue("@anoPublicacaoAcervo", acervo.AnoPublicacaoAcervo);
                        cmd.Parameters.AddWithValue("@codigoCategoriaAcervo", acervo.Categoria.CodigoCategoria);
                        cmd.Parameters.AddWithValue("@codigoFormatoAcervo", acervo.Formato.CodigoFormato);
                        cmd.Parameters.AddWithValue("@idiomaAcervo", acervo.IdiomaAcervo);
                        cmd.Parameters.AddWithValue("@ISBNAcervo", acervo.ISBNAcervo);
                        cmd.Parameters.AddWithValue("@quantidadeAcervo", acervo.QuantidadeAcervo);
                        cmd.Parameters.AddWithValue("@codigoIdentificadorAcervo", acervo.CodigoIdentificadorAcervo);
                        cmd.Parameters.AddWithValue("@localizacaoAcervo", acervo.LocalizacaoAcervo);
                        cmd.Parameters.AddWithValue("@codigoUtilizadorAcervo", Utilizador.CodigoUtilizadorLogado);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //atualiza todos os campos do acervo, excepto o campo CDDAcervo e codigoCategoriaAcervo.
        public void AtualizarAcervo(Acervo acervo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Acervo SET tituloAcervo = @tituloAcervo,autorAcervo = @autorAcervo,editoraAcervo = @editoraAcervo,anoPublicacaoAcervo = @anoPublicacaoAcervo,codigoFormatoAcervo = @codigoFormatoAcervo,IdiomaAcervo = @IdiomaAcervo,ISBNAcervo = @ISBNAcervo,quantidadeAcervo = @quantidadeAcervo,LocalizacaoAcervo = @LocalizacaoAcervo,codigoUtilizadorAcervo = @codigoUtilizadorAcervo WHERE CodigoIdentificadorAcervo = @CodigoIdentificadorAcervo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@tituloAcervo", acervo.TituloAcervo);
                        cmd.Parameters.AddWithValue("@autorAcervo", acervo.AutorAcervo);
                        cmd.Parameters.AddWithValue("@editoraAcervo", acervo.EditoraAcervo);
                        cmd.Parameters.AddWithValue("@anoPublicacaoAcervo", acervo.AnoPublicacaoAcervo);
                        cmd.Parameters.AddWithValue("@codigoFormatoAcervo", acervo.Formato.CodigoFormato);
                        cmd.Parameters.AddWithValue("@idiomaAcervo", acervo.IdiomaAcervo);
                        cmd.Parameters.AddWithValue("@ISBNAcervo", acervo.ISBNAcervo);
                        cmd.Parameters.AddWithValue("@quantidadeAcervo", acervo.QuantidadeAcervo);
                        cmd.Parameters.AddWithValue("@localizacaoAcervo", acervo.LocalizacaoAcervo);
                        cmd.Parameters.AddWithValue("@codigoUtilizadorAcervo", Utilizador.CodigoUtilizadorLogado);
                        cmd.Parameters.AddWithValue("@codigoIdentificadorAcervo", acervo.CodigoIdentificadorAcervo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirAcervo(int CodigoAcervo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();

                    using (var transacao = conexao.BeginTransaction())
                    {
                        try
                        {
                            var acervo = ObterAcervoPorCodigo(CodigoAcervo);
                            AtualizarQuantidadeAcervo(acervo.CodigoIdentificadorAcervo, conexao, transacao);
                            InativarAcervo(CodigoAcervo, conexao, transacao);
                            // Confirma a transação
                            transacao.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Desfaz a transação em caso de erro
                            transacao.Rollback();
                            throw new Exception(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }  

        private void AtualizarQuantidadeAcervo(string CodigoIdentificadorAcervo, MySqlConnection conexao, MySqlTransaction transacao)
        {
            try
            {
                string query = "UPDATE Acervo SET QuantidadeAcervo = QuantidadeAcervo - 1 WHERE CodigoIdentificadorAcervo = @CodigoIdentificadorAcervo";
                using (MySqlCommand cmd = new MySqlCommand(query, conexao, transacao))
                {
                    cmd.Parameters.AddWithValue("@CodigoIdentificadorAcervo", CodigoIdentificadorAcervo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void InativarAcervo(int CodigoAcervo, MySqlConnection conexao, MySqlTransaction transacao)
        {
            try
            {
                string query = "UPDATE Acervo SET EstadoAcervo = 0 WHERE CodigoAcervo = @CodigoAcervo";
                using (MySqlCommand cmd = new MySqlCommand(query, conexao, transacao))
                {
                    cmd.Parameters.AddWithValue("@CodigoAcervo", CodigoAcervo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        
        public Acervo ObterAcervoPorCodigo(int CodigoAcervo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoAcervo,CDDAcervo,tituloAcervo,Categoria.NomeCategoria,Formato.NomeFormato,IdiomaAcervo,AutorAcervo,EditoraAcervo,anoPublicacaoAcervo,ISBNAcervo,quantidadeAcervo,CodigoIdentificadorAcervo,LocalizacaoAcervo,Utilizador.NomeUtilizador,dataHoraAcervo,estadoAcervo, CASE WHEN emprestimo.codigoAcervoEmprestimo IS NOT NULL AND emprestimo.dataRealDevolucaoEmprestimo IS NULL THEN 'Emprestado'  ELSE 'Disponível' END AS estadoEmprestimo FROM Acervo inner join Categoria on Acervo.CodigoCategoriaAcervo = Categoria.CodigoCategoria inner join Formato on Acervo.CodigoFormatoAcervo = Formato.CodigoFormato inner join Utilizador on Acervo.CodigoUtilizadorAcervo = Utilizador.CodigoUtilizador LEFT JOIN Emprestimo ON Acervo.codigoAcervo = emprestimo.codigoAcervoEmprestimo WHERE Acervo.codigoAcervo = @CodigoAcervo AND EstadoAcervo = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoAcervo", CodigoAcervo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Acervo acervo = new Acervo();
                            if (reader.Read())
                            {
                                acervo.CodigoAcervo = reader.GetInt32("CodigoAcervo");
                                acervo.CDDAcervo = reader.GetString("CDDAcervo");
                                acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                acervo.Categoria.NomeCategoria = reader.GetString("NomeCategoria");
                                acervo.Formato.NomeFormato = reader.GetString("NomeFormato");
                                acervo.IdiomaAcervo = reader.GetString("IdiomaAcervo");
                                acervo.AutorAcervo = reader.GetString("AutorAcervo");
                                acervo.EditoraAcervo = reader.GetString("EditoraAcervo");
                                acervo.AnoPublicacaoAcervo = reader.GetInt32("AnoPublicacaoAcervo");
                                acervo.ISBNAcervo = reader.GetString("ISBNAcervo");
                                acervo.QuantidadeAcervo = reader.GetInt32("QuantidadeAcervo");
                                acervo.CodigoIdentificadorAcervo = reader.GetString("CodigoIdentificadorAcervo");
                                acervo.LocalizacaoAcervo = reader.GetString("LocalizacaoAcervo");
                                acervo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                acervo.DataHoraAcervo = reader.GetDateTime("DataHoraAcervo");
                                acervo.EstadoAcervo = reader.GetString("EstadoAcervo");
                            }
                            return acervo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Acervo> ObterTodosAcervos()
        {
            try
            {
                List<Acervo> listaAcervo = new List<Acervo>();
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoAcervo,CDDAcervo,tituloAcervo,Categoria.NomeCategoria,Formato.NomeFormato,IdiomaAcervo,AutorAcervo,EditoraAcervo,anoPublicacaoAcervo,ISBNAcervo,quantidadeAcervo,CodigoIdentificadorAcervo,LocalizacaoAcervo,Utilizador.NomeUtilizador,dataHoraAcervo,estadoAcervo , CASE WHEN emprestimo.codigoAcervoEmprestimo IS NOT NULL AND emprestimo.dataRealDevolucaoEmprestimo IS NULL THEN 'Emprestado'  ELSE 'Disponível' END AS estadoEmprestimo FROM Acervo inner join Categoria on Acervo.CodigoCategoriaAcervo = Categoria.CodigoCategoria inner join Formato on Acervo.CodigoFormatoAcervo = Formato.CodigoFormato inner join Utilizador on Acervo.CodigoUtilizadorAcervo = Utilizador.CodigoUtilizador LEFT JOIN Emprestimo ON Acervo.codigoAcervo = emprestimo.codigoAcervoEmprestimo WHERE EstadoAcervo = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Acervo acervo = new Acervo();
                                acervo.CodigoAcervo = reader.GetInt32("CodigoAcervo");
                                acervo.CDDAcervo = reader.GetString("CDDAcervo");
                                acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                acervo.Categoria.NomeCategoria = reader.GetString("NomeCategoria");
                                acervo.Formato.NomeFormato = reader.GetString("NomeFormato");
                                acervo.IdiomaAcervo = reader.GetString("IdiomaAcervo");
                                acervo.AutorAcervo = reader.GetString("AutorAcervo");
                                acervo.EditoraAcervo = reader.GetString("EditoraAcervo");
                                acervo.AnoPublicacaoAcervo = reader.GetInt32("AnoPublicacaoAcervo");
                                acervo.ISBNAcervo = reader.GetString("ISBNAcervo");
                                acervo.QuantidadeAcervo = reader.GetInt32("QuantidadeAcervo");
                                acervo.CodigoIdentificadorAcervo = reader.GetString("CodigoIdentificadorAcervo");
                                acervo.LocalizacaoAcervo = reader.GetString("LocalizacaoAcervo");
                                acervo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                acervo.DataHoraAcervo = reader.GetDateTime("DataHoraAcervo");
                                acervo.EstadoAcervo = reader.GetString("estadoEmprestimo");
                                listaAcervo.Add(acervo);
                            }
                        }
                    }
                }
                return listaAcervo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Acervo> ObterAcervoPorTitulo(string TituloAcervo)
        {
            try
            {
                List<Acervo> listaAcervo = new List<Acervo>();
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoAcervo,CDDAcervo,tituloAcervo,Categoria.NomeCategoria,Formato.NomeFormato,IdiomaAcervo,AutorAcervo,EditoraAcervo,anoPublicacaoAcervo,ISBNAcervo,quantidadeAcervo,CodigoIdentificadorAcervo,LocalizacaoAcervo,Utilizador.NomeUtilizador,dataHoraAcervo,estadoAcervo , CASE WHEN emprestimo.codigoAcervoEmprestimo IS NOT NULL AND emprestimo.dataRealDevolucaoEmprestimo IS NULL THEN 'Emprestado'  ELSE 'Disponível' END AS estadoEmprestimo FROM Acervo inner join Categoria on Acervo.CodigoCategoriaAcervo = Categoria.CodigoCategoria inner join Formato on Acervo.CodigoFormatoAcervo = Formato.CodigoFormato inner join Utilizador on Acervo.CodigoUtilizadorAcervo = Utilizador.CodigoUtilizador LEFT JOIN Emprestimo ON Acervo.codigoAcervo = emprestimo.codigoAcervoEmprestimo WHERE Acervo.TituloAcervo LIKE CONCAT('%',@TituloAcervo,'%') AND EstadoAcervo = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@TituloAcervo", TituloAcervo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Acervo acervo = new Acervo();
                                acervo.CodigoAcervo = reader.GetInt32("CodigoAcervo");
                                acervo.CDDAcervo = reader.GetString("CDDAcervo");
                                acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                acervo.Categoria.NomeCategoria = reader.GetString("NomeCategoria");
                                acervo.Formato.NomeFormato = reader.GetString("NomeFormato");
                                acervo.IdiomaAcervo = reader.GetString("IdiomaAcervo");
                                acervo.AutorAcervo = reader.GetString("AutorAcervo");
                                acervo.EditoraAcervo = reader.GetString("EditoraAcervo");
                                acervo.AnoPublicacaoAcervo = reader.GetInt32("AnoPublicacaoAcervo");
                                acervo.ISBNAcervo = reader.GetString("ISBNAcervo");
                                acervo.QuantidadeAcervo = reader.GetInt32("QuantidadeAcervo");
                                acervo.CodigoIdentificadorAcervo = reader.GetString("CodigoIdentificadorAcervo");
                                acervo.LocalizacaoAcervo = reader.GetString("LocalizacaoAcervo");
                                acervo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                acervo.DataHoraAcervo = reader.GetDateTime("DataHoraAcervo");
                                acervo.EstadoAcervo = reader.GetString("EstadoAcervo");
                                listaAcervo.Add(acervo);
                            }
                        }
                    }
                }
                return listaAcervo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        

        public List<Acervo> ObterAcervoPorCDD(string CDDAcervo)
        {
            try
            {
                List<Acervo> listaAcervo = new List<Acervo>();
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoAcervo,CDDAcervo,tituloAcervo,Categoria.NomeCategoria,Formato.NomeFormato,IdiomaAcervo,AutorAcervo,EditoraAcervo,anoPublicacaoAcervo,ISBNAcervo,quantidadeAcervo,CodigoIdentificadorAcervo,LocalizacaoAcervo,Utilizador.NomeUtilizador,dataHoraAcervo,estadoAcervo , CASE WHEN emprestimo.codigoAcervoEmprestimo IS NOT NULL AND emprestimo.dataRealDevolucaoEmprestimo IS NULL THEN 'Emprestado'  ELSE 'Disponível' END AS estadoEmprestimo FROM Acervo inner join Categoria on Acervo.CodigoCategoriaAcervo = Categoria.CodigoCategoria inner join Formato on Acervo.CodigoFormatoAcervo = Formato.CodigoFormato inner join Utilizador on Acervo.CodigoUtilizadorAcervo = Utilizador.CodigoUtilizador LEFT JOIN Emprestimo ON Acervo.codigoAcervo = emprestimo.codigoAcervoEmprestimo WHERE Acervo.CDDAcervo = @CDDAcervo AND EstadoAcervo = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CDDAcervo", CDDAcervo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Acervo acervo = new Acervo();
                                acervo.CodigoAcervo = reader.GetInt32("CodigoAcervo");
                                acervo.CDDAcervo = reader.GetString("CDDAcervo");
                                acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                acervo.Categoria.NomeCategoria = reader.GetString("NomeCategoria");
                                acervo.Formato.NomeFormato = reader.GetString("NomeFormato");
                                acervo.IdiomaAcervo = reader.GetString("IdiomaAcervo");
                                acervo.AutorAcervo = reader.GetString("AutorAcervo");
                                acervo.EditoraAcervo = reader.GetString("EditoraAcervo");
                                acervo.AnoPublicacaoAcervo = reader.GetInt32("AnoPublicacaoAcervo");
                                acervo.ISBNAcervo = reader.GetString("ISBNAcervo");
                                acervo.QuantidadeAcervo = reader.GetInt32("QuantidadeAcervo");
                                acervo.CodigoIdentificadorAcervo = reader.GetString("CodigoIdentificadorAcervo");
                                acervo.LocalizacaoAcervo = reader.GetString("LocalizacaoAcervo");
                                acervo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                acervo.DataHoraAcervo = reader.GetDateTime("DataHoraAcervo");
                                acervo.EstadoAcervo = reader.GetString("EstadoAcervo");
                                listaAcervo.Add(acervo);
                            }
                        }
                    }
                }
                return listaAcervo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Acervo> ObterAcervoPorNomeCategoria(string NomeCategoria)
        {
            try
            {
                List<Acervo> listaAcervo = new List<Acervo>();
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoAcervo,CDDAcervo,tituloAcervo,Categoria.NomeCategoria,Formato.NomeFormato,IdiomaAcervo,AutorAcervo,EditoraAcervo,anoPublicacaoAcervo,ISBNAcervo,quantidadeAcervo,CodigoIdentificadorAcervo,LocalizacaoAcervo,Utilizador.NomeUtilizador,dataHoraAcervo,estadoAcervo , CASE WHEN emprestimo.codigoAcervoEmprestimo IS NOT NULL AND emprestimo.dataRealDevolucaoEmprestimo IS NULL THEN 'Emprestado'  ELSE 'Disponível' END AS estadoEmprestimo FROM Acervo inner join Categoria on Acervo.CodigoCategoriaAcervo = Categoria.CodigoCategoria inner join Formato on Acervo.CodigoFormatoAcervo = Formato.CodigoFormato inner join Utilizador on Acervo.CodigoUtilizadorAcervo = Utilizador.CodigoUtilizador LEFT JOIN Emprestimo ON Acervo.codigoAcervo = emprestimo.codigoAcervoEmprestimo WHERE Categoria.NomeCategoria LIKE CONCAT('%',@NomeCategoria,'%') AND EstadoAcervo = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeCategoria", NomeCategoria);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Acervo acervo = new Acervo();
                                acervo.CodigoAcervo = reader.GetInt32("CodigoAcervo");
                                acervo.CDDAcervo = reader.GetString("CDDAcervo");
                                acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                acervo.Categoria.NomeCategoria = reader.GetString("NomeCategoria");
                                acervo.Formato.NomeFormato = reader.GetString("NomeFormato");
                                acervo.IdiomaAcervo = reader.GetString("IdiomaAcervo");
                                acervo.AutorAcervo = reader.GetString("AutorAcervo");
                                acervo.EditoraAcervo = reader.GetString("EditoraAcervo");
                                acervo.AnoPublicacaoAcervo = reader.GetInt32("AnoPublicacaoAcervo");
                                acervo.ISBNAcervo = reader.GetString("ISBNAcervo");
                                acervo.QuantidadeAcervo = reader.GetInt32("QuantidadeAcervo");
                                acervo.CodigoIdentificadorAcervo = reader.GetString("CodigoIdentificadorAcervo");
                                acervo.LocalizacaoAcervo = reader.GetString("LocalizacaoAcervo");
                                acervo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                acervo.DataHoraAcervo = reader.GetDateTime("DataHoraAcervo");
                                acervo.EstadoAcervo = reader.GetString("EstadoAcervo");
                                listaAcervo.Add(acervo);
                            }
                        }
                    }
                }
                return listaAcervo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Acervo> ObterAcervoPorLocalizacao(string LocalizacaoAcervo)
        {
            try
            {
                List<Acervo> listaAcervo = new List<Acervo>();
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CodigoAcervo,CDDAcervo,tituloAcervo,Categoria.NomeCategoria,Formato.NomeFormato,IdiomaAcervo,AutorAcervo,EditoraAcervo,anoPublicacaoAcervo,ISBNAcervo,quantidadeAcervo,CodigoIdentificadorAcervo,LocalizacaoAcervo,Utilizador.NomeUtilizador,dataHoraAcervo,estadoAcervo , CASE WHEN emprestimo.codigoAcervoEmprestimo IS NOT NULL AND emprestimo.dataRealDevolucaoEmprestimo IS NULL THEN 'Emprestado'  ELSE 'Disponível' END AS estadoEmprestimo FROM Acervo inner join Categoria on Acervo.CodigoCategoriaAcervo = Categoria.CodigoCategoria inner join Formato on Acervo.CodigoFormatoAcervo = Formato.CodigoFormato inner join Utilizador on Acervo.CodigoUtilizadorAcervo = Utilizador.CodigoUtilizador LEFT JOIN Emprestimo ON Acervo.codigoAcervo = emprestimo.codigoAcervoEmprestimo WHERE Acervo.LocalizacaoAcervo LIKE CONCAT('%',@LocalizacaoAcervo,'%') AND EstadoAcervo = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@LocalizacaoAcervo", LocalizacaoAcervo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Acervo acervo = new Acervo();
                                acervo.CodigoAcervo = reader.GetInt32("CodigoAcervo");
                                acervo.CDDAcervo = reader.GetString("CDDAcervo");
                                acervo.TituloAcervo = reader.GetString("TituloAcervo");
                                acervo.Categoria.NomeCategoria = reader.GetString("NomeCategoria");
                                acervo.Formato.NomeFormato = reader.GetString("NomeFormato");
                                acervo.IdiomaAcervo = reader.GetString("IdiomaAcervo");
                                acervo.AutorAcervo = reader.GetString("AutorAcervo");
                                acervo.EditoraAcervo = reader.GetString("EditoraAcervo");
                                acervo.AnoPublicacaoAcervo = reader.GetInt32("AnoPublicacaoAcervo");
                                acervo.ISBNAcervo = reader.GetString("ISBNAcervo");
                                acervo.QuantidadeAcervo = reader.GetInt32("QuantidadeAcervo");
                                acervo.CodigoIdentificadorAcervo = reader.GetString("CodigoIdentificadorAcervo");
                                acervo.LocalizacaoAcervo = reader.GetString("LocalizacaoAcervo");
                                acervo.Utilizador.NomeUtilizador = reader.GetString("NomeUtilizador");
                                acervo.DataHoraAcervo = reader.GetDateTime("DataHoraAcervo");
                                acervo.EstadoAcervo = reader.GetString("EstadoAcervo");
                                listaAcervo.Add(acervo);
                            }
                        }
                    }
                }
                return listaAcervo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }      
       
        
        public string ObterUltimoCDDAcervo(int CodigoCategoriaAcervo)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT CDDAcervo FROM Acervo WHERE CodigoCategoriaAcervo = @CodigoCategoriaAcervo AND EstadoAcervo = 1 ORDER BY CDDAcervo DESC LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoCategoriaAcervo", CodigoCategoriaAcervo);
                        object ultimoCDDObj = cmd.ExecuteScalar();
                        string ultimoCDD = ultimoCDDObj != null ? ultimoCDDObj.ToString() : "000.000"; // Valor inicial se não houver CDD
                        return ultimoCDD;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }       

        public bool VerificarSeCDDExiste(string CDDAcervo, int CodigoCategoriaAcervo)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                var query = "SELECT COUNT(*) FROM Acervo WHERE CDDAcervo = @CDDAcervo AND CodigoCategoriaAcervo = @CodigoCategoriaAcervo AND EstadoAcervo = 1";
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@CDDAcervo", CDDAcervo);
                    cmd.Parameters.AddWithValue("@CodigoCategoriaAcervo", CodigoCategoriaAcervo);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

    }
}
