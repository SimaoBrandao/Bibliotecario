using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormConsultarAcervo : Form
    {
        private readonly IAcervoCamadaNegocio acervoCamadaNegocio = new AcervoCamadaNegocio();
        private Acervo acervo = new Acervo();
        public FormConsultarAcervo()
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0;
        }
        private void PreencherDataGridView()
        {
            DataGridView.DataSource = acervo.ListaAcervos.Select(x => new
            {
                x.CodigoAcervo,
                x.CDDAcervo,
                x.TituloAcervo,
                x.Categoria.NomeCategoria,
                x.LocalizacaoAcervo
            })
            .ToList();

            FormatarDataGridView();
            ContarRegistoNoDataGridView();
        }
        private void ObterTodosAcervos()
        {
            try
            {
                acervo.ListaAcervos = acervoCamadaNegocio.ObterTodosAcervos();
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
                    ObterTodosAcervos();
                }
                else if (cbFiltro.SelectedIndex == 1 && txtConsulta.Text != "")
                {
                    //Localizar codigoAcervo
                    acervo.ListaAcervos = acervoCamadaNegocio.ObterAcervoPorCDD(txtConsulta.Text);
                    PreencherDataGridView();
                }
                else if (cbFiltro.SelectedIndex == 2 && txtConsulta.Text != "")
                {
                    //Localizar titulo
                    acervo.ListaAcervos = acervoCamadaNegocio.ObterAcervoPorTitulo(txtConsulta.Text);
                    PreencherDataGridView();
                }
                else if (cbFiltro.SelectedIndex == 3 && txtConsulta.Text != "")
                {
                    //Localizar por nomeCategoria
                    acervo.ListaAcervos = acervoCamadaNegocio.ObterAcervoPorNomeCategoria(txtConsulta.Text);
                    PreencherDataGridView();
                }
                else if (cbFiltro.SelectedIndex == 4 && txtConsulta.Text != "")
                {
                    //Localizar por nomeCategoria
                    acervo.ListaAcervos = acervoCamadaNegocio.ObterAcervoPorLocalizacao(txtConsulta.Text);
                    PreencherDataGridView();
                }
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
            DataGridView.Columns[2].HeaderText = "Título";
            DataGridView.Columns[3].HeaderText = "Categoria";
            DataGridView.Columns[4].HeaderText = "Localização";          

        }

        private void FormConsultarAcervo_Load(object sender, EventArgs e)
        {

        }

        private void BntAdicionarAcervo_Click(object sender, EventArgs e)
        {
            FormAdicionarAcervo form = new FormAdicionarAcervo();
            form.ShowDialog();
            ObterTodosAcervos();
        }

        private void BntExcluirAcervo_Click(object sender, EventArgs e)
        {
            if(acervo.CodigoAcervo > 0)
            {
                DialogResult res = MessageBox.Show("Deseja excluir o Acervo?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    acervoCamadaNegocio.ExcluirAcervo(acervo.CodigoAcervo);
                    Consultar();
                }
            }
            else
            {
                MessageBox.Show("Selecione um acervo para excluir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void FormConsultarAcervo_Activated(object sender, EventArgs e)
        {
            ObterTodosAcervos();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter célula selecionada
            // é um cabeçalho ?
            if (e.RowIndex > -1)
            {
                // não
                acervo.CodigoAcervo = 0;
                acervo.CodigoAcervo = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());               
            }

        }        

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }

        private void bntAlterarAcervo_Click(object sender, EventArgs e)
        {           
            if (acervo.CodigoAcervo > 0)
            {
                // não
                FormAlterarAcervo form = new FormAlterarAcervo(acervo.CodigoAcervo);
                form.ShowDialog();
                Consultar();
            }
            else
            {
                MessageBox.Show("Selecione um acervo para alterar", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bntPesquizarAcervo_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void cbFiltro_DropDownClosed(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
