namespace Bibliotecario
{
    partial class FormBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntBackup = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminhoBackup = new System.Windows.Forms.TextBox();
            this.bntSelecionarCaminhoBackup = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntBackup
            // 
            this.bntBackup.Location = new System.Drawing.Point(335, 79);
            this.bntBackup.Name = "bntBackup";
            this.bntBackup.Size = new System.Drawing.Size(75, 23);
            this.bntBackup.TabIndex = 2;
            this.bntBackup.Text = "Confirmar";
            this.bntBackup.UseVisualStyleBackColor = true;
            this.bntBackup.Click += new System.EventHandler(this.bntBackup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho do backup:";
            // 
            // txtCaminhoBackup
            // 
            this.txtCaminhoBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCaminhoBackup.Location = new System.Drawing.Point(136, 17);
            this.txtCaminhoBackup.Name = "txtCaminhoBackup";
            this.txtCaminhoBackup.ReadOnly = true;
            this.txtCaminhoBackup.Size = new System.Drawing.Size(319, 23);
            this.txtCaminhoBackup.TabIndex = 2;
            this.txtCaminhoBackup.TabStop = false;
            // 
            // bntSelecionarCaminhoBackup
            // 
            this.bntSelecionarCaminhoBackup.Location = new System.Drawing.Point(458, 17);
            this.bntSelecionarCaminhoBackup.Name = "bntSelecionarCaminhoBackup";
            this.bntSelecionarCaminhoBackup.Size = new System.Drawing.Size(29, 23);
            this.bntSelecionarCaminhoBackup.TabIndex = 1;
            this.bntSelecionarCaminhoBackup.Text = "...";
            this.bntSelecionarCaminhoBackup.UseVisualStyleBackColor = true;
            this.bntSelecionarCaminhoBackup.Click += new System.EventHandler(this.bntSelecionarCaminhoBackup_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancelar.Location = new System.Drawing.Point(412, 79);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 3;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // FormBackup
            // 
            this.AcceptButton = this.bntBackup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.bntCancelar;
            this.ClientSize = new System.Drawing.Size(503, 114);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntSelecionarCaminhoBackup);
            this.Controls.Add(this.txtCaminhoBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntBackup);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cópia de Segurança";
            this.Load += new System.EventHandler(this.FormBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntBackup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminhoBackup;
        private System.Windows.Forms.Button bntSelecionarCaminhoBackup;
        private System.Windows.Forms.Button bntCancelar;
    }
}