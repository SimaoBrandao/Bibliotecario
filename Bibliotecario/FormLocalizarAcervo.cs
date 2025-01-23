using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormLocalizarAcervo : Form
    {
        private readonly IAcervoCamadaNegocio acervoCamadaNegocio = new AcervoCamadaNegocio();
        private Acervo acervo = new Acervo();
        public FormLocalizarAcervo()
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0;
            Consultar();
        }

        private void PreencherDataGridView()
        {
            DataGridView.DataSource = acervo.ListaAcervos.Select(x => new
            {
                x.CodigoAcervo,
                x.CDDAcervo,
                x.TituloAcervo,
                x.Categoria.NomeCategoria,
                x.LocalizacaoAcervo,
                x.EstadoAcervo
            })
            .ToList();

            FormatarDataGridView();
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
        private void FormatarDataGridView()
        {
            //formataGridView
            DataGridView.Columns[0].Visible = false;
            DataGridView.Columns[1].HeaderText = "CDD";
            DataGridView.Columns[2].HeaderText = "Título";
            DataGridView.Columns[3].HeaderText = "Categoria";
            DataGridView.Columns[4].HeaderText = "Localização";
            DataGridView.Columns[5].HeaderText = "Estado";
        }       

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter célula selecionada
            // é um cabeçalho ?
            if (e.RowIndex > -1)
            {
                // não
                Acervo.CodigoAcervoTransferencia = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (VerificarAcervoEmprestado(Acervo.CodigoAcervoTransferencia))
                {
                    Close();
                }                
            }
        }
        private bool VerificarAcervoEmprestado(int CodigoAcervo)
        {
            IEmprestimoCamadaNegocio emprestimoCamadaNegocio = new EmprestimoCamadaNegocio();
            
            if (CodigoAcervo > 0 && emprestimoCamadaNegocio.VerificarAcervoEmprestado(CodigoAcervo))
            {
                MessageBox.Show("O Acervo selecionado não está disponível", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void FormLocalizarAcervo_Load(object sender, EventArgs e)
        {
            
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
