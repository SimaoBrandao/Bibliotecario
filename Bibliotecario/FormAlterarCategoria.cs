using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAlterarCategoria : Form
    {
        private readonly ICategoriaCamadaNegocio categoriaCamadaNegocio = new CategoriaCamadaNegocio();
        private Categoria categoria = new Categoria();
        public FormAlterarCategoria(int CodigoEditora)
        {
            InitializeComponent();
            ObterCategoriaPorCodigo(CodigoEditora);
        }
        private void ObterCategoriaPorCodigo(int CodigoCategoria)
        {
            if (CodigoCategoria > 0)
            {
                categoria = categoriaCamadaNegocio.ObterCategoriaPorCodigo(CodigoCategoria);
                txtCategoria.Text = categoria.NomeCategoria;
                txtCDDCategoria.Text = categoria.CDDCategoria.ToString();
            }
        }
        private void FormAlterarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    categoria.NomeCategoria = txtCategoria.Text;
                    categoria.CDDCategoria = txtCDDCategoria.Text;
                    categoriaCamadaNegocio.AtualizarCategoria(categoria);
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
        private void bntCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
