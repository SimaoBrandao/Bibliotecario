using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormRedefinirSenha : Form
    {
        private IUtilizadorCamadaNegocio utilizadorCamadaNegocio = new UtilizadorCamadaNegocio();
        public FormRedefinirSenha()
        {
            InitializeComponent();
        }

        private void FormRedefinirSenha_Load(object sender, EventArgs e)
        {

        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    utilizadorCamadaNegocio.RedefinirSenhaUtilizador(txtEmail.Text);
                    MessageBox.Show("Foi enviada para a caixa de entrada do seu e-mail uma senha temporária. Por favor, use-a para acessar o sistema", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
