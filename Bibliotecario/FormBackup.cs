using CamadaNegocio;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace Bibliotecario
{
    public partial class FormBackup : Form
    {
        private readonly IBackupCamadaNegocio backupCamadaNegocio = new BackupCamadaNegocio();
        public FormBackup()
        {
            InitializeComponent();

            // Carrega o caminho do backup do App.config
            txtCaminhoBackup.Text = ConfigurationManager.AppSettings["caminhoBackup"];
        }        

        private void bntBackup_Click(object sender, System.EventArgs e)
        {
            try
            {
                string caminhoBackup = txtCaminhoBackup.Text;

                if (!Directory.Exists(caminhoBackup))
                {
                    MessageBox.Show("O caminho do backup não é válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nomeFicheiroBackup = Path.Combine(caminhoBackup, $"Backup_{DateTime.Now:yyyyMMddHHmmss}.sql");
                    backupCamadaNegocio.FazerBackup(caminhoBackup);
                    MessageBox.Show("Backup realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bntSelecionarCaminhoBackup_Click(object sender, System.EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCaminhoBackup.Text = folderDialog.SelectedPath;
                    SalvarCaminhoBackupNoAppConfig("caminhoBackup", folderDialog.SelectedPath);
                }
            }
        }
        private void SalvarCaminhoBackupNoAppConfig(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void FormBackup_Load(object sender, EventArgs e)
        {

        }
    }
}
