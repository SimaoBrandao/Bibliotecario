namespace Bibliotecario
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lkbEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.lkbDefinicao = new System.Windows.Forms.LinkLabel();
            this.lkbCriarConta = new System.Windows.Forms.LinkLabel();
            this.BntConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lkbEsqueceuSenha
            // 
            this.lkbEsqueceuSenha.AutoSize = true;
            this.lkbEsqueceuSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lkbEsqueceuSenha.LinkColor = System.Drawing.Color.Black;
            this.lkbEsqueceuSenha.Location = new System.Drawing.Point(350, 86);
            this.lkbEsqueceuSenha.Name = "lkbEsqueceuSenha";
            this.lkbEsqueceuSenha.Size = new System.Drawing.Size(105, 15);
            this.lkbEsqueceuSenha.TabIndex = 51;
            this.lkbEsqueceuSenha.TabStop = true;
            this.lkbEsqueceuSenha.Text = "Esqueceu a senha?";
            this.lkbEsqueceuSenha.VisitedLinkColor = System.Drawing.Color.Black;
            this.lkbEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbEsqueceuSenha_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // bntCancelar
            // 
            this.bntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancelar.Location = new System.Drawing.Point(380, 116);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 49;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // lkbDefinicao
            // 
            this.lkbDefinicao.AutoSize = true;
            this.lkbDefinicao.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lkbDefinicao.LinkColor = System.Drawing.Color.Black;
            this.lkbDefinicao.Location = new System.Drawing.Point(396, 187);
            this.lkbDefinicao.Name = "lkbDefinicao";
            this.lkbDefinicao.Size = new System.Drawing.Size(62, 15);
            this.lkbDefinicao.TabIndex = 48;
            this.lkbDefinicao.TabStop = true;
            this.lkbDefinicao.Text = "Definições";
            this.lkbDefinicao.VisitedLinkColor = System.Drawing.Color.Black;
            this.lkbDefinicao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbDefinicao_LinkClicked);
            // 
            // lkbCriarConta
            // 
            this.lkbCriarConta.AutoSize = true;
            this.lkbCriarConta.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lkbCriarConta.LinkColor = System.Drawing.Color.Black;
            this.lkbCriarConta.Location = new System.Drawing.Point(193, 187);
            this.lkbCriarConta.Name = "lkbCriarConta";
            this.lkbCriarConta.Size = new System.Drawing.Size(197, 15);
            this.lkbCriarConta.TabIndex = 47;
            this.lkbCriarConta.TabStop = true;
            this.lkbCriarConta.Text = "Não possui uma conta? cadastra-se.";
            this.lkbCriarConta.VisitedLinkColor = System.Drawing.Color.Black;
            this.lkbCriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbCriarConta_LinkClicked);
            // 
            // BntConfirmar
            // 
            this.BntConfirmar.Location = new System.Drawing.Point(302, 116);
            this.BntConfirmar.Name = "BntConfirmar";
            this.BntConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BntConfirmar.TabIndex = 3;
            this.BntConfirmar.Text = "Confirmar";
            this.BntConfirmar.UseVisualStyleBackColor = true;
            this.BntConfirmar.Click += new System.EventHandler(this.BntConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "E-mail:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(268, 60);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(187, 23);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(268, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.BntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.lkbEsqueceuSenha);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.lkbDefinicao);
            this.Controls.Add(this.lkbCriarConta);
            this.Controls.Add(this.BntConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotecário";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lkbEsqueceuSenha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.LinkLabel lkbDefinicao;
        private System.Windows.Forms.LinkLabel lkbCriarConta;
        private System.Windows.Forms.Button BntConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
    }
}