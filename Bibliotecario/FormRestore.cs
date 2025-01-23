using CamadaNegocio;
using System;
using System.IO;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormRestore : Form
    {
        private readonly IBackupCamadaNegocio backupCamadaNegocio = new BackupCamadaNegocio();
        public FormRestore()
        {
            InitializeComponent();
        }

        private void FormRestore_Load(object sender, EventArgs e)
        {

        }

        private void bntConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string caminhoBackup = txtCaminhoBackup.Text;

                if (!File.Exists(caminhoBackup))
                {
                    MessageBox.Show("O caminho do backup não é válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                    
                    backupCamadaNegocio.RestaurarBackup(caminhoBackup);
                    MessageBox.Show("Reposição da cópia de segurança realizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void bntSelecionarCaminhoBackup_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Abrir Arquivo SQL";
                openFileDialog.Filter = "Arquivos SQL (*.sql)|*.sql"; // Apenas arquivos .sql
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = false; // Permite selecionar apenas um arquivo
                openFileDialog.CheckFileExists = true; // Garante que o arquivo exista
                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCaminhoBackup.Text = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Nenhum arquivo foi selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
