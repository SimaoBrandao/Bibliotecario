using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormDevolucao : Form
    {
        private readonly IEmprestimoCamadaNegocio emprestimoCamadaNegocio = new EmprestimoCamadaNegocio();
        private Emprestimo emprestimo = new Emprestimo();
        public FormDevolucao(int CodigoEmprestimo)
        {
            InitializeComponent();
            ObterEmprestimoPorCodigo(CodigoEmprestimo);
        }
        private void ObterEmprestimoPorCodigo(int CodigoEmprestimo)
        {
            if (CodigoEmprestimo > 0)
            {
                emprestimo = emprestimoCamadaNegocio.ObterEmprestimoPorCodigo(CodigoEmprestimo);
                txtNomeCliente.Text = emprestimo.Cliente.NomeCliente;
                txtTituloAcervo.Text = emprestimo.Acervo.TituloAcervo;
                txtDataEmprestimo.Text = emprestimo.DataEmprestimo.ToString();
            }
        }
       
        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                emprestimo.DataRealDevolucaoEmprestimo = dtpDataRealDevolucaoEmprestimo.Value;
                emprestimoCamadaNegocio.DevolucaoEmprestimo(emprestimo);
                MessageBox.Show("Empréstimo devolvido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormDevolucao_Load(object sender, EventArgs e)
        {

        }
       
    }
}
