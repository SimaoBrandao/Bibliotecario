using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAdicionarUtilizador : Form
    {
        private readonly IUtilizadorCamadaNegocio utilizadorCamadaNegocio = new UtilizadorCamadaNegocio();
        private Utilizador utilizador = new Utilizador();
        public FormAdicionarUtilizador()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtNomeUtilizador.Text = "";
            txtEmailUtilizador.Text = "";
            txtSenhaUtilizador.Text = "";
            LimparCampoCbPerfil();
            txtNomeUtilizador.Focus();
        }
        private void PreencherCampoCbPerfil()
        {
            IPerfilCamadaNegocio perfilCamadaNegocio = new PerfilCamadaNegocio();
            cbPerfil.DataSource = perfilCamadaNegocio.ObterTodosPerfil();
            cbPerfil.ValueMember = "CodigoPerfil";
            cbPerfil.DisplayMember = "NomePerfil";
            cbPerfil.Update();
            LimparCampoCbPerfil();
        }
        private void LimparCampoCbPerfil()
        {
            cbPerfil.Text = "";
            cbPerfil.SelectedValue = 0;
        }
       
        //Validação dos campos no front End.
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
            else if (cbPerfil.Text == null || string.IsNullOrEmpty(cbPerfil.Text))
            {
                MessageBox.Show("Informe o Perfil", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void FormAdicionarUtilizador_Load(object sender, EventArgs e)
        {

        }

        private void FormAdicionarUtilizador_Activated(object sender, EventArgs e)
        {
            PreencherCampoCbPerfil();
        }

        private void bntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    utilizador.NomeUtilizador = txtNomeUtilizador.Text;
                    utilizador.EmailUtilizador = txtEmailUtilizador.Text;
                    utilizador.SenhaUtilizador = txtSenhaUtilizador.Text;
                    utilizador.Perfil.CodigoPerfil = int.Parse(cbPerfil.SelectedValue.ToString());
                    utilizadorCamadaNegocio.AdicionarUtilizador(utilizador);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
