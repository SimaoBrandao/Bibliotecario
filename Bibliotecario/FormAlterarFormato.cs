using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAlterarFormato : Form
    {
        private readonly IFormatoCamadaNegocio formatoCamadaNegocio = new FormatoCamadaNegocio();
        private Formato formato = new Formato();
        public FormAlterarFormato(int CodigoFormato)
        {
            InitializeComponent();
            ObterFormatoPorCodigo(CodigoFormato);
        }
        private void ObterFormatoPorCodigo(int CodigoFormato)
        {
            if (CodigoFormato > 0)
            {
                formato = formatoCamadaNegocio.ObterFormatoPorCodigo(CodigoFormato);
                txtFormato.Text = formato.NomeFormato;
            }
        }
        private void FormAlterarFormato_Load(object sender, EventArgs e)
        {

        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    formato.NomeFormato = txtFormato.Text;
                    formatoCamadaNegocio.AtualizarFormato(formato);
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
            if (txtFormato.Text == null || string.IsNullOrEmpty(txtFormato.Text))
            {
                MessageBox.Show("Informe o Formato", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
