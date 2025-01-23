using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormConsultarFormato : Form
    {
        private readonly IFormatoCamadaNegocio formatoCamadaNegocio = new FormatoCamadaNegocio();
        private Formato formato = new Formato();
        public FormConsultarFormato()
        {
            InitializeComponent();
        }
        private void ObterTodosFormatos()
        {
            try
            {
                formato.ListaFormato = formatoCamadaNegocio.ObterTodosFormatos();
                PreencherDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ObterFormatoPorNome(string NomeFormato)
        {
            try
            {
                formato.ListaFormato = formatoCamadaNegocio.ObterFormatoPorNome(NomeFormato);
                PreencherDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PreencherDataGridView()
        {
            DataGridView.DataSource = formato.ListaFormato;
            FormatarDataGridView();
            ContarRegistoNoDataGridView();
        }
        private void ContarRegistoNoDataGridView()
        {
            Registros.Text = DataGridView.RowCount.ToString() + " Registros";
        }
        private void FormatarDataGridView()
        {
            //formataGridView
            DataGridView.Columns[0].Visible = false;
            DataGridView.Columns[1].HeaderText = "Nome";
            DataGridView.Columns[2].Visible = false;
            DataGridView.Columns[3].Visible = false;
            DataGridView.Columns[4].Visible = false;
        }
        private void Consultar()
        {
            if (string.IsNullOrEmpty(txtFormato.Text))
            {
                ObterTodosFormatos();
            }
            else
            {
                ObterFormatoPorNome(txtFormato.Text);
            }
        }
        private void FormConsultarFormato_Load(object sender, EventArgs e)
        {

        }

        private void BntAdicionarFormato_Click(object sender, EventArgs e)
        {
            FormAdicionarFormato form = new FormAdicionarFormato();
            form.ShowDialog();
            Consultar();
        }

        private void BntExcluirFormato_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir o Formato?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                formatoCamadaNegocio.ExcluirFormato(formato.CodigoFormato);
                Consultar();
            }
        }

        private void FormConsultarFormato_Activated(object sender, EventArgs e)
        {
            Consultar();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter célula selecionada
            // é um cabeçalho ?
            if (e.RowIndex > -1)
            {
                // não
                formato.CodigoFormato = 0;
                formato.CodigoFormato = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void bntAlterarFormato_Click(object sender, EventArgs e)
        {
            if (formato.CodigoFormato > 0)
            {
                // não
                FormAlterarFormato form = new FormAlterarFormato(formato.CodigoFormato);
                form.ShowDialog();
                Consultar();
            }
        }

        private void txtFormato_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
