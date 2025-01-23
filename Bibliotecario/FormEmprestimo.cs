using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormEmprestimo : Form
    {
        private readonly IEmprestimoCamadaNegocio emprestimoCamadaNegocio = new EmprestimoCamadaNegocio();
        private Cliente cliente = new Cliente();
        private Acervo acervo = new Acervo();
        public FormEmprestimo()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtTituloAcervo.Text = "";
            txtTituloAcervo.Focus();
        }
        private void ObterClientePorCodigo(int CodigoCliente)
        {
            if (CodigoCliente > 0)
            {
                IClienteCamadaNegocio clienteCamadaNegocio = new ClienteCamadaNegocio();
                cliente.CodigoCliente = 0;
                cliente = clienteCamadaNegocio.ObterClientePorCodigo(CodigoCliente);
                txtNomeCliente.Text = cliente.NomeCliente;
            }
        }
        private void ObterAcervo(int CodigoAcervo)
        {
            if (CodigoAcervo > 0)
            {
                IAcervoCamadaNegocio acervoCamadaNegocio = new AcervoCamadaNegocio();
                acervo.CodigoAcervo = 0;
                acervo = acervoCamadaNegocio.ObterAcervo(CodigoAcervo);
                txtTituloAcervo.Text = acervo.TituloAcervo;
            }
        }
        private void FormAdicionarEmprestimo_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    Emprestimo emprestimo = new Emprestimo();
                    emprestimo.Cliente.CodigoCliente = cliente.CodigoCliente;
                    emprestimo.Acervo.CodigoAcervo = acervo.CodigoAcervo;
                    emprestimo.DataEmprestimo = dtpDataEmprestimo.Value;
                    emprestimo.DataPrevistaDevolucaoEmprestimo = dtpDataPrevistaDevolucao.Value;
                    emprestimoCamadaNegocio.AdicionarEmprestimo(emprestimo);
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
                MessageBox.Show("Informe o Cliente", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtTituloAcervo.Text == null || string.IsNullOrEmpty(txtTituloAcervo.Text))
            {
                MessageBox.Show("Informe o Acervo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }            
            else
            {
                return true;
            }
        }

        private void bntLocalizarCliente_Click(object sender, EventArgs e)
        {
            Cliente.CodigoClienteTransferencia = 0;
            FormLocalizarCliente form = new FormLocalizarCliente();
            form.ShowDialog();
            ObterClientePorCodigo(Cliente.CodigoClienteTransferencia);
        }

        private void bntLocalizarAcervo_Click(object sender, EventArgs e)
        {
            Acervo.CodigoAcervoTransferencia = 0;
            FormLocalizarAcervo form = new FormLocalizarAcervo();
            form.ShowDialog();
            ObterAcervo(Acervo.CodigoAcervoTransferencia);
        }
    }
}
