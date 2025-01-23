using System;
using System.Collections.Generic;
using CamadaDados;
using CamadaEntidade;

namespace CamadaNegocio
{
    public class ClienteCamadaNegocio : IClienteCamadaNegocio
    {
        private readonly IClienteCamadaDados clienteCamadaDados = new ClienteCamadaDados();
        private ValidacaoCamadaNegocio validacaoCamadaNegocio = new ValidacaoCamadaNegocio();
        public void AdicionarCliente(Cliente cliente)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(cliente))
                {
                    clienteCamadaDados.AdicionarCliente(cliente);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao adicionar o cliente. " + ex.Message);
            }
        }

        public void AtualizarCliente(Cliente pessoa)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(pessoa) && pessoa.CodigoCliente > 0)
                {
                    clienteCamadaDados.AtualizarCliente(pessoa);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao atualizar o cliente. " + ex.Message);
            }
        }

        public void ExcluirCliente(int CodigoCliente)
        {
            try
            {
                if (CodigoCliente > 0)
                {
                    clienteCamadaDados.ExcluirCliente(CodigoCliente);
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao adicionar o cliente. " + ex.Message);
            }
        }

        public Cliente ObterClientePorCodigo(int CodigoCliente)
        {
            try
            {
                Cliente cliente = new Cliente();

                if (CodigoCliente > 0)
                {
                    cliente = clienteCamadaDados.ObterClientePorCodigo(CodigoCliente);
                }

                return cliente;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o cliente. " + ex.Message);
            }
        }
        public List<Cliente> ObterTodosCliente()
        {
            try
            {
                return clienteCamadaDados.ObterTodosCliente();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o cliente. " + ex.Message);
            }
        }

        public List<Cliente> BuscarCliente(string PesquizarCliente)
        {
            try
            {
                List<Cliente> listaCliente = new List<Cliente>();

                if (!string.IsNullOrEmpty(PesquizarCliente))
                {
                    listaCliente = clienteCamadaDados.BuscarCliente(PesquizarCliente);
                }

                return listaCliente;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o cliente. " + ex.Message);
            }

        }
       
    }
}
