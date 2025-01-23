namespace Bibliotecario
{
    partial class FormAdicionarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtTelemovelCliente = new System.Windows.Forms.TextBox();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.txtNumeroBICliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGeneroCliente = new System.Windows.Forms.ComboBox();
            this.cbModalidadeCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BntConfirmar
            // 
            this.BntConfirmar.Location = new System.Drawing.Point(575, 282);
            this.BntConfirmar.Name = "BntConfirmar";
            this.BntConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BntConfirmar.TabIndex = 8;
            this.BntConfirmar.Text = "Confirmar";
            this.BntConfirmar.UseVisualStyleBackColor = true;
            this.BntConfirmar.Click += new System.EventHandler(this.BntConfirmar_Click);
            // 
            // BntCancelar
            // 
            this.BntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BntCancelar.Location = new System.Drawing.Point(651, 282);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(75, 23);
            this.BntCancelar.TabIndex = 9;
            this.BntCancelar.Text = "Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telemóvel: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Género:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Endereço:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(220, 14);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(506, 23);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // txtTelemovelCliente
            // 
            this.txtTelemovelCliente.Location = new System.Drawing.Point(220, 166);
            this.txtTelemovelCliente.Name = "txtTelemovelCliente";
            this.txtTelemovelCliente.Size = new System.Drawing.Size(277, 23);
            this.txtTelemovelCliente.TabIndex = 6;
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(220, 136);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(506, 23);
            this.txtEnderecoCliente.TabIndex = 5;
            // 
            // txtNumeroBICliente
            // 
            this.txtNumeroBICliente.Location = new System.Drawing.Point(220, 106);
            this.txtNumeroBICliente.Name = "txtNumeroBICliente";
            this.txtNumeroBICliente.Size = new System.Drawing.Size(277, 23);
            this.txtNumeroBICliente.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nº do Bilhete de Identidade: ";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(220, 196);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(277, 23);
            this.txtEmailCliente.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "E-mail:";
            // 
            // cbGeneroCliente
            // 
            this.cbGeneroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeneroCliente.FormattingEnabled = true;
            this.cbGeneroCliente.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbGeneroCliente.Location = new System.Drawing.Point(220, 44);
            this.cbGeneroCliente.Name = "cbGeneroCliente";
            this.cbGeneroCliente.Size = new System.Drawing.Size(140, 23);
            this.cbGeneroCliente.TabIndex = 2;
            // 
            // cbModalidadeCliente
            // 
            this.cbModalidadeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidadeCliente.FormattingEnabled = true;
            this.cbModalidadeCliente.Items.AddRange(new object[] {
            "",
            "Estudante",
            "Professor(a)",
            "Pesquizador(a)"});
            this.cbModalidadeCliente.Location = new System.Drawing.Point(220, 75);
            this.cbModalidadeCliente.Name = "cbModalidadeCliente";
            this.cbModalidadeCliente.Size = new System.Drawing.Size(277, 23);
            this.cbModalidadeCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Modalidade:";
            // 
            // FormAdicionarCliente
            // 
            this.AcceptButton = this.BntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.BntCancelar;
            this.ClientSize = new System.Drawing.Size(741, 327);
            this.Controls.Add(this.cbModalidadeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGeneroCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumeroBICliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEnderecoCliente);
            this.Controls.Add(this.txtTelemovelCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.BntConfirmar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdicionarCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Cliente";
            this.Load += new System.EventHandler(this.FormAdicionarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntConfirmar;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtTelemovelCliente;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.TextBox txtNumeroBICliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGeneroCliente;
        private System.Windows.Forms.ComboBox cbModalidadeCliente;
        private System.Windows.Forms.Label label2;
    }
}