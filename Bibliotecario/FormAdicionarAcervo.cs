using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormAdicionarAcervo : Form
    {
        private readonly IAcervoCamadaNegocio acervoCamadaNegocio = new AcervoCamadaNegocio();
        public FormAdicionarAcervo()
        {
            InitializeComponent();
            PreencherCampoCbCategoriaAcervo();
            PreencherCampoCbFormatoAcervo();
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtTituloAcervo.Text = "";
            txtCDDAcervo.Text = "";
            LimparCampoCbCategoriaAcervo();
            LimparCampoCbFormatoAcervo();
            txtAnoPublicacao.Text = "";
            txtISBNAcervo.Text = "";
            txtQuantidadeAcervo.Text = "";
            txtAutorAcervo.Text = "";
            txtIdiomaAcervo.Text = "";
            txtEditoraAcervo.Text = "";
            txtLocalizacaoAcervo.Text = "";
            txtTituloAcervo.Focus();
            AutoCompletarTxtIdioma();
            AutoCompletarTxtAutor();
            AutoCompletarTxtEditora();
        }

        private void AutoCompletarTxtIdioma()
        {
            // Criar uma coleção de sugestões
            AutoCompleteStringCollection sugestao = new AutoCompleteStringCollection();

            // Obter a lista de objetos do acervo
            var lista = acervoCamadaNegocio.ObterTodosAcervos();

            // Converter a lista de objetos em uma lista de strings 
            var idiomas = lista.Select(acervo => acervo.IdiomaAcervo).ToArray(); // Extrair os nomes

            // Adicionar a lista de strings ao AutoCompleteCustomSource
            sugestao.AddRange(idiomas);

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
            var autores = lista.Select(acervo => acervo.AutorAcervo).ToArray(); // Extrair os nomes

            // Adicionar a lista de strings ao AutoCompleteCustomSource
            sugestao.AddRange(autores);

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
            var editoras = lista.Select(acervo => acervo.EditoraAcervo).ToArray(); // Extrair os nomes

            // Adicionar a lista de strings ao AutoCompleteCustomSource
            sugestao.AddRange(editoras);

            // Definir a coleção de sugestões no TextBox
            txtEditoraAcervo.AutoCompleteCustomSource = sugestao;
        }
        private void PreencherCampoCbCategoriaAcervo()
        {
            try
            {
                ICategoriaCamadaNegocio categoriaCamadaNegocio = new CategoriaCamadaNegocio();
                cbCategoriaAcervo.DataSource = categoriaCamadaNegocio.ObterTodasCategorias();
                cbCategoriaAcervo.ValueMember = "CodigoCategoria";
                cbCategoriaAcervo.DisplayMember = "NomeCategoria";
                cbCategoriaAcervo.Update();
                LimparCampoCbCategoriaAcervo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }
        private void LimparCampoCbCategoriaAcervo()
        {
            cbCategoriaAcervo.Text = "";
            cbCategoriaAcervo.SelectedValue = 0;
        }
        private void PreencherCampoCbFormatoAcervo()
        {
            try
            {
                IFormatoCamadaNegocio formatoCamadaNegocio = new FormatoCamadaNegocio();
                cbFormatoAcervo.DataSource = formatoCamadaNegocio.ObterTodosFormatos();
                cbFormatoAcervo.ValueMember = "CodigoFormato";
                cbFormatoAcervo.DisplayMember = "NomeFormato";
                cbFormatoAcervo.Update();
                LimparCampoCbFormatoAcervo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LimparCampoCbFormatoAcervo()
        {
            cbFormatoAcervo.Text = "";
            cbFormatoAcervo.SelectedValue = 0;
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
            else if (txtIdiomaAcervo.Text == null || string.IsNullOrEmpty(txtIdiomaAcervo.Text))
            {
                MessageBox.Show("Informe o Idioma", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormAdicionarAcervo_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    Acervo acervo = new Acervo();
                    acervo.TituloAcervo = txtTituloAcervo.Text;
                    acervo.Categoria.CodigoCategoria = int.Parse(cbCategoriaAcervo.SelectedValue.ToString());
                    acervo.Formato.CodigoFormato = int.Parse(cbFormatoAcervo.SelectedValue.ToString());
                    acervo.CDDAcervo = txtCDDAcervo.Text;
                    acervo.IdiomaAcervo = txtIdiomaAcervo.Text;
                    acervo.AutorAcervo = txtAutorAcervo.Text;
                    acervo.EditoraAcervo = txtEditoraAcervo.Text;
                    acervo.AnoPublicacaoAcervo = int.Parse(txtAnoPublicacao.Text);
                    acervo.ISBNAcervo = txtISBNAcervo.Text;
                    acervo.LocalizacaoAcervo = txtLocalizacaoAcervo.Text;
                    acervo.QuantidadeAcervo = int.Parse(txtQuantidadeAcervo.Text);
                    acervoCamadaNegocio.AdicionarAcervo(acervo);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void cbCategoriaAcervo_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbCategoriaAcervo.Text))
                {
                    txtCDDAcervo.Text = acervoCamadaNegocio.GerarProximoCDD(int.Parse(cbCategoriaAcervo.SelectedValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
