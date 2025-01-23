using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormConsultarEmprestimo : Form
    {
        private readonly IEmprestimoCamadaNegocio emprestimoCamadaNegocio = new EmprestimoCamadaNegocio();
        private Emprestimo emprestimo = new Emprestimo();
        public FormConsultarEmprestimo()
        {
            InitializeComponent();
            ObterTodosEmprestimo();
            cbFiltro.SelectedIndex = 0;
        }
        private void PreencherDataGridView()
        {
            DataGridView.DataSource = emprestimo.ListaEmprestimo.Select(x => new
            {
                x.CodigoEmprestimo,
                x.Cliente.NomeCliente,
                x.Acervo.TituloAcervo,
                x.DataEmprestimo,
                x.DataPrevistaDevolucaoEmprestimo,
                x.DataRealDevolucaoEmprestimo,
                x.EstadoEmprestimo
            })
            .ToList();

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
            DataGridView.Columns[1].HeaderText = "Cliente";
            DataGridView.Columns[2].HeaderText = "Título";
            DataGridView.Columns[3].HeaderText = "Empréstimo";
            DataGridView.Columns[4].HeaderText = "Devolução";
            DataGridView.Columns[5].HeaderText = "Entregue Em";
            DataGridView.Columns[6].HeaderText = "Estado";
        }
        private void ObterTodosEmprestimo()
        {
            try
            {
                emprestimo.ListaEmprestimo = emprestimoCamadaNegocio.ObterTodosEmprestimo();
                PreencherDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Consultar()
        {
            try
            {
                if (cbFiltro.SelectedIndex == 0 || string.IsNullOrEmpty(txtConsulta.Text))
                {
                    //Localizar todos empréstimos
                    ObterTodosEmprestimo();
                }
                else if (cbFiltro.SelectedIndex == 1 && txtConsulta.Text != "")
                {
                    //Localizar por nome cliente
                    emprestimo.ListaEmprestimo = emprestimoCamadaNegocio.ObterEmprestimoPorNomeCliente(txtConsulta.Text);
                    PreencherDataGridView();
                }
                else if (cbFiltro.SelectedIndex == 2 && txtConsulta.Text != "")
                {
                    //Localizar por codigo acervo
                    emprestimo.ListaEmprestimo = emprestimoCamadaNegocio.ObterEmprestimoPorCDDAcervo(int.Parse(txtConsulta.Text));
                    PreencherDataGridView();
                }
                else if (cbFiltro.SelectedIndex == 3 && txtConsulta.Text != "")
                {
                    //Localizar por titulo acervo
                    emprestimo.ListaEmprestimo = emprestimoCamadaNegocio.ObterEmprestimoPorTituloAcervo(txtConsulta.Text);
                    PreencherDataGridView();
                }
                else if (cbFiltro.SelectedIndex == 4 && txtConsulta.Text != "")
                {
                    //Localizar por data
                    emprestimo.ListaEmprestimo = emprestimoCamadaNegocio.ObterEmprestimoPorDataEmprestimo(DateTime.Parse(txtConsulta.Text));
                    PreencherDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void FormConsultarEmprestimo_Load(object sender, EventArgs e)
        {

        }       

        private void FormConsultarEmprestimo_Activated(object sender, EventArgs e)
        {
            Consultar();
        }

        private void BntAdicionarEmprestimo_Click(object sender, EventArgs e)
        {
            FormEmprestimo form = new FormEmprestimo();
            form.ShowDialog();
            Consultar();
        }

        private void bntDevoluçãoEmprestimo_Click(object sender, EventArgs e)
        {
            if(emprestimo.CodigoEmprestimo > 0)
            {
                FormDevolucao form = new FormDevolucao(emprestimo.CodigoEmprestimo);
                form.ShowDialog();
                emprestimo.CodigoEmprestimo = 0;
                Consultar();
            }
            else
            {
                MessageBox.Show("Selecione um acervo para devolução. ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter célula selecionada
            // é um cabeçalho ?
            if (e.RowIndex > -1)
            {
                // não
                emprestimo.CodigoEmprestimo = 0;
                emprestimo.CodigoEmprestimo = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());   
            }
        } 

        private void bntPesquizarEmprestimo_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        private void anularDevolucaoAcervoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (emprestimo.CodigoEmprestimo > 0)
                {
                    DialogResult res = MessageBox.Show("Tem certeza que deseja anular a devolução?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        emprestimoCamadaNegocio.AnularDevolucaoEmprestimo(emprestimo.CodigoEmprestimo);
                        MessageBox.Show("A devolução foi a anulada com sucesso. ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Consultar();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Selecione um acervo para anular a devolução. ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

       
    }
}
