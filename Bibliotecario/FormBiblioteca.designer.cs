namespace Bibliotecario
{
    partial class FormBiblioteca
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
            this.txtEmailBiblioteca = new System.Windows.Forms.TextBox();
            this.txtEnderecoBiblioteca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelemovelBiblioteca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNifBiblioteca = new System.Windows.Forms.TextBox();
            this.txtNomeBiblioteca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.BntConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmailBiblioteca
            // 
            this.txtEmailBiblioteca.Location = new System.Drawing.Point(192, 100);
            this.txtEmailBiblioteca.MaxLength = 50;
            this.txtEmailBiblioteca.Name = "txtEmailBiblioteca";
            this.txtEmailBiblioteca.Size = new System.Drawing.Size(403, 23);
            this.txtEmailBiblioteca.TabIndex = 4;
            // 
            // txtEnderecoBiblioteca
            // 
            this.txtEnderecoBiblioteca.Location = new System.Drawing.Point(192, 71);
            this.txtEnderecoBiblioteca.MaxLength = 100;
            this.txtEnderecoBiblioteca.Name = "txtEnderecoBiblioteca";
            this.txtEnderecoBiblioteca.Size = new System.Drawing.Size(403, 23);
            this.txtEnderecoBiblioteca.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 95;
            this.label9.Text = "NIF: ";
            // 
            // txtTelemovelBiblioteca
            // 
            this.txtTelemovelBiblioteca.Location = new System.Drawing.Point(192, 129);
            this.txtTelemovelBiblioteca.MaxLength = 50;
            this.txtTelemovelBiblioteca.Name = "txtTelemovelBiblioteca";
            this.txtTelemovelBiblioteca.Size = new System.Drawing.Size(203, 23);
            this.txtTelemovelBiblioteca.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 97;
            this.label4.Text = "Telemóvel: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 96;
            this.label3.Text = "Endereço:";
            // 
            // txtNifBiblioteca
            // 
            this.txtNifBiblioteca.Location = new System.Drawing.Point(192, 42);
            this.txtNifBiblioteca.MaxLength = 50;
            this.txtNifBiblioteca.Name = "txtNifBiblioteca";
            this.txtNifBiblioteca.Size = new System.Drawing.Size(196, 23);
            this.txtNifBiblioteca.TabIndex = 2;
            // 
            // txtNomeBiblioteca
            // 
            this.txtNomeBiblioteca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomeBiblioteca.Location = new System.Drawing.Point(192, 13);
            this.txtNomeBiblioteca.MaxLength = 100;
            this.txtNomeBiblioteca.Name = "txtNomeBiblioteca";
            this.txtNomeBiblioteca.Size = new System.Drawing.Size(403, 23);
            this.txtNomeBiblioteca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nome:";
            // 
            // BntCancelar
            // 
            this.BntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BntCancelar.Location = new System.Drawing.Point(520, 247);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(75, 23);
            this.BntCancelar.TabIndex = 9;
            this.BntCancelar.Text = "Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = true;
            // 
            // BntConfirmar
            // 
            this.BntConfirmar.Location = new System.Drawing.Point(442, 247);
            this.BntConfirmar.Name = "BntConfirmar";
            this.BntConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BntConfirmar.TabIndex = 8;
            this.BntConfirmar.Text = "Confirmar";
            this.BntConfirmar.UseVisualStyleBackColor = true;
            this.BntConfirmar.Click += new System.EventHandler(this.BntConfirmar_Click);
            // 
            // FormBiblioteca
            // 
            this.AcceptButton = this.BntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(609, 282);
            this.Controls.Add(this.txtEmailBiblioteca);
            this.Controls.Add(this.txtEnderecoBiblioteca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelemovelBiblioteca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNifBiblioteca);
            this.Controls.Add(this.txtNomeBiblioteca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.BntConfirmar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBiblioteca";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados da Biblioteca";
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailBiblioteca;
        private System.Windows.Forms.TextBox txtEnderecoBiblioteca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelemovelBiblioteca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNifBiblioteca;
        private System.Windows.Forms.TextBox txtNomeBiblioteca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BntConfirmar;
    }
}