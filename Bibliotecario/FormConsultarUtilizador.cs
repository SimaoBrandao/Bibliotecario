using CamadaEntidade;
using CamadaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormConsultarUtilizador : Form
    {
        private readonly IUtilizadorCamadaNegocio utilizadorCamadaNegocio = new UtilizadorCamadaNegocio();
        Utilizador utilizador = new Utilizador();
        public FormConsultarUtilizador()
        {
            InitializeComponent();
        }
        private void PreencherDataGridView()
        {
            try
            {
                DataGridView.DataSource = utilizadorCamadaNegocio.ObterTodosUtilizador().Select(x => new
                {
                    x.CodigoUtilizador,
                    x.NomeUtilizador,
                    x.EmailUtilizador,
                    x.Perfil.NomePerfil,
                    x.EstadoUtilizador
                })
                .ToList();

                FormatarDataGridView();
                ContarRegistoNoDataGridView();
            }
            catch(Exception ex)
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
            DataGridView.Columns[1].HeaderText = "Nome";
            DataGridView.Columns[2].HeaderText = "E-mail";
            DataGridView.Columns[3].HeaderText = "Permissão";
            DataGridView.Columns[4].HeaderText = "Estado";
        }
        private void BntAdicionarUtilizador_Click(object sender, EventArgs e)
        {
            FormAdicionarUtilizador form = new FormAdicionarUtilizador();
            form.ShowDialog();
            PreencherDataGridView();
        }
        private void BntExcluirUtilizador_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Deseja excluir o Utilizador?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    utilizadorCamadaNegocio.ExcluirUtilizador(utilizador.CodigoUtilizador);
                    PreencherDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormConsultarUtilizador_Load(object sender, EventArgs e)
        {

        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter célula selecionada
            // é um cabeçalho ?
            if (e.RowIndex > -1)
            {
                // não
                utilizador.CodigoUtilizador = 0;
                utilizador.CodigoUtilizador = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
        
        private void FormConsultarUtilizador_Activated(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Deseja excluir o Utilizador?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    utilizadorCamadaNegocio.ExcluirUtilizador(utilizador.CodigoUtilizador);
                    PreencherDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       

        private void redefinirSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Deseja Redifinir a Senha do Utilizador?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    utilizadorCamadaNegocio.RedefinirSenhaUtilizador(utilizador.CodigoUtilizador);
                    MessageBox.Show("Senha redefinida com sucesso. Foi enviado um e-mail no utilizador contendo a nova senha.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PreencherDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }        

        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Deseja Bloquear o Utilizador?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    utilizadorCamadaNegocio.BloquearUtilizador(utilizador.CodigoUtilizador);
                    MessageBox.Show("Utilizador bloqueado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PreencherDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void desbloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Deseja Desbloquear o Utilizador?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    utilizadorCamadaNegocio.DesbloquearUtilizador(utilizador.CodigoUtilizador);
                    MessageBox.Show("Utilizador desbloqueado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PreencherDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bntAlterarUtilizador_Click(object sender, EventArgs e)
        {
            try
            {
                if (utilizador.CodigoUtilizador > 0)
                {
                    FormAlterarUtilizador form = new FormAlterarUtilizador(utilizador.CodigoUtilizador);
                    form.ShowDialog();
                    PreencherDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
