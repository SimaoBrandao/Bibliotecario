namespace Bibliotecario
{
    partial class FormDevolucao
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
            this.txtTituloAcervo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.BntConfirmar = new System.Windows.Forms.Button();
            this.txtDataEmprestimo = new System.Windows.Forms.TextBox();
            this.dtpDataRealDevolucaoEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 69;
            this.label3.Text = "Data Empréstimo:";
            // 
            // txtTituloAcervo
            // 
            this.txtTituloAcervo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTituloAcervo.Location = new System.Drawing.Point(171, 43);
            this.txtTituloAcervo.Name = "txtTituloAcervo";
            this.txtTituloAcervo.ReadOnly = true;
            this.txtTituloAcervo.Size = new System.Drawing.Size(479, 23);
            this.txtTituloAcervo.TabIndex = 67;
            this.txtTituloAcervo.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 68;
            this.label9.Text = "Acervo: ";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNomeCliente.Location = new System.Drawing.Point(171, 13);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(479, 23);
            this.txtNomeCliente.TabIndex = 59;
            this.txtNomeCliente.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Data Devolução:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 65;
            this.label1.Text = "Cliente:";
            // 
            // BntCancelar
            // 
            this.BntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BntCancelar.Location = new System.Drawing.Point(575, 188);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(75, 23);
            this.BntCancelar.TabIndex = 3;
            this.BntCancelar.Text = "Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = true;
            // 
            // BntConfirmar
            // 
            this.BntConfirmar.Location = new System.Drawing.Point(496, 188);
            this.BntConfirmar.Name = "BntConfirmar";
            this.BntConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BntConfirmar.TabIndex = 2;
            this.BntConfirmar.Text = "Confirmar";
            this.BntConfirmar.UseVisualStyleBackColor = true;
            this.BntConfirmar.Click += new System.EventHandler(this.BntConfirmar_Click);
            // 
            // txtDataEmprestimo
            // 
            this.txtDataEmprestimo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDataEmprestimo.Location = new System.Drawing.Point(171, 73);
            this.txtDataEmprestimo.Name = "txtDataEmprestimo";
            this.txtDataEmprestimo.ReadOnly = true;
            this.txtDataEmprestimo.Size = new System.Drawing.Size(130, 23);
            this.txtDataEmprestimo.TabIndex = 70;
            this.txtDataEmprestimo.TabStop = false;
            // 
            // dtpDataRealDevolucaoEmprestimo
            // 
            this.dtpDataRealDevolucaoEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataRealDevolucaoEmprestimo.Location = new System.Drawing.Point(171, 102);
            this.dtpDataRealDevolucaoEmprestimo.Name = "dtpDataRealDevolucaoEmprestimo";
            this.dtpDataRealDevolucaoEmprestimo.Size = new System.Drawing.Size(130, 23);
            this.dtpDataRealDevolucaoEmprestimo.TabIndex = 1;
            // 
            // FormDevolucao
            // 
            this.AcceptButton = this.BntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.BntCancelar;
            this.ClientSize = new System.Drawing.Size(669, 223);
            this.Controls.Add(this.dtpDataRealDevolucaoEmprestimo);
            this.Controls.Add(this.txtDataEmprestimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTituloAcervo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.BntConfirmar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDevolucao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.FormDevolucao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTituloAcervo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BntConfirmar;
        private System.Windows.Forms.TextBox txtDataEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDataRealDevolucaoEmprestimo;
    }
}