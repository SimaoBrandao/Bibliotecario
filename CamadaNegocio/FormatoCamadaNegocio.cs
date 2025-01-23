using System;
using System.Collections.Generic;
using CamadaDados;
using CamadaEntidade;

namespace CamadaNegocio
{
    public class FormatoCamadaNegocio : IFormatoCamadaNegocio
    {
        private readonly IFormatoCamadaDados formatoCamadaDados = new FormatoCamadaDados();
        private ValidacaoCamadaNegocio validacaoCamadaNegocio = new ValidacaoCamadaNegocio();
        public void AdicionarFormato(Formato formato)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(formato))
                {
                    formatoCamadaDados.AdicionarFormato(formato);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao adicionar o Formato. " + ex.Message);
            }
        }

        public void AtualizarFormato(Formato formato)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(formato) && formato.CodigoFormato > 0)
                {
                    formatoCamadaDados.AtualizarFormato(formato);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao atualizar o Formato. " + ex.Message);
            }
        }

        public void ExcluirFormato(int CodigoFormato)
        {
            try
            {
                if (CodigoFormato > 0)
                {
                    formatoCamadaDados.ExcluirFormato(CodigoFormato);
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao adicionar o Formato. " + ex.Message);
            }
        }

        public Formato ObterFormatoPorCodigo(int CodigoFormato)
        {
            try
            {
                Formato formato = new Formato();

                if (CodigoFormato > 0)
                {
                    formato = formatoCamadaDados.ObterFormatoPorCodigo(CodigoFormato);
                }

                return formato;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o Formato. " + ex.Message);
            }
        }

        public List<Formato> ObterFormatoPorNome(string NomeFormato)
        {
            try
            {
                List<Formato> listaFormato = new List<Formato>();

                if (!string.IsNullOrEmpty(NomeFormato))
                {
                    listaFormato = formatoCamadaDados.ObterFormatoPorNome(NomeFormato);
                }

                return listaFormato;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o Formato. " + ex.Message);
            }
        }

        public List<Formato> ObterTodosFormatos()
        {
            try
            {
                return formatoCamadaDados.ObterTodosFormatos();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o Formato. " + ex.Message);
            }
        }
    }
}
