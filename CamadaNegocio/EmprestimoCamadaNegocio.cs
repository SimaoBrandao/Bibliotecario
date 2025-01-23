using System;
using System.Collections.Generic;
using CamadaDados;
using CamadaEntidade;

namespace CamadaNegocio
{
    public class EmprestimoCamadaNegocio : IEmprestimoCamadaNegocio
    {
        private readonly IEmprestimoCamadaDados emprestimoCamadaDados = new EmprestimoCamadaDados();
        private ValidacaoCamadaNegocio validacaoCamadaNegocio = new ValidacaoCamadaNegocio();
        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(emprestimo))
                {                   
                    emprestimoCamadaDados.AdicionarEmprestimo(emprestimo);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void AtualizarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(emprestimo) && emprestimo.CodigoEmprestimo > 0)
                {
                    emprestimoCamadaDados.AtualizarEmprestimo(emprestimo);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao atualizar o emprestimo. " + ex.Message);
            }
        }

        public void ExcluirEmprestimo(int CodigoEmprestimo)
        {
            try
            {
                if (CodigoEmprestimo > 0)
                {
                    emprestimoCamadaDados.ExcluirEmprestimo(CodigoEmprestimo);
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao excluir o emprestimo. " + ex.Message);
            }
        }
        public void DevolucaoEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                if (emprestimo.CodigoEmprestimo > 0)
                {
                    if (emprestimoCamadaDados.VerificarSeEmprestimoFoiDevolvido(emprestimo.CodigoEmprestimo))
                    {
                        throw new ArgumentException("O acervo selecionado já foi devolvido. ");                                                
                    }                   
                    else 
                    {
                        emprestimoCamadaDados.DevolucaoEmprestimo(emprestimo);
                    }
                }
                else
                {
                    throw new ArgumentException("Selecione o acervo para devolução. ");
                }
                
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void AnularDevolucaoEmprestimo(int CodigoEmprestimo)
        {
            try
            {
                if (CodigoEmprestimo > 0 && emprestimoCamadaDados.VerificarSeEmprestimoFoiDevolvido(CodigoEmprestimo))
                {
                    emprestimoCamadaDados.AnularDevolucaoEmprestimo(CodigoEmprestimo);
                }                
                else
                {
                    throw new ArgumentException("Selecione um acervo devolvido. ");
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        
        public Emprestimo ObterEmprestimoPorCodigo(int CodigoEmprestimo)
        {
            try
            {
                Emprestimo emprestimo = new Emprestimo();

                if (CodigoEmprestimo > 0)
                {
                    emprestimo = emprestimoCamadaDados.ObterEmprestimoPorCodigo(CodigoEmprestimo);
                }

                return emprestimo;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o emprestimo. " + ex.Message);
            }
        }
        public List<Emprestimo> ObterTodosEmprestimo()
        {
            try
            {
                return emprestimoCamadaDados.ObterTodosEmprestimo();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o emprestimo. " + ex.Message);
            }
        }
        public List<Emprestimo> ObterEmprestimoPorNomeCliente(string NomeCliente)
        {
            try
            {
                List<Emprestimo> listaEmprestimoDoCliente = new List<Emprestimo>();

                if (!string.IsNullOrEmpty(NomeCliente))
                {
                    listaEmprestimoDoCliente = emprestimoCamadaDados.ObterEmprestimoPorNomeCliente(NomeCliente);
                }

                return listaEmprestimoDoCliente;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o emprestimo. " + ex.Message);
            }
        }
        public List<Emprestimo> ObterEmprestimoPorCDDAcervo(int CDDAcervo)
        {
            try
            {
                List<Emprestimo> listaEmprestimoPorAcervo = new List<Emprestimo>();

                if (CDDAcervo > 0)
                {
                    listaEmprestimoPorAcervo = emprestimoCamadaDados.ObterEmprestimoPorCDDAcervo(CDDAcervo);
                }

                return listaEmprestimoPorAcervo;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o emprestimo. " + ex.Message);
            }
        }
        public List<Emprestimo> ObterEmprestimoPorTituloAcervo(string TituloAcervo)
        {
            try
            {
                List<Emprestimo> listaEmprestimoPorAcervo = new List<Emprestimo>();

                if (!string.IsNullOrEmpty(TituloAcervo))
                {
                    listaEmprestimoPorAcervo = emprestimoCamadaDados.ObterEmprestimoPorTituloAcervo(TituloAcervo);
                }

                return listaEmprestimoPorAcervo;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o emprestimo. " + ex.Message);
            }
        }      

        public List<Emprestimo> ObterEmprestimoPorDataEmprestimo(DateTime DataEmprestimo)
        {
            try
            {
                 return emprestimoCamadaDados.ObterEmprestimoPorDataEmprestimo(DataEmprestimo);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o empréstimo. " + ex.Message);
            }

        }
        public bool VerificarAcervoEmprestado(int CodigoAcervo)
        {
            try
            {
                bool estado = false;
                
                if(CodigoAcervo > 0)
                {
                    estado = emprestimoCamadaDados.VerificarAcervoEmprestado(CodigoAcervo);
                }

                return estado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
