using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAlterarCliente : Form
    {
        private readonly IClienteCamadaNegocio clienteCamadaNegocio = new ClienteCamadaNegocio();
        private Cliente cliente = new Cliente();
        public FormAlterarCliente(int CodigoCliente)
        {
            InitializeComponent();
            PreencherCampoCbModalidadeCliente();
            ObterClientePorCodigo(CodigoCliente);
        }
        private void ObterClientePorCodigo(int CodigoCliente)
        {
            if (CodigoCliente > 0)
            {
                cliente = clienteCamadaNegocio.ObterClientePorCodigo(CodigoCliente);
                txtNomeCliente.Text = cliente.NomeCliente;
                cbGeneroCliente.Text = cliente.GeneroCliente;
                cbModalidadeCliente.Text = cliente.Modalidade.NomeModalidade;
                txtNumeroBICliente.Text = cliente.NumeroBilheteIdentidadeCliente;
                txtEnderecoCliente.Text = cliente.EnderecoCliente;
                txtTelemovelCliente.Text = cliente.TelemovelCliente;
                txtEmailCliente.Text = cliente.EmailCliente;
            }
        }
        private void PreencherCampoCbModalidadeCliente()
        {
            IModalidadeCamadaNegocio modalidadeCamadaNegocio = new ModalidadeCamadaNegocio();
            cbModalidadeCliente.DataSource = modalidadeCamadaNegocio.ObterTodasModalidade();
            cbModalidadeCliente.ValueMember = "CodigoModalidade";
            cbModalidadeCliente.DisplayMember = "NomeModalidade";
            cbModalidadeCliente.Update();
        }

        private void FormAlterarCliente_Load(object sender, EventArgs e)
        {

        }        
        private bool IsValid()
        {
            if (txtNomeCliente.Text == null || string.IsNullOrEmpty(txtNomeCliente.Text))
            {
                MessageBox.Show("Informe o Nome", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (cbGeneroCliente.Text == null || string.IsNullOrEmpty(cbGeneroCliente.Text))
            {
                MessageBox.Show("Informe o Genero", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (cbModalidadeCliente.Text == "" || string.IsNullOrEmpty(cbModalidadeCliente.Text))
            {
                MessageBox.Show("Informe a Categoria", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    cliente.NomeCliente = txtNomeCliente.Text;
                    cliente.GeneroCliente = cbGeneroCliente.Text;
                    cliente.Modalidade.CodigoModalidade = int.Parse(cbModalidadeCliente.SelectedValue.ToString());
                    cliente.NumeroBilheteIdentidadeCliente = txtNumeroBICliente.Text;
                    cliente.EnderecoCliente = txtEnderecoCliente.Text;
                    cliente.TelemovelCliente = txtTelemovelCliente.Text;
                    cliente.EmailCliente = txtEmailCliente.Text;
                    clienteCamadaNegocio.AtualizarCliente(cliente);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
