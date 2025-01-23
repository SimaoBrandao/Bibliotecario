namespace Bibliotecario
{
    partial class FormConsultarModalidade
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
            this.bntAlterarModalidade = new System.Windows.Forms.Button();
            this.BntExcluirModalidade = new System.Windows.Forms.Button();
            this.BntAdicionarModalidade = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAlterarModalidade
            // 
            this.bntAlterarModalidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAlterarModalidade.Location = new System.Drawing.Point(754, 12);
            this.bntAlterarModalidade.Name = "bntAlterarModalidade";
            this.bntAlterarModalidade.Size = new System.Drawing.Size(75, 23);
            this.bntAlterarModalidade.TabIndex = 190;
            this.bntAlterarModalidade.Text = "Alterar";
            this.bntAlterarModalidade.UseVisualStyleBackColor = true;
            this.bntAlterarModalidade.Click += new System.EventHandler(this.bntAlterarModalidade_Click);
            // 
            // BntExcluirModalidade
            // 
            this.BntExcluirModalidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntExcluirModalidade.Location = new System.Drawing.Point(831, 12);
            this.BntExcluirModalidade.Name = "BntExcluirModalidade";
            this.BntExcluirModalidade.Size = new System.Drawing.Size(75, 23);
            this.BntExcluirModalidade.TabIndex = 191;
            this.BntExcluirModalidade.Text = "Excluir";
            this.BntExcluirModalidade.UseVisualStyleBackColor = true;
            this.BntExcluirModalidade.Click += new System.EventHandler(this.BntExcluirModalidade_Click);
            // 
            // BntAdicionarModalidade
            // 
            this.BntAdicionarModalidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntAdicionarModalidade.Location = new System.Drawing.Point(677, 12);
            this.BntAdicionarModalidade.Name = "BntAdicionarModalidade";
            this.BntAdicionarModalidade.Size = new System.Drawing.Size(75, 23);
            this.BntAdicionarModalidade.TabIndex = 189;
            this.BntAdicionarModalidade.Text = "Adicionar";
            this.BntAdicionarModalidade.UseVisualStyleBackColor = true;
            this.BntAdicionarModalidade.Click += new System.EventHandler(this.BntAdicionarModalidade_Click);
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
            this.DataGridView.Location = new System.Drawing.Point(12, 41);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(894, 280);
            this.DataGridView.TabIndex = 192;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // FormConsultarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(918, 333);
            this.Controls.Add(this.bntAlterarModalidade);
            this.Controls.Add(this.BntExcluirModalidade);
            this.Controls.Add(this.BntAdicionarModalidade);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultarModalidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modalidades";
            this.Activated += new System.EventHandler(this.FormConsultarModalidade_Activated);
            this.Load += new System.EventHandler(this.FormConsultarModalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntAlterarModalidade;
        private System.Windows.Forms.Button BntExcluirModalidade;
        private System.Windows.Forms.Button BntAdicionarModalidade;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}