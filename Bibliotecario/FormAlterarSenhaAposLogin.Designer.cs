namespace Bibliotecario
{
    partial class FormAlterarSenhaAposLogin
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
            this.BntConfirmar = new System.Windows.Forms.Button();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.txtsenhaActual = new System.Windows.Forms.TextBox();
            this.txtconfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtnovaSenha = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BntConfirmar
            // 
            this.BntConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BntConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BntConfirmar.Location = new System.Drawing.Point(259, 141);
            this.BntConfirmar.Name = "BntConfirmar";
            this.BntConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BntConfirmar.TabIndex = 4;
            this.BntConfirmar.Text = "Confirmar";
            this.BntConfirmar.Click += new System.EventHandler(this.BntConfirmar_Click);
            // 
            // BntCancelar
            // 
            this.BntCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BntCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BntCancelar.Location = new System.Drawing.Point(338, 141);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(75, 23);
            this.BntCancelar.TabIndex = 5;
            this.BntCancelar.Text = "Cancelar";
            // 
            // txtsenhaActual
            // 
            this.txtsenhaActual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsenhaActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenhaActual.Location = new System.Drawing.Point(210, 14);
            this.txtsenhaActual.MaxLength = 100;
            this.txtsenhaActual.Name = "txtsenhaActual";
            this.txtsenhaActual.PasswordChar = '*';
            this.txtsenhaActual.Size = new System.Drawing.Size(203, 23);
            this.txtsenhaActual.TabIndex = 1;
            this.txtsenhaActual.UseSystemPasswordChar = true;
            // 
            // txtconfirmarSenha
            // 
            this.txtconfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmarSenha.Location = new System.Drawing.Point(210, 73);
            this.txtconfirmarSenha.MaxLength = 100;
            this.txtconfirmarSenha.Name = "txtconfirmarSenha";
            this.txtconfirmarSenha.PasswordChar = '*';
            this.txtconfirmarSenha.Size = new System.Drawing.Size(203, 23);
            this.txtconfirmarSenha.TabIndex = 3;
            this.txtconfirmarSenha.UseSystemPasswordChar = true;
            // 
            // txtnovaSenha
            // 
            this.txtnovaSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnovaSenha.Location = new System.Drawing.Point(210, 44);
            this.txtnovaSenha.MaxLength = 100;
            this.txtnovaSenha.Name = "txtnovaSenha";
            this.txtnovaSenha.PasswordChar = '*';
            this.txtnovaSenha.Size = new System.Drawing.Size(203, 23);
            this.txtnovaSenha.TabIndex = 2;
            this.txtnovaSenha.UseSystemPasswordChar = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(22, 81);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(135, 15);
            this.Label4.TabIndex = 118;
            this.Label4.Text = "Confirme a Nova Senha:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(22, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 15);
            this.Label2.TabIndex = 117;
            this.Label2.Text = "Nova Senha:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(22, 22);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(42, 15);
            this.Label6.TabIndex = 116;
            this.Label6.Text = "Senha:";
            // 
            // FormAlterarSenhaAposLogin
            // 
            this.AcceptButton = this.BntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.BntCancelar;
            this.ClientSize = new System.Drawing.Size(436, 178);
            this.Controls.Add(this.BntConfirmar);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.txtsenhaActual);
            this.Controls.Add(this.txtconfirmarSenha);
            this.Controls.Add(this.txtnovaSenha);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label6);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlterarSenhaAposLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.FormAlterarSenhaAposLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BntConfirmar;
        internal System.Windows.Forms.Button BntCancelar;
        internal System.Windows.Forms.TextBox txtsenhaActual;
        internal System.Windows.Forms.TextBox txtconfirmarSenha;
        internal System.Windows.Forms.TextBox txtnovaSenha;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label6;
    }
}