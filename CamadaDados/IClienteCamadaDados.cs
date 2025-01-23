using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaDados
{
    public interface IClienteCamadaDados
    {
        void AdicionarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void ExcluirCliente(int CodigoCliente);
        List<Cliente> ObterTodosCliente();
        Cliente ObterClientePorCodigo(int CodigoCliente);
        List<Cliente> BuscarCliente(string PesquizarCliente);
    }
}
