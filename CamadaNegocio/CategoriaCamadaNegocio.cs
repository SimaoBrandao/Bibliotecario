using System;
using System.Collections.Generic;
using CamadaDados;
using CamadaEntidade;

namespace CamadaNegocio
{
    public class CategoriaCamadaNegocio : ICategoriaCamadaNegocio
    {
        private readonly ICategoriaCamadaDados categoriaCamadaDados = new CategoriaCamadaDados();
        private ValidacaoCamadaNegocio validacaoCamadaNegocio = new ValidacaoCamadaNegocio();
        public void AdicionarCategoria(Categoria categoria)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(categoria))
                {
                   categoriaCamadaDados.AdicionarCategoria(categoria);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao adicionar a categoria. " + ex.Message);
            }
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(categoria) && categoria.CodigoCategoria > 0)
                {
                    categoriaCamadaDados.AtualizarCategoria(categoria);
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao atualizar a categoria. " + ex.Message);
            }
        }

        public void ExcluirCategoria(int CodigoCategoria)
        {
            try
            {
                if (CodigoCategoria > 0)
                {
                    categoriaCamadaDados.ExcluirCategoria(CodigoCategoria);
                }
                
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao adicionar a categoria. " + ex.Message);
            }
        }

        public Categoria ObterCategoriaPorCodigo(int CodigoCategoria)
        {
            try
            {
                Categoria categoria = new Categoria();

                if (CodigoCategoria > 0)
                {
                    categoria = categoriaCamadaDados.ObterCategoriaPorCodigo(CodigoCategoria);
                }

                return categoria;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter a categoria. " + ex.Message);
            }
        }

        public List<Categoria> ObterCategoriaPorNome(string NomeCategoria)
        {
            try
            {
                List<Categoria> listaCategoria = new List<Categoria>();

                if (!string.IsNullOrEmpty(NomeCategoria))
                {
                    listaCategoria = categoriaCamadaDados.ObterCategoriaPorNome(NomeCategoria);
                }

                return listaCategoria;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter a categoria. " + ex.Message);
            }
        }

        public List<Categoria> ObterTodasCategorias()
        {
            try
            {
                return categoriaCamadaDados.ObterTodasCategorias();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter a categoria. " + ex.Message);
            }
        }
    }
}
