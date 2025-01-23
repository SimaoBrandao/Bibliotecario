using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAdicionarCategoria : Form
    {
        private readonly ICategoriaCamadaNegocio categoriaCamadaNegocio = new CategoriaCamadaNegocio();
        public FormAdicionarCategoria()
        {
            InitializeComponent();
        }

        private void FormAdicionarCategoria_Load(object sender, EventArgs e)
        {

        }
        private void LimparCampos()
        {
            txtCategoria.Text = "";
            txtCDDCategoria.Text = "";
            txtCategoria.Focus();
        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    Categoria categoria = new Categoria();
                    categoria.NomeCategoria = txtCategoria.Text;
                    categoria.CDDCategoria = txtCDDCategoria.Text;
                    categoriaCamadaNegocio.AdicionarCategoria(categoria);
                    LimparCampos();
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
            if (txtCategoria.Text == null || string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show("Informe a Categoria", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtCDDCategoria.Text == null || string.IsNullOrEmpty(txtCDDCategoria.Text))
            {
                MessageBox.Show("Informe o CDD da Categoria", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
