namespace Bibliotecario
{
    partial class FormMinhaConta
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailUtilizador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.bntConfirmar = new System.Windows.Forms.Button();
            this.txtNomeUtilizador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.bntAlterarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 114;
            this.label3.Text = "Permissão:";
            // 
            // txtEmailUtilizador
            // 
            this.txtEmailUtilizador.Enabled = false;
            this.txtEmailUtilizador.Location = new System.Drawing.Point(143, 40);
            this.txtEmailUtilizador.Name = "txtEmailUtilizador";
            this.txtEmailUtilizador.Size = new System.Drawing.Size(276, 23);
            this.txtEmailUtilizador.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 110;
            this.label4.Text = "E-mail:";
            // 
            // bntCancelar
            // 
            this.bntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancelar.Location = new System.Drawing.Point(456, 165);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 5;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // bntConfirmar
            // 
            this.bntConfirmar.Location = new System.Drawing.Point(378, 165);
            this.bntConfirmar.Name = "bntConfirmar";
            this.bntConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bntConfirmar.TabIndex = 4;
            this.bntConfirmar.Text = "Confirmar";
            this.bntConfirmar.UseVisualStyleBackColor = true;
            this.bntConfirmar.Click += new System.EventHandler(this.bntConfirmar_Click);
            // 
            // txtNomeUtilizador
            // 
            this.txtNomeUtilizador.Location = new System.Drawing.Point(143, 10);
            this.txtNomeUtilizador.MaxLength = 50;
            this.txtNomeUtilizador.Name = "txtNomeUtilizador";
            this.txtNomeUtilizador.Size = new System.Drawing.Size(388, 23);
            this.txtNomeUtilizador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 106;
            this.label1.Text = "Nome:";
            // 
            // cbPerfil
            // 
            this.cbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerfil.Enabled = false;
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(143, 72);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(276, 23);
            this.cbPerfil.TabIndex = 115;
            this.cbPerfil.TabStop = false;
            // 
            // bntAlterarSenha
            // 
            this.bntAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntAlterarSenha.Location = new System.Drawing.Point(143, 108);
            this.bntAlterarSenha.Name = "bntAlterarSenha";
            this.bntAlterarSenha.Size = new System.Drawing.Size(96, 27);
            this.bntAlterarSenha.TabIndex = 3;
            this.bntAlterarSenha.Text = "Alterar senha";
            this.bntAlterarSenha.UseVisualStyleBackColor = true;
            this.bntAlterarSenha.Click += new System.EventHandler(this.BntAlterarSenha_Click);
            // 
            // FormMinhaConta
            // 
            this.AcceptButton = this.bntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.bntCancelar;
            this.ClientSize = new System.Drawing.Size(552, 202);
            this.Controls.Add(this.bntAlterarSenha);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailUtilizador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntConfirmar);
            this.Controls.Add(this.txtNomeUtilizador);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMinhaConta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha conta";
            this.Activated += new System.EventHandler(this.FormMinhaConta_Activated);
            this.Load += new System.EventHandler(this.FormMinhaConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailUtilizador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button bntConfirmar;
        private System.Windows.Forms.TextBox txtNomeUtilizador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.Button bntAlterarSenha;
    }
}