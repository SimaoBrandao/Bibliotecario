using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAlterarSenhaAposLogin : Form
    {
        private readonly IUtilizadorCamadaNegocio utilizadorCamadaNegocio = new UtilizadorCamadaNegocio();
        public FormAlterarSenhaAposLogin()
        {
            InitializeComponent();
        }

        private void FormAlterarSenhaAposLogin_Load(object sender, EventArgs e)
        {

        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    Utilizador utilizador = new Utilizador();
                    utilizador.CodigoUtilizador = Utilizador.CodigoUtilizadorLogado;
                    utilizador.SenhaUtilizador = txtsenhaActual.Text;
                    utilizador.NovaSenhaUtilizador = txtnovaSenha.Text;
                    utilizador.ConfirmarNovaSenhaUtilizador = txtconfirmarSenha.Text;

                    utilizadorCamadaNegocio.AlterarSenhaUtilizador(utilizador);
                    MessageBox.Show("Senha atualizada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool IsValid()
        {
            if (txtsenhaActual.Text == null || string.IsNullOrEmpty(txtsenhaActual.Text))
            {
                MessageBox.Show("Informe a Senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtnovaSenha.Text == null || string.IsNullOrEmpty(txtnovaSenha.Text))
            {
                MessageBox.Show("Informe a Nova Senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtconfirmarSenha.Text == null || string.IsNullOrEmpty(txtconfirmarSenha.Text))
            {
                MessageBox.Show("Confirme a Nova Senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
