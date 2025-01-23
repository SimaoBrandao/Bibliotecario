namespace Bibliotecario
{
    partial class FormConsultarCategoria
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
            this.BntExcluirCategoria = new System.Windows.Forms.Button();
            this.Registros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BntAdicionarCategoria = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.bntAlterarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BntExcluirCategoria
            // 
            this.BntExcluirCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntExcluirCategoria.Location = new System.Drawing.Point(720, 12);
            this.BntExcluirCategoria.Name = "BntExcluirCategoria";
            this.BntExcluirCategoria.Size = new System.Drawing.Size(75, 23);
            this.BntExcluirCategoria.TabIndex = 4;
            this.BntExcluirCategoria.Text = "Excluir";
            this.BntExcluirCategoria.UseVisualStyleBackColor = true;
            this.BntExcluirCategoria.Click += new System.EventHandler(this.BntExcluirCategoria_Click);
            // 
            // Registros
            // 
            this.Registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Registros.AutoSize = true;
            this.Registros.Location = new System.Drawing.Point(109, 326);
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
            this.label1.Location = new System.Drawing.Point(5, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 185;
            this.label1.Text = "Foram Localizados:";
            // 
            // BntAdicionarCategoria
            // 
            this.BntAdicionarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntAdicionarCategoria.Location = new System.Drawing.Point(566, 12);
            this.BntAdicionarCategoria.Name = "BntAdicionarCategoria";
            this.BntAdicionarCategoria.Size = new System.Drawing.Size(75, 23);
            this.BntAdicionarCategoria.TabIndex = 2;
            this.BntAdicionarCategoria.Text = "Adicionar";
            this.BntAdicionarCategoria.UseVisualStyleBackColor = true;
            this.BntAdicionarCategoria.Click += new System.EventHandler(this.BntAdicionarCategoria_Click);
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
            this.DataGridView.Location = new System.Drawing.Point(8, 39);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(787, 284);
            this.DataGridView.TabIndex = 5;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // bntAlterarCategoria
            // 
            this.bntAlterarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAlterarCategoria.Location = new System.Drawing.Point(643, 12);
            this.bntAlterarCategoria.Name = "bntAlterarCategoria";
            this.bntAlterarCategoria.Size = new System.Drawing.Size(75, 23);
            this.bntAlterarCategoria.TabIndex = 3;
            this.bntAlterarCategoria.Text = "Alterar";
            this.bntAlterarCategoria.UseVisualStyleBackColor = true;
            this.bntAlterarCategoria.Click += new System.EventHandler(this.bntAlterarCategoria_Click);
            // 
            // FormConsultarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.bntAlterarCategoria);
            this.Controls.Add(this.BntExcluirCategoria);
            this.Controls.Add(this.Registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntAdicionarCategoria);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultarCategoria";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Activated += new System.EventHandler(this.FormConsultarCategoria_Activated);
            this.Load += new System.EventHandler(this.FormConsultarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntExcluirCategoria;
        private System.Windows.Forms.Label Registros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntAdicionarCategoria;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button bntAlterarCategoria;
    }
}