using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormNovaContaUtilizador : Form
    {
        private readonly IUtilizadorCamadaNegocio utilizadorCamadaNegocio = new UtilizadorCamadaNegocio();
        public FormNovaContaUtilizador()
        {
            InitializeComponent();
        }

        private void bntConfirmar_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (IsValid())
                {
                    Utilizador utilizador = new Utilizador();
                    utilizador.NomeUtilizador = txtNomeUtilizador.Text;
                    utilizador.EmailUtilizador = txtEmailUtilizador.Text;
                    utilizador.SenhaUtilizador = txtSenhaUtilizador.Text;
                    utilizadorCamadaNegocio.NovaContaUtilizador(utilizador);
                    MessageBox.Show("Conta Criada com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }


        private bool IsValid()
        {
            if (txtNomeUtilizador.Text == null || string.IsNullOrEmpty(txtNomeUtilizador.Text))
            {
                MessageBox.Show("Informe o Nome do Utilizador", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtEmailUtilizador.Text == null || string.IsNullOrEmpty(txtEmailUtilizador.Text))
            {
                MessageBox.Show("Informe o E-mail", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtSenhaUtilizador.Text == null || string.IsNullOrEmpty(txtSenhaUtilizador.Text))
            {
                MessageBox.Show("Informe a Senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtSenhaUtilizador.Text != txtConfirmarSenhaUtilizador.Text)
            {
                MessageBox.Show("As Senhas não Coincidem", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void FormCriarContaUtilizador_Load(object sender, EventArgs e)
        {

        }
    }
}
