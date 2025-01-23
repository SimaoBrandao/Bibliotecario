namespace Bibliotecario
{
    partial class FormEmprestimo
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
            this.txtTituloAcervo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataPrevistaDevolucao = new System.Windows.Forms.DateTimePicker();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.BntConfirmar = new System.Windows.Forms.Button();
            this.bntLocalizarCliente = new System.Windows.Forms.Button();
            this.bntLocalizarAcervo = new System.Windows.Forms.Button();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTituloAcervo
            // 
            this.txtTituloAcervo.Location = new System.Drawing.Point(171, 43);
            this.txtTituloAcervo.Name = "txtTituloAcervo";
            this.txtTituloAcervo.Size = new System.Drawing.Size(447, 23);
            this.txtTituloAcervo.TabIndex = 53;
            this.txtTituloAcervo.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Acervo: ";
            // 
            // dtpDataPrevistaDevolucao
            // 
            this.dtpDataPrevistaDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataPrevistaDevolucao.Location = new System.Drawing.Point(171, 103);
            this.dtpDataPrevistaDevolucao.Name = "dtpDataPrevistaDevolucao";
            this.dtpDataPrevistaDevolucao.Size = new System.Drawing.Size(130, 23);
            this.dtpDataPrevistaDevolucao.TabIndex = 4;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(171, 13);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(447, 23);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Data Devolução:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cliente:";
            // 
            // BntCancelar
            // 
            this.BntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BntCancelar.Location = new System.Drawing.Point(576, 179);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(75, 23);
            this.BntCancelar.TabIndex = 6;
            this.BntCancelar.Text = "Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = true;
            // 
            // BntConfirmar
            // 
            this.BntConfirmar.Location = new System.Drawing.Point(498, 179);
            this.BntConfirmar.Name = "BntConfirmar";
            this.BntConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BntConfirmar.TabIndex = 5;
            this.BntConfirmar.Text = "Confirmar";
            this.BntConfirmar.UseVisualStyleBackColor = true;
            this.BntConfirmar.Click += new System.EventHandler(this.BntConfirmar_Click);
            // 
            // bntLocalizarCliente
            // 
            this.bntLocalizarCliente.Location = new System.Drawing.Point(622, 13);
            this.bntLocalizarCliente.Name = "bntLocalizarCliente";
            this.bntLocalizarCliente.Size = new System.Drawing.Size(29, 23);
            this.bntLocalizarCliente.TabIndex = 1;
            this.bntLocalizarCliente.Text = "...";
            this.bntLocalizarCliente.UseVisualStyleBackColor = true;
            this.bntLocalizarCliente.Click += new System.EventHandler(this.bntLocalizarCliente_Click);
            // 
            // bntLocalizarAcervo
            // 
            this.bntLocalizarAcervo.Location = new System.Drawing.Point(622, 43);
            this.bntLocalizarAcervo.Name = "bntLocalizarAcervo";
            this.bntLocalizarAcervo.Size = new System.Drawing.Size(29, 23);
            this.bntLocalizarAcervo.TabIndex = 2;
            this.bntLocalizarAcervo.Text = "...";
            this.bntLocalizarAcervo.UseVisualStyleBackColor = true;
            this.bntLocalizarAcervo.Click += new System.EventHandler(this.bntLocalizarAcervo_Click);
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(171, 73);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(130, 23);
            this.dtpDataEmprestimo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Data Empréstimo:";
            // 
            // FormAdicionarEmprestimo
            // 
            this.AcceptButton = this.BntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.BntCancelar;
            this.ClientSize = new System.Drawing.Size(673, 223);
            this.Controls.Add(this.dtpDataEmprestimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntLocalizarAcervo);
            this.Controls.Add(this.bntLocalizarCliente);
            this.Controls.Add(this.txtTituloAcervo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDataPrevistaDevolucao);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.BntConfirmar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdicionarEmprestimo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Empréstimo";
            this.Load += new System.EventHandler(this.FormAdicionarEmprestimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTituloAcervo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDataPrevistaDevolucao;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BntConfirmar;
        private System.Windows.Forms.Button bntLocalizarCliente;
        private System.Windows.Forms.Button bntLocalizarAcervo;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
        private System.Windows.Forms.Label label3;
    }
}