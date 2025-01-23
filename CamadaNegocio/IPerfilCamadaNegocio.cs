using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaNegocio
{
    public interface IPerfilCamadaNegocio
    {
        List<Perfil> ObterTodosPerfil();
        Perfil ObterPerfilPorCodigo(int CodigoPerfil);
    }
}
