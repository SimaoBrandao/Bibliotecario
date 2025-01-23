using CamadaEntidade;

namespace CamadaDados
{
    public interface IBibliotecaCamadaDados
    {
        void AdicionarBiblioteca(Biblioteca biblioteca);
        void AtualizarBiblioteca(Biblioteca biblioteca);
        Biblioteca ObterBiblioteca();
    }
}
