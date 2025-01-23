using CamadaEntidade;
using System.Collections.Generic;

namespace CamadaNegocio
{
    public interface IClienteCamadaNegocio
    {
        void AdicionarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void ExcluirCliente(int CodigoCliente);
        List<Cliente> ObterTodosCliente();
        Cliente ObterClientePorCodigo(int CodigoCliente);
        List<Cliente> BuscarCliente(string PesquizarCliente);
    }
}
