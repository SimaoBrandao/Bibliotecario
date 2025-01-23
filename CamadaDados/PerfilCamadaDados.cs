using System;
using System.Collections.Generic;
using CamadaEntidade;
using MySql.Data.MySqlClient;

namespace CamadaDados
{
    public class PerfilCamadaDados : IPerfilCamadaDados
    {
        private readonly string connectionString = DatabaseConnection.ConnectionString();

        public Perfil ObterPerfilPorCodigo(int CodigoPerfil)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoPerfil,NomePerfil,DataHoraPerfil,EstadoPerfil FROM Perfil WHERE CodigoPerfil = @codigoPerfil AND EstadoPerfil = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@CodigoPerfil", CodigoPerfil);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Perfil perfil = new Perfil();

                            if (reader.Read())
                            {
                                perfil.CodigoPerfil = reader.GetInt32("CodigoPerfil");
                                perfil.NomePerfil = reader.GetString("NomePerfil");
                                perfil.DataHoraPerfil = reader.GetDateTime("DataHoraPerfil");
                                perfil.EstadoPerfil = reader.GetString("EstadoPerfil");
                            }

                            return perfil;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Perfil> ObterTodosPerfil()
        {
            try
            {
                List<Perfil> listaPerfil = new List<Perfil>();
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT codigoPerfil,NomePerfil,DataHoraPerfil,EstadoPerfil FROM Perfil WHERE EstadoPerfil = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Perfil perfil = new Perfil();
                                perfil.CodigoPerfil = reader.GetInt32("CodigoPerfil");
                                perfil.NomePerfil = reader.GetString("NomePerfil");
                                perfil.DataHoraPerfil = reader.GetDateTime("DataHoraPerfil");
                                perfil.EstadoPerfil = reader.GetString("EstadoPerfil");
                                listaPerfil.Add(perfil);
                            }
                        }
                    }
                }
                return listaPerfil;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
