using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAlterarAcervo : Form
    {
        private readonly IAcervoCamadaNegocio acervoCamadaNegocio = new AcervoCamadaNegocio();
        private Acervo acervo = new Acervo();
        public FormAlterarAcervo(int CodigoAcervo)
        {
            InitializeComponent();
            PreencherCampoCbCategoriaAcervo();
            PreencherCampoCbFormatoAcervo();
            ObterAcervoPorCodigo(CodigoAcervo);
            AutoCompletarTxtIdioma();
            AutoCompletarTxtAutor();
            AutoCompletarTxtEditora();
        }
        private void ObterAcervoPorCodigo(int CodigoAcervo)
        {
            if (CodigoAcervo > 0)
            {
                acervo = acervoCamadaNegocio.ObterAcervo(CodigoAcervo);
                txtTituloAcervo.Text = acervo.TituloAcervo;
                cbCategoriaAcervo.Text = acervo.Categoria.NomeCategoria.ToString();
                txtCDDAcervo.Text = acervo.CDDAcervo;
                cbFormatoAcervo.Text = acervo.Formato.NomeFormato;
                txtIdiomaAcervo.Text = acervo.IdiomaAcervo;
                txtAnoPublicacao.Text = acervo.AnoPublicacaoAcervo.ToString();
                txtAutorAcervo.Text = acervo.AutorAcervo;
                txtEditoraAcervo.Text = acervo.EditoraAcervo;
                txtISBNAcervo.Text = acervo.ISBNAcervo;
                txtLocalizacaoAcervo.Text = acervo.LocalizacaoAcervo;
                txtQuantidadeAcervo.Text = acervo.QuantidadeAcervo.ToString();
                acervo.QuantidadeAnteriorAcervo = acervo.QuantidadeAcervo;
            }
        }
        private void PreencherCampoCbCategoriaAcervo()
        {
            ICategoriaCamadaNegocio categoriaCamadaNegocio = new CategoriaCamadaNegocio();
            cbCategoriaAcervo.DataSource = categoriaCamadaNegocio.ObterTodasCategorias();
            cbCategoriaAcervo.ValueMember = "CodigoCategoria";
            cbCategoriaAcervo.DisplayMember = "NomeCategoria";
            cbCategoriaAcervo.Update();
            LimparCampoCbCategoriaAcervo();
        }
        private void LimparCampoCbCategoriaAcervo()
        {
            cbCategoriaAcervo.Text = "";
            cbCategoriaAcervo.SelectedValue = 0;
        }
        private void PreencherCampoCbFormatoAcervo()
        {
            IFormatoCamadaNegocio formatoCamadaNegocio = new FormatoCamadaNegocio();
            cbFormatoAcervo.DataSource = formatoCamadaNegocio.ObterTodosFormatos();
            cbFormatoAcervo.ValueMember = "CodigoFormato";
            cbFormatoAcervo.DisplayMember = "NomeFormato";
            cbFormatoAcervo.Update();
            LimparCampoCbFormatoAcervo();
        }
        private void LimparCampoCbFormatoAcervo()
        {
            cbFormatoAcervo.Text = "";
            cbFormatoAcervo.SelectedValue = 0;
        }
        private void AutoCompletarTxtIdioma()
        {
            // Criar uma coleção de sugestões
            AutoCompleteStringCollection sugestao = new AutoCompleteStringCollection();

            // Obter a lista de objetos do acervo
            var lista = acervoCamadaNegocio.ObterTodosAcervos();

            // Converter a lista de objetos em uma lista de strings 
            var nomesIdiomas = lista.Select(acervo => acervo.IdiomaAcervo).ToArray(); // Extrair os nomes

            // Adicionar a lista de strings ao AutoCompleteCustomSource
            sugestao.AddRange(nomesIdiomas);

            // Definir a coleção de sugestões no TextBox
            txtIdiomaAcervo.AutoCompleteCustomSource = sugestao;
        }
        private void AutoCompletarTxtAutor()
        {
            // Criar uma coleção de sugestões
            AutoCompleteStringCollection sugestao = new AutoCompleteStringCollection();

            // Obter a lista de objetos do acervo
            var lista = acervoCamadaNegocio.ObterTodosAcervos();

            // Converter a lista de objetos em uma lista de strings 
            var nomesAutores = lista.Select(acervo => acervo.AutorAcervo).ToArray(); // Extrair os nomes

            // Adicionar a lista de strings ao AutoCompleteCustomSource
            sugestao.AddRange(nomesAutores);

            // Definir a coleção de sugestões no TextBox
            txtAutorAcervo.AutoCompleteCustomSource = sugestao;
        }
        private void AutoCompletarTxtEditora()
        {
            // Criar uma coleção de sugestões
            AutoCompleteStringCollection sugestao = new AutoCompleteStringCollection();

            // Obter a lista de objetos do acervo
            var lista = acervoCamadaNegocio.ObterTodosAcervos();

            // Converter a lista de objetos em uma lista de strings 
            var nomesEditoras = lista.Select(acervo => acervo.EditoraAcervo).ToArray(); // Extrair os nomes

            // Adicionar a lista de strings ao AutoCompleteCustomSource
            sugestao.AddRange(nomesEditoras);

            // Definir a coleção de sugestões no TextBox
            txtEditoraAcervo.AutoCompleteCustomSource = sugestao;
        }
        private bool IsValid()
        {
            if (txtTituloAcervo.Text == null || string.IsNullOrEmpty(txtTituloAcervo.Text))
            {
                MessageBox.Show("Informe o Título", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (cbCategoriaAcervo.Text == null || string.IsNullOrEmpty(cbCategoriaAcervo.Text))
            {
                MessageBox.Show("Informe a Categoria", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (cbFormatoAcervo.Text == null || string.IsNullOrEmpty(cbFormatoAcervo.Text))
            {
                MessageBox.Show("Informe o Formato", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtAutorAcervo.Text == null || string.IsNullOrEmpty(txtAutorAcervo.Text))
            {
                MessageBox.Show("Informe o Autor", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtEditoraAcervo.Text == null || string.IsNullOrEmpty(txtEditoraAcervo.Text))
            {
                MessageBox.Show("Informe a Editora", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtQuantidadeAcervo.Text == null || string.IsNullOrEmpty(txtQuantidadeAcervo.Text))
            {
                MessageBox.Show("Informe a Quantidade", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void FormAlterarAcervo_Load(object sender, EventArgs e)
        {

        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    acervo.TituloAcervo = txtTituloAcervo.Text;
                    acervo.Categoria.CodigoCategoria = int.Parse(cbCategoriaAcervo.SelectedValue.ToString());
                    acervo.CDDAcervo = txtCDDAcervo.Text;
                    acervo.Formato.CodigoFormato = int.Parse(cbFormatoAcervo.SelectedValue.ToString());
                    acervo.IdiomaAcervo = txtIdiomaAcervo.Text;
                    acervo.AutorAcervo = txtAutorAcervo.Text;
                    acervo.EditoraAcervo = txtEditoraAcervo.Text;
                    acervo.AnoPublicacaoAcervo = int.Parse(txtAnoPublicacao.Text);
                    acervo.ISBNAcervo = txtISBNAcervo.Text;
                    acervo.LocalizacaoAcervo = txtLocalizacaoAcervo.Text;
                    acervo.QuantidadeAcervo = int.Parse(txtQuantidadeAcervo.Text);
                    acervoCamadaNegocio.AtualizarAcervo(acervo);
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
