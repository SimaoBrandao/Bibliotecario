using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAdicionarModalidade : Form
    {
        private readonly IModalidadeCamadaNegocio modalidadeCamadaNegocio = new ModalidadeCamadaNegocio();
        public FormAdicionarModalidade()
        {
            InitializeComponent();
        }

        private void FormAdicionarModalidade_Load(object sender, EventArgs e)
        {

        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    Modalidade modalidade = new Modalidade();
                    modalidade.NomeModalidade = txtModalidade.Text;
                    modalidadeCamadaNegocio.AdicionarModalidade(modalidade);
                    txtModalidade.Text = "";
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
                MessageBox.Show("Informe o Formato", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
