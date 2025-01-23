using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormConsultarCliente : Form
    {
        private readonly IClienteCamadaNegocio clienteCamadaNegocio = new ClienteCamadaNegocio();
        private Cliente cliente = new Cliente();
        public FormConsultarCliente()
        {
            InitializeComponent();
            Consultar();
        }

        private void ObterTodosClientes()
        {
            try
            {
                cliente.ListaCliente = clienteCamadaNegocio.ObterTodosCliente();
                PreencherDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BuscarCliente(string PesquizarCliente)
        {
            try
            {
                cliente.ListaCliente = clienteCamadaNegocio.BuscarCliente(PesquizarCliente);
                PreencherDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PreencherDataGridView()
        {
            DataGridView.DataSource = cliente.ListaCliente;
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
            DataGridView.Columns[2].HeaderText = "Género";
            DataGridView.Columns[3].Visible = false;
            DataGridView.Columns[4].Visible = false;
            DataGridView.Columns[5].Visible = false;
            DataGridView.Columns[6].Visible = false;
            DataGridView.Columns[7].Visible = false;
            DataGridView.Columns[8].Visible = false;
            DataGridView.Columns[9].Visible = false;
            DataGridView.Columns[10].Visible = false;
        }

        private void Consultar()
        {
            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                ObterTodosClientes();
            }
            else
            {
                BuscarCliente(txtCliente.Text);
            }
        }
        private void FormConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void BntAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormAdicionarCliente form = new FormAdicionarCliente();
            form.ShowDialog();
            Consultar();
        }

        private void BntExcluirCliente_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir o Cliente?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                clienteCamadaNegocio.ExcluirCliente(cliente.CodigoCliente);
                Consultar();
            }
        }

        private void FormConsultarCliente_Activated(object sender, EventArgs e)
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
                cliente.CodigoCliente = 0;
                cliente.CodigoCliente = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }

        private void bntAlterarCliente_Click(object sender, EventArgs e)
        {
            if (cliente.CodigoCliente > 0)
            {
                // não
                FormAlterarCliente form = new FormAlterarCliente(cliente.CodigoCliente);
                form.ShowDialog();
                Consultar();
            }
        }
    }
}
