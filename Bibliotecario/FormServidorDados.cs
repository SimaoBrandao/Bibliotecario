using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormServidorDados : Form
    {
        private readonly DatabaseConnection databaseConnection = new DatabaseConnection();
        public FormServidorDados()
        {
            InitializeComponent();
        }
        
        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    databaseConnection.SalvarDatabaseConnection(txtServidor.Text, txtPorta.Text ,txtUsuario.Text, txtSenha.Text);
                    MessageBox.Show("Adicionado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool IsValid()
        {
            if (txtServidor.Text == null || string.IsNullOrEmpty(txtServidor.Text))
            {
                MessageBox.Show("Informe o Servidor", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtPorta.Text == null || string.IsNullOrEmpty(txtPorta.Text))
            {
                MessageBox.Show("Informe a Porta", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtUsuario.Text == null || string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Informe o Usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //else if (txtSenha.Text == null || string.IsNullOrEmpty(txtSenha.Text))
            //{
            //    MessageBox.Show("Informe a Senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}
            else
            {
                return true;
            }
        }

        private void FormServidorDados_Load(object sender, EventArgs e)
        {
            var dados = databaseConnection.ObterDatabaseConnection();
            txtServidor.Text = dados.Server;
            txtPorta.Text = dados.Port;
            txtUsuario.Text = dados.User;
            txtSenha.Text = dados.Password;
        }
    }
}
