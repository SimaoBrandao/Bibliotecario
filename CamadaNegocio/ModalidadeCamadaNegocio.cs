using System;
using System.Collections.Generic;
using CamadaDados;
using CamadaEntidade;

namespace CamadaNegocio
{
    public class ModalidadeCamadaNegocio : IModalidadeCamadaNegocio
    {
        private readonly IModalidadeCamadaDados modalidadeCamadaDados = new ModalidadeCamadaDados();
        private ValidacaoCamadaNegocio validacaoCamadaNegocio = new ValidacaoCamadaNegocio();
        public void AdicionarModalidade(Modalidade modalidade)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(modalidade))
                {
                    modalidadeCamadaDados.AdicionarModalidade(modalidade);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao adicionar a Modalidade. " + ex.Message);
            }
        }

        public void AtualizarModalidade(Modalidade modalidade)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(modalidade) && modalidade.CodigoModalidade > 0)
                {
                    modalidadeCamadaDados.AtualizarModalidade(modalidade);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao atualizar a Modalidade. " + ex.Message);
            }
        }

        public void ExcluirModalidade(int CodigoModalidade)
        {
            try
            {
                if (CodigoModalidade > 0)
                {
                    modalidadeCamadaDados.ExcluirModalidade(CodigoModalidade);
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao adicionar a Modalidade. " + ex.Message);
            }
        }

        public Modalidade ObterModalidadePorCodigo(int CodigoModalidade)
        {
            try
            {
                Modalidade modalidade = new Modalidade();

                if (CodigoModalidade > 0)
                {
                    modalidade = modalidadeCamadaDados.ObterModalidadePorCodigo(CodigoModalidade);
                }

                return modalidade;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter a Modalidade. " + ex.Message);
            }
        }

        public List<Modalidade> ObterTodasModalidade()
        {
            try
            {
                return modalidadeCamadaDados.ObterTodasModalidade();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter a Modalidade. " + ex.Message);
            }
        }
    }
}
