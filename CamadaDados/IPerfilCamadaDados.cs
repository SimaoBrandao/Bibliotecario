using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaDados
{
    public interface IPerfilCamadaDados
    {
        List<Perfil> ObterTodosPerfil();
        Perfil ObterPerfilPorCodigo(int CodigoPerfil);
    }
}
