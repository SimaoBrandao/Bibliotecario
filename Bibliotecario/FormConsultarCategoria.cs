using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormConsultarCategoria : Form
    {
        private readonly ICategoriaCamadaNegocio categoriaCamadaNegocio = new CategoriaCamadaNegocio();
        private Categoria categoria = new Categoria();
        public FormConsultarCategoria()
        {
            InitializeComponent();
        }
        
        private void PreencherDataGridView()
        {
            try
            {
                DataGridView.DataSource = categoriaCamadaNegocio.ObterTodasCategorias();
                FormatarDataGridView();
                ContarRegistoNoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }
        private void ContarRegistoNoDataGridView()
        {
            Registros.Text = DataGridView.RowCount.ToString() + " Registros";
        }
        private void FormatarDataGridView()
        {
            //formataGridView
            DataGridView.Columns[0].Visible = false;
            DataGridView.Columns[1].HeaderText = "CDD";
            DataGridView.Columns[2].HeaderText = "Nome";
            DataGridView.Columns[3].Visible = false;
            DataGridView.Columns[4].Visible = false;
            DataGridView.Columns[5].Visible = false;
        }
       
        private void FormConsultarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void BntAdicionarCategoria_Click(object sender, EventArgs e)
        {
            FormAdicionarCategoria form = new FormAdicionarCategoria();
            form.ShowDialog();
            PreencherDataGridView();
        }

        private void BntExcluirCategoria_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir a Categoria?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {
                categoriaCamadaNegocio.ExcluirCategoria(categoria.CodigoCategoria);
                PreencherDataGridView();
            }
        }

        private void FormConsultarCategoria_Activated(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter célula selecionada
            // é um cabeçalho ?
            if (e.RowIndex > -1)
            {
                // não
                categoria.CodigoCategoria = 0;
                categoria.CodigoCategoria = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }        

        private void bntAlterarCategoria_Click(object sender, EventArgs e)
        {
            if (categoria.CodigoCategoria > 0)
            {
                // não
                FormAlterarCategoria form = new FormAlterarCategoria(categoria.CodigoCategoria);
                form.ShowDialog();
                PreencherDataGridView();
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }
    }
}
