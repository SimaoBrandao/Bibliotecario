using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormBiblioteca : Form
    {
        private readonly IBibliotecaCamadaNegocio bibliotecaCamadaNegocio = new BibliotecaCamadaNegocio();
        
        public FormBiblioteca()
        {
            InitializeComponent();
            ObterBiblioteca();
        }
       
        private void ObterBiblioteca()
        {
            try
            {
                var biblioteca = bibliotecaCamadaNegocio.ObterBiblioteca();
                txtNomeBiblioteca.Text = biblioteca.NomeBiblioteca;
                txtNifBiblioteca.Text = biblioteca.NifBiblioteca;
                txtEnderecoBiblioteca.Text = biblioteca.EnderecoBiblioteca;
                txtEmailBiblioteca.Text = biblioteca.EmailBiblioteca;
                txtTelemovelBiblioteca.Text = biblioteca.TelemovelBiblioteca;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }        

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    Biblioteca biblioteca = new Biblioteca();
                    biblioteca.NomeBiblioteca = txtNomeBiblioteca.Text;
                    biblioteca.NifBiblioteca = txtNifBiblioteca.Text;
                    biblioteca.EnderecoBiblioteca = txtEnderecoBiblioteca.Text;
                    biblioteca.EmailBiblioteca = txtEmailBiblioteca.Text;
                    biblioteca.TelemovelBiblioteca = txtTelemovelBiblioteca.Text;
                    bibliotecaCamadaNegocio.SalvarBiblioteca(biblioteca);
                    MessageBox.Show("Os dados da Biblioteca foram salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool IsValid()
        {
            if (txtNomeBiblioteca.Text == null || string.IsNullOrEmpty(txtNomeBiblioteca.Text))
            {
                MessageBox.Show("Informe o Nome da Biblioteca", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //else if (txtNifBiblioteca.Text == null || string.IsNullOrEmpty(txtNifBiblioteca.Text))
            //{
            //    MessageBox.Show("Informe o NIF do Contribuinte", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}
            else
            {
                return true;
            }
        }
        
    }
}
