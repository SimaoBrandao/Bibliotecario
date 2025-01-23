using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAdicionarFormato : Form
    {
        private readonly IFormatoCamadaNegocio formatoCamadaNegocio = new FormatoCamadaNegocio();
        public FormAdicionarFormato()
        {
            InitializeComponent();
        }

        private void FormAdicionarFormato_Load(object sender, EventArgs e)
        {

        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    Formato formato = new Formato();
                    formato.NomeFormato = txtFormato.Text;
                    formatoCamadaNegocio.AdicionarFormato(formato);
                    txtFormato.Text = "";
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
    }
}
