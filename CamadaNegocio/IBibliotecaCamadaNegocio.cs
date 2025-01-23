using CamadaEntidade;

namespace CamadaNegocio
{
    public interface IBibliotecaCamadaNegocio
    {
        void SalvarBiblioteca(Biblioteca biblioteca);
        Biblioteca ObterBiblioteca();
    }
}
