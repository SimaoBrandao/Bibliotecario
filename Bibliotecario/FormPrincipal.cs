using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormPrincipal : Form
    {
        private readonly IUtilizadorCamadaNegocio utilizadorCamadaNegocio = new UtilizadorCamadaNegocio();
        private DialogResult res;
        public FormPrincipal()
        {
            InitializeComponent();
            ObterNomeDoUtilizadorLogado();
        }
        private void ObterNomeDoUtilizadorLogado()
        {
            UtilizadorLogadoToolStripMenuItem.Text = utilizadorCamadaNegocio.ObterUtilizadorPorCodigo(Utilizador.CodigoUtilizadorLogado).NomeUtilizador;
        }
       
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // vamos interceptar o fechamento do formulário. 
            // Não interceptamos o fechamento do formulário quando o utilizador estiver a terminar a sessão.            
            if (Utilizador.CodigoUtilizadorLogado > 0)
            {
                // perguntar se o usuário deseja mesmo fechar.
                res = MessageBox.Show("Deseja terminar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void TerminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reiniciar a aplicação 
            Utilizador.CodigoUtilizadorLogado = 0;
            Application.Restart();
            //fecha o formulario actual
            this.Close();
        }

        private void AcercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Simão Brandão. \nSistema de Gestão de Biblioteca 1.0.\n\nE-mail: sibrandao2008@gmail.com \nTelefone: 948493828 / WhatsApp: 948493828", "Acerca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }       
        private void minhaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMinhaConta form = new FormMinhaConta();
            form.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarCliente form = new FormConsultarCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void UtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarUtilizador form = new FormConsultarUtilizador();
            form.MdiParent = this;
            form.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarCategoria form = new FormConsultarCategoria();
            form.MdiParent = this;
            form.Show();
        }

        private void formatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarFormato form = new FormConsultarFormato();
            form.MdiParent = this;
            form.Show();
        }       

        private void acervosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarAcervo form = new FormConsultarAcervo();
            form.MdiParent = this;
            form.Show();
        }        

        private void EmpréstimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarEmprestimo form = new FormConsultarEmprestimo();
            form.MdiParent = this;
            form.Show();
        }

        private void modalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarModalidade form = new FormConsultarModalidade();
            form.MdiParent = this;
            form.Show();
        }

        private void bibliotecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBiblioteca form = new FormBiblioteca();
            form.ShowDialog();
        }

        private void copiaDeSegurançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBackup form = new FormBackup();
            form.ShowDialog();
        }

        private void reposicaoCopiaDeSegurancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRestore form = new FormRestore();
            form.ShowDialog();
        }
    }
}
