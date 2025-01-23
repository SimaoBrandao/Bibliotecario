using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAlterarUtilizador : Form
    {
        private readonly IUtilizadorCamadaNegocio utilizadorCamadaNegocio = new UtilizadorCamadaNegocio();
        private Utilizador utilizador = new Utilizador();
        public FormAlterarUtilizador(int codigoUtilizador)
        {
            InitializeComponent();
            PreencherCampoCbPerfil();
            ObterUtilizadorPorCodigo(codigoUtilizador);
        }

        private void ObterUtilizadorPorCodigo(int CodigoUtilizador)
        {
            if (CodigoUtilizador > 0)
            {
                utilizador = utilizadorCamadaNegocio.ObterUtilizadorPorCodigo(CodigoUtilizador);
                txtNomeUtilizador.Text = utilizador.NomeUtilizador;
                txtEmailUtilizador.Text = utilizador.EmailUtilizador;
                utilizador.SenhaAnteriorUtilizador = utilizador.SenhaUtilizador; //variavel usada para verificar se a senha foi alterada
                cbPerfil.Text = utilizador.Perfil.NomePerfil;
                txtSenhaUtilizador.Text = utilizador.SenhaUtilizador;
            }
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
        private void FormAlterarUtilizador_Load(object sender, EventArgs e)
        {

        }

        private void bntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    utilizador.NomeUtilizador = txtNomeUtilizador.Text;
                    utilizador.EmailUtilizador = txtEmailUtilizador.Text;
                    utilizador.Perfil.CodigoPerfil = int.Parse(cbPerfil.SelectedValue.ToString());
                    utilizadorCamadaNegocio.AtualizarUtilizador(utilizador);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
