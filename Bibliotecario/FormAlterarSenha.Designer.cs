namespace Bibliotecario
{
    partial class FormAlterarSenha
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
            this.BotaoCancelar = new System.Windows.Forms.Button();
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
            // BotaoCancelar
            // 
            this.BotaoCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotaoCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotaoCancelar.Location = new System.Drawing.Point(338, 141);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 5;
            this.BotaoCancelar.Text = "Cancelar";
            // 
            // txtsenhaActual
            // 
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
            this.Label4.TabIndex = 110;
            this.Label4.Text = "Confirme a Nova Senha:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(22, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 15);
            this.Label2.TabIndex = 109;
            this.Label2.Text = "Nova Senha:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(22, 22);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(42, 15);
            this.Label6.TabIndex = 108;
            this.Label6.Text = "Senha:";
            // 
            // FormAlterarSenha
            // 
            this.AcceptButton = this.BntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.BotaoCancelar;
            this.ClientSize = new System.Drawing.Size(436, 178);
            this.Controls.Add(this.BntConfirmar);
            this.Controls.Add(this.BotaoCancelar);
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
            this.Name = "FormAlterarSenha";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.FormAlterarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BntConfirmar;
        internal System.Windows.Forms.Button BotaoCancelar;
        internal System.Windows.Forms.TextBox txtsenhaActual;
        internal System.Windows.Forms.TextBox txtconfirmarSenha;
        internal System.Windows.Forms.TextBox txtnovaSenha;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label6;
    }
}