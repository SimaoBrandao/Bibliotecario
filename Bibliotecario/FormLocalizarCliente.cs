using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormLocalizarCliente : Form
    {
        private readonly IClienteCamadaNegocio clienteCamadaNegocio = new ClienteCamadaNegocio();
        private Cliente cliente = new Cliente();
        public FormLocalizarCliente()
        {
            InitializeComponent();
            Consultar();
        }
        private void ObterTodosClientes()
        {
            cliente.ListaCliente = clienteCamadaNegocio.ObterTodosCliente();
            PreencherDataGridView();
        }
        private void BuscarCliente(string PesquizarCliente)
        {
            cliente.ListaCliente = clienteCamadaNegocio.BuscarCliente(PesquizarCliente);
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {
            DataGridView.DataSource = cliente.ListaCliente;
            FormatarDataGridView();
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
        private void FormLocalizarCliente_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter célula selecionada
            // é um cabeçalho ?
            if (e.RowIndex > -1)
            {
                // não
                Cliente.CodigoClienteTransferencia = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                Close();
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
