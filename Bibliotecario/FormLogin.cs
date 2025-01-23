using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormLogin : Form
    {
        private readonly IUtilizadorCamadaNegocio utilizadorCamadaNegocio = new UtilizadorCamadaNegocio();
        public FormLogin()
        {
            InitializeComponent();
        }        
       
        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }       
        
        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Autenticado = utilizadorCamadaNegocio.Login(txtEmail.Text, txtSenha.Text);

                if (Autenticado && !Utilizador.AlterarSenhaAposLogin)
                {
                    DialogResult = DialogResult.OK;
                }
                else if (Autenticado && Utilizador.AlterarSenhaAposLogin)
                {
                    FormAlterarSenhaAposLogin form = new FormAlterarSenhaAposLogin();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("E-mail ou Senha inválida", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lkbCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNovaContaUtilizador form = new FormNovaContaUtilizador();
            form.ShowDialog();
        }

        private void lkbDefinicao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormServidorDados form = new FormServidorDados();
            form.ShowDialog();
            Application.Restart();
            //fecha o formulario actual
            this.Close();
        }

        private void lkbEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRedefinirSenha form = new FormRedefinirSenha();
            form.ShowDialog();
        }
    }
}
