namespace Bibliotecario
{
    partial class FormAlterarAcervo
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
            this.cbCategoriaAcervo = new System.Windows.Forms.ComboBox();
            this.txtISBNAcervo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnoPublicacao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantidadeAcervo = new System.Windows.Forms.TextBox();
            this.txtTituloAcervo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.BntConfirmar = new System.Windows.Forms.Button();
            this.txtAutorAcervo = new System.Windows.Forms.TextBox();
            this.txtEditoraAcervo = new System.Windows.Forms.TextBox();
            this.txtLocalizacaoAcervo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFormatoAcervo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdiomaAcervo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCDDAcervo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCategoriaAcervo
            // 
            this.cbCategoriaAcervo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaAcervo.FormattingEnabled = true;
            this.cbCategoriaAcervo.Location = new System.Drawing.Point(184, 43);
            this.cbCategoriaAcervo.Name = "cbCategoriaAcervo";
            this.cbCategoriaAcervo.Size = new System.Drawing.Size(277, 23);
            this.cbCategoriaAcervo.TabIndex = 2;
            // 
            // txtISBNAcervo
            // 
            this.txtISBNAcervo.Location = new System.Drawing.Point(184, 256);
            this.txtISBNAcervo.MaxLength = 50;
            this.txtISBNAcervo.Name = "txtISBNAcervo";
            this.txtISBNAcervo.Size = new System.Drawing.Size(277, 23);
            this.txtISBNAcervo.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 77;
            this.label8.Text = "ISBN:";
            // 
            // txtAnoPublicacao
            // 
            this.txtAnoPublicacao.Location = new System.Drawing.Point(184, 226);
            this.txtAnoPublicacao.MaxLength = 4;
            this.txtAnoPublicacao.Name = "txtAnoPublicacao";
            this.txtAnoPublicacao.Size = new System.Drawing.Size(91, 23);
            this.txtAnoPublicacao.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 15);
            this.label9.TabIndex = 74;
            this.label9.Text = "Ano da Publicação:";
            // 
            // txtQuantidadeAcervo
            // 
            this.txtQuantidadeAcervo.Location = new System.Drawing.Point(184, 316);
            this.txtQuantidadeAcervo.MaxLength = 3;
            this.txtQuantidadeAcervo.Name = "txtQuantidadeAcervo";
            this.txtQuantidadeAcervo.Size = new System.Drawing.Size(91, 23);
            this.txtQuantidadeAcervo.TabIndex = 11;
            // 
            // txtTituloAcervo
            // 
            this.txtTituloAcervo.Location = new System.Drawing.Point(184, 13);
            this.txtTituloAcervo.MaxLength = 100;
            this.txtTituloAcervo.Name = "txtTituloAcervo";
            this.txtTituloAcervo.Size = new System.Drawing.Size(506, 23);
            this.txtTituloAcervo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 70;
            this.label4.Text = "Editora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "Categoria: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 66;
            this.label1.Text = "Título:";
            // 
            // BntCancelar
            // 
            this.BntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BntCancelar.Location = new System.Drawing.Point(615, 398);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(75, 23);
            this.BntCancelar.TabIndex = 13;
            this.BntCancelar.Text = "Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = true;
            // 
            // BntConfirmar
            // 
            this.BntConfirmar.Location = new System.Drawing.Point(536, 398);
            this.BntConfirmar.Name = "BntConfirmar";
            this.BntConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BntConfirmar.TabIndex = 12;
            this.BntConfirmar.Text = "Confirmar";
            this.BntConfirmar.UseVisualStyleBackColor = true;
            this.BntConfirmar.Click += new System.EventHandler(this.BntConfirmar_Click);
            // 
            // txtAutorAcervo
            // 
            this.txtAutorAcervo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAutorAcervo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAutorAcervo.Location = new System.Drawing.Point(184, 165);
            this.txtAutorAcervo.MaxLength = 100;
            this.txtAutorAcervo.Name = "txtAutorAcervo";
            this.txtAutorAcervo.Size = new System.Drawing.Size(506, 23);
            this.txtAutorAcervo.TabIndex = 6;
            // 
            // txtEditoraAcervo
            // 
            this.txtEditoraAcervo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEditoraAcervo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditoraAcervo.Location = new System.Drawing.Point(184, 196);
            this.txtEditoraAcervo.MaxLength = 100;
            this.txtEditoraAcervo.Name = "txtEditoraAcervo";
            this.txtEditoraAcervo.Size = new System.Drawing.Size(506, 23);
            this.txtEditoraAcervo.TabIndex = 7;
            // 
            // txtLocalizacaoAcervo
            // 
            this.txtLocalizacaoAcervo.Location = new System.Drawing.Point(184, 286);
            this.txtLocalizacaoAcervo.MaxLength = 100;
            this.txtLocalizacaoAcervo.Name = "txtLocalizacaoAcervo";
            this.txtLocalizacaoAcervo.Size = new System.Drawing.Size(506, 23);
            this.txtLocalizacaoAcervo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 86;
            this.label6.Text = "Localização:";
            // 
            // cbFormatoAcervo
            // 
            this.cbFormatoAcervo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormatoAcervo.FormattingEnabled = true;
            this.cbFormatoAcervo.Location = new System.Drawing.Point(184, 104);
            this.cbFormatoAcervo.Name = "cbFormatoAcervo";
            this.cbFormatoAcervo.Size = new System.Drawing.Size(195, 23);
            this.cbFormatoAcervo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 87;
            this.label7.Text = "Formato: ";
            // 
            // txtIdiomaAcervo
            // 
            this.txtIdiomaAcervo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIdiomaAcervo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIdiomaAcervo.Location = new System.Drawing.Point(184, 135);
            this.txtIdiomaAcervo.MaxLength = 50;
            this.txtIdiomaAcervo.Name = "txtIdiomaAcervo";
            this.txtIdiomaAcervo.Size = new System.Drawing.Size(195, 23);
            this.txtIdiomaAcervo.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 89;
            this.label10.Text = "Idioma:";
            // 
            // txtCDDAcervo
            // 
            this.txtCDDAcervo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCDDAcervo.Location = new System.Drawing.Point(184, 74);
            this.txtCDDAcervo.MaxLength = 50;
            this.txtCDDAcervo.Name = "txtCDDAcervo";
            this.txtCDDAcervo.ReadOnly = true;
            this.txtCDDAcervo.Size = new System.Drawing.Size(195, 23);
            this.txtCDDAcervo.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 115;
            this.label11.Text = "CDD:";
            // 
            // FormAlterarAcervo
            // 
            this.AcceptButton = this.BntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.BntCancelar;
            this.ClientSize = new System.Drawing.Size(712, 442);
            this.Controls.Add(this.txtCDDAcervo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIdiomaAcervo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbFormatoAcervo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLocalizacaoAcervo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEditoraAcervo);
            this.Controls.Add(this.txtAutorAcervo);
            this.Controls.Add(this.cbCategoriaAcervo);
            this.Controls.Add(this.txtISBNAcervo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAnoPublicacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQuantidadeAcervo);
            this.Controls.Add(this.txtTituloAcervo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.BntConfirmar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlterarAcervo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Acervo";
            this.Load += new System.EventHandler(this.FormAlterarAcervo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategoriaAcervo;
        private System.Windows.Forms.TextBox txtISBNAcervo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnoPublicacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantidadeAcervo;
        private System.Windows.Forms.TextBox txtTituloAcervo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BntConfirmar;
        private System.Windows.Forms.TextBox txtAutorAcervo;
        private System.Windows.Forms.TextBox txtEditoraAcervo;
        private System.Windows.Forms.TextBox txtLocalizacaoAcervo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFormatoAcervo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdiomaAcervo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCDDAcervo;
        private System.Windows.Forms.Label label11;
    }
}