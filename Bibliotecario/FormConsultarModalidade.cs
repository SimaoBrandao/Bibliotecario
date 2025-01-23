using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormConsultarModalidade : Form
    {
        private readonly IModalidadeCamadaNegocio modalidadeCamadaNegocio = new ModalidadeCamadaNegocio();
        private Modalidade modalidade = new Modalidade();
        public FormConsultarModalidade()
        {
            InitializeComponent();
        }
        private void PreencherDataGridView()
        {
            try
            {
                DataGridView.DataSource = modalidadeCamadaNegocio.ObterTodasModalidade();
                FormatarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormatarDataGridView()
        {
            //formataGridView
            DataGridView.Columns[0].Visible = false;
            DataGridView.Columns[1].HeaderText = "Nome";
            DataGridView.Columns[2].Visible = false;
            DataGridView.Columns[3].Visible = false;
        }
        private void FormConsultarModalidade_Load(object sender, EventArgs e)
        {

        }

        private void BntAdicionarModalidade_Click(object sender, EventArgs e)
        {
            FormAdicionarModalidade form = new FormAdicionarModalidade();
            form.ShowDialog();
            PreencherDataGridView();
        }

        private void bntAlterarModalidade_Click(object sender, EventArgs e)
        {
            if (modalidade.CodigoModalidade > 0)
            {
                // não
                FormAlterarModalidade form = new FormAlterarModalidade(modalidade.CodigoModalidade);
                form.ShowDialog();
                PreencherDataGridView();
            }
        }

        private void BntExcluirModalidade_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir a Modalidade?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                modalidadeCamadaNegocio.ExcluirModalidade(modalidade.CodigoModalidade);
                PreencherDataGridView();
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter célula selecionada
            // é um cabeçalho ?
            if (e.RowIndex > -1)
            {
                // não
                modalidade.CodigoModalidade = 0;
                modalidade.CodigoModalidade = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void FormConsultarModalidade_Activated(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }
    }
}
