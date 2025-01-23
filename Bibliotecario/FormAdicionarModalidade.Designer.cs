namespace Bibliotecario
{
    partial class FormAdicionarModalidade
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
            this.bntCancelar = new System.Windows.Forms.Button();
            this.BntConfirmar = new System.Windows.Forms.Button();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntCancelar
            // 
            this.bntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancelar.Location = new System.Drawing.Point(423, 114);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 3;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // BntConfirmar
            // 
            this.BntConfirmar.Location = new System.Drawing.Point(346, 114);
            this.BntConfirmar.Name = "BntConfirmar";
            this.BntConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BntConfirmar.TabIndex = 2;
            this.BntConfirmar.Text = "Confirmar";
            this.BntConfirmar.UseVisualStyleBackColor = true;
            this.BntConfirmar.Click += new System.EventHandler(this.BntConfirmar_Click);
            // 
            // txtModalidade
            // 
            this.txtModalidade.Location = new System.Drawing.Point(199, 14);
            this.txtModalidade.MaxLength = 100;
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(299, 23);
            this.txtModalidade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 91;
            this.label1.Text = "Modalidade";
            // 
            // FormAdicionarModalidade
            // 
            this.AcceptButton = this.BntConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.bntCancelar;
            this.ClientSize = new System.Drawing.Size(514, 150);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.BntConfirmar);
            this.Controls.Add(this.txtModalidade);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdicionarModalidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Modalidade";
            this.Load += new System.EventHandler(this.FormAdicionarModalidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button BntConfirmar;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Label label1;
    }
}