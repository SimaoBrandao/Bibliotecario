using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAlterarModalidade : Form
    {
        private readonly IModalidadeCamadaNegocio modalidadeCamadaNegocio = new ModalidadeCamadaNegocio();
        private Modalidade modalidade = new Modalidade();
        public FormAlterarModalidade(int CodigoModalidade)
        {
            InitializeComponent();
            ObterModalidadePorCodigo(CodigoModalidade);
        }
        private void ObterModalidadePorCodigo(int CodigoModalidade)
        {
            if (CodigoModalidade > 0)
            {
                modalidade = modalidadeCamadaNegocio.ObterModalidadePorCodigo(CodigoModalidade);
                txtModalidade.Text = modalidade.NomeModalidade;
            }
        }
        private void FormAlterarModalidade_Load(object sender, EventArgs e)
        {

        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    modalidade.NomeModalidade = txtModalidade.Text;
                    modalidadeCamadaNegocio.AtualizarModalidade(modalidade);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //Validação dos campos no front End.
        private bool IsValid()
        {
            if (txtModalidade.Text == null || string.IsNullOrEmpty(txtModalidade.Text))
            {
                MessageBox.Show("Informe a Modalidade", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
