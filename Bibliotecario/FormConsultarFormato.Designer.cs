namespace Bibliotecario
{
    partial class FormConsultarFormato
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
            this.BntExcluirFormato = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Registros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BntAdicionarFormato = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.bntAlterarFormato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BntExcluirFormato
            // 
            this.BntExcluirFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntExcluirFormato.Location = new System.Drawing.Point(829, 13);
            this.BntExcluirFormato.Name = "BntExcluirFormato";
            this.BntExcluirFormato.Size = new System.Drawing.Size(75, 23);
            this.BntExcluirFormato.TabIndex = 4;
            this.BntExcluirFormato.Text = "Excluir";
            this.BntExcluirFormato.UseVisualStyleBackColor = true;
            this.BntExcluirFormato.Click += new System.EventHandler(this.BntExcluirFormato_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 187;
            this.label2.Text = "Localizar Formato:";
            // 
            // Registros
            // 
            this.Registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Registros.AutoSize = true;
            this.Registros.Location = new System.Drawing.Point(114, 307);
            this.Registros.Name = "Registros";
            this.Registros.Size = new System.Drawing.Size(55, 15);
            this.Registros.TabIndex = 186;
            this.Registros.Text = "Registros";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 185;
            this.label1.Text = "Foram Localizados:";
            // 
            // BntAdicionarFormato
            // 
            this.BntAdicionarFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntAdicionarFormato.Location = new System.Drawing.Point(675, 13);
            this.BntAdicionarFormato.Name = "BntAdicionarFormato";
            this.BntAdicionarFormato.Size = new System.Drawing.Size(75, 23);
            this.BntAdicionarFormato.TabIndex = 2;
            this.BntAdicionarFormato.Text = "Adicionar";
            this.BntAdicionarFormato.UseVisualStyleBackColor = true;
            this.BntAdicionarFormato.Click += new System.EventHandler(this.BntAdicionarFormato_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(14, 44);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(890, 260);
            this.DataGridView.TabIndex = 5;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // txtFormato
            // 
            this.txtFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormato.Location = new System.Drawing.Point(135, 13);
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Size = new System.Drawing.Size(336, 23);
            this.txtFormato.TabIndex = 1;
            this.txtFormato.TextChanged += new System.EventHandler(this.txtFormato_TextChanged);
            // 
            // bntAlterarFormato
            // 
            this.bntAlterarFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAlterarFormato.Location = new System.Drawing.Point(752, 13);
            this.bntAlterarFormato.Name = "bntAlterarFormato";
            this.bntAlterarFormato.Size = new System.Drawing.Size(75, 23);
            this.bntAlterarFormato.TabIndex = 3;
            this.bntAlterarFormato.Text = "Alterar";
            this.bntAlterarFormato.UseVisualStyleBackColor = true;
            this.bntAlterarFormato.Click += new System.EventHandler(this.bntAlterarFormato_Click);
            // 
            // FormConsultarFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(918, 333);
            this.Controls.Add(this.bntAlterarFormato);
            this.Controls.Add(this.BntExcluirFormato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntAdicionarFormato);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txtFormato);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultarFormato";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatos";
            this.Activated += new System.EventHandler(this.FormConsultarFormato_Activated);
            this.Load += new System.EventHandler(this.FormConsultarFormato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntExcluirFormato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Registros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntAdicionarFormato;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox txtFormato;
        private System.Windows.Forms.Button bntAlterarFormato;
    }
}