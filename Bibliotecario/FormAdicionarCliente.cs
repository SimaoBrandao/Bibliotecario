using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAdicionarCliente : Form
    {
        private readonly IClienteCamadaNegocio clienteCamadaNegocio = new ClienteCamadaNegocio();
        public FormAdicionarCliente()
        {
            InitializeComponent();
            PreencherCampoCbModalidadeCliente();
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNomeCliente.Text = "";
            cbGeneroCliente.Text = "";
            LimparCampoCbModalidadeCliente();
            txtEnderecoCliente.Text = "";
            txtTelemovelCliente.Text = "";
            txtNumeroBICliente.Text = "";
            txtEmailCliente.Text = "";           
            txtNomeCliente.Focus();
        }
        private void PreencherCampoCbModalidadeCliente()
        {
            IModalidadeCamadaNegocio modalidadeCamadaNegocio = new ModalidadeCamadaNegocio();
            cbModalidadeCliente.DataSource = modalidadeCamadaNegocio.ObterTodasModalidade();
            cbModalidadeCliente.ValueMember = "CodigoModalidade";
            cbModalidadeCliente.DisplayMember = "NomeModalidade";
            cbModalidadeCliente.Update();
            LimparCampoCbModalidadeCliente();
        }
        private void LimparCampoCbModalidadeCliente()
        {
            cbModalidadeCliente.Text = "";
            cbModalidadeCliente.SelectedValue = 0;
        }
        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    Cliente cliente = new Cliente();
                    cliente.NomeCliente = txtNomeCliente.Text;
                    cliente.GeneroCliente = cbGeneroCliente.Text;
                    cliente.Modalidade.CodigoModalidade = int.Parse(cbModalidadeCliente.SelectedValue.ToString());
                    cliente.NumeroBilheteIdentidadeCliente = txtNumeroBICliente.Text;
                    cliente.EnderecoCliente = txtEnderecoCliente.Text;
                    cliente.TelemovelCliente = txtTelemovelCliente.Text;
                    cliente.EmailCliente = txtEmailCliente.Text;
                    clienteCamadaNegocio.AdicionarCliente(cliente);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                MessageBox.Show("Informe a Modalidade", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }            
            else
            {
                return true;
            }
        }
        private void FormAdicionarCliente_Load(object sender, EventArgs e)
        {
            
        }       
    }
}
