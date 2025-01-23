using System;
using System.Collections.Generic;
using CamadaDados;
using CamadaEntidade;

namespace CamadaNegocio
{
    public class PerfilCamadaNegocio : IPerfilCamadaNegocio
    {
        private readonly IPerfilCamadaDados perfilCamadaDados = new PerfilCamadaDados();
        private Perfil perfil = new Perfil();
        public Perfil ObterPerfilPorCodigo(int CodigoPerfil)
        {
            try
            {
                if (CodigoPerfil > 0)
                {
                    perfil = perfilCamadaDados.ObterPerfilPorCodigo(CodigoPerfil);
                }

                return perfil;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao obter o perfil. " + ex.Message);
            }
        }

        public List<Perfil> ObterTodosPerfil()
        {
            try
            {
                return perfilCamadaDados.ObterTodosPerfil();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao obter o perfil. " + ex.Message);
            }
        }
    }
}
