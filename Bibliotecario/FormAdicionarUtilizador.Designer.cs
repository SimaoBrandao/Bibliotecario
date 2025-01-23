namespace Bibliotecario
{
    partial class FormAdicionarUtilizador
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
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailUtilizador = new System.Windows.Forms.TextBox();
            this.txtSenhaUtilizador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.bntConfirmar = new System.Windows.Forms.Button();
            this.txtNomeUtilizador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPerfil
            // 
            this.cbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(159, 71);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(276, 23);
            this.cbPerfil.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 116;
            this.label3.Text = "Perfil:";
            // 
            // txtEmailUtilizador
            // 
            this.txtEmailUtilizador.Location = new System.Drawing.Point(159, 42);
            this.txtEmailUtilizador.Name = "txtEmailUtilizador";
            this.txtEmailUtilizador.Size = new System.Drawing.Size(276, 23);
            this.txtEmailUtilizador.TabIndex = 2;
            // 
            // txtSenhaUtilizador
            // 
            this.txtSenhaUtilizador.Location = new System.Drawing.Point(159, 100);
            this.txtSenhaUtilizador.Name = "txtSenhaUtilizador";
            this.txtSenhaUtilizador.Size = new System.Drawing.Size(276, 23);
            this.txtSenhaUtilizador.TabIndex = 4;
            this.txtSenhaUtilizador.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 113;
            this.label2.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 112;
            this.label4.Text = "E-mail:";
            // 
            // bntCancelar
            // 
            this.bntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancelar.Location = new System.Drawing.Point(494, 207);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 6;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // bntConfirmar
            // 
            this.bntConfirmar.Location = new System.Drawing.Point(416, 207);
            this.bntConfirmar.Name = "bntConfirmar";
            this.bntConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bntConfirmar.TabIndex = 5;
            this.bntConfirmar.Text = "Confirmar";
            this.bntConfirmar.UseVisualStyleBackColor = true;
            this.bntConfirmar.Click += new System.EventHandler(this.bntConfirmar_Click);
            // 
            // txtNomeUtilizador
            // 
            this.txtNomeUtilizador.Location = new System.Drawing.Point(159, 13);
            this.txtNomeUtilizador.MaxLength = 50;
            this.txtNomeUtilizador.Name = "txtNomeUtilizador";
            this.txtNomeUtilizador.Size = new System.Drawing.Size(410, 23);
            this.txtNomeUtilizador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 108;
            this.label1.Text = "Nome:";
            // 
            // FormAdicionarUtilizador
            // 
            this.AcceptButton = this.bntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.bntCancelar;
            this.ClientSize = new System.Drawing.Size(585, 242);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailUtilizador);
            this.Controls.Add(this.txtSenhaUtilizador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntConfirmar);
            this.Controls.Add(this.txtNomeUtilizador);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdicionarUtilizador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Utilizador";
            this.Activated += new System.EventHandler(this.FormAdicionarUtilizador_Activated);
            this.Load += new System.EventHandler(this.FormAdicionarUtilizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailUtilizador;
        private System.Windows.Forms.TextBox txtSenhaUtilizador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button bntConfirmar;
        private System.Windows.Forms.TextBox txtNomeUtilizador;
        private System.Windows.Forms.Label label1;
    }
}