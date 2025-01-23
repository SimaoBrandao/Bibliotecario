using System;
using CamadaDados;
using CamadaEntidade;

namespace CamadaNegocio
{
    public class BibliotecaCamadaNegocio : IBibliotecaCamadaNegocio
    {
        private readonly IBibliotecaCamadaDados bibliotecaCamadaDados = new BibliotecaCamadaDados();
        private ValidacaoCamadaNegocio validacaoCamadaNegocio = new ValidacaoCamadaNegocio();

        public void SalvarBiblioteca(Biblioteca biblioteca)
        {
            try
            {
                if (biblioteca.CodigoBiblioteca > 0)
                {
                    bibliotecaCamadaDados.AtualizarBiblioteca(biblioteca);
                }
                else
                {
                    bibliotecaCamadaDados.AdicionarBiblioteca(biblioteca);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao salvar a Biblioteca. " + ex.Message);
            }
        }      

        public Biblioteca ObterBiblioteca()
        {
            try
            {
                return bibliotecaCamadaDados.ObterBiblioteca();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao obter a Biblioteca. " + ex.Message);
            }
        }
    }
}
