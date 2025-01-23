namespace Bibliotecario
{
    partial class FormConsultarAcervo
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
            this.BntExcluirAcervo = new System.Windows.Forms.Button();
            this.Registros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntAdicionarAcervo = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntExportarAcervo = new System.Windows.Forms.Button();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.bntAlterarAcervo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BntExcluirAcervo
            // 
            this.BntExcluirAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntExcluirAcervo.Location = new System.Drawing.Point(944, 29);
            this.BntExcluirAcervo.Name = "BntExcluirAcervo";
            this.BntExcluirAcervo.Size = new System.Drawing.Size(75, 23);
            this.BntExcluirAcervo.TabIndex = 5;
            this.BntExcluirAcervo.Text = "Excluir";
            this.BntExcluirAcervo.UseVisualStyleBackColor = true;
            this.BntExcluirAcervo.Click += new System.EventHandler(this.BntExcluirAcervo_Click);
            // 
            // Registros
            // 
            this.Registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Registros.AutoSize = true;
            this.Registros.Location = new System.Drawing.Point(121, 444);
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
            this.label1.Location = new System.Drawing.Point(14, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 185;
            this.label1.Text = "Foram Localizados:";
            // 
            // bntAdicionarAcervo
            // 
            this.bntAdicionarAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAdicionarAcervo.Location = new System.Drawing.Point(789, 29);
            this.bntAdicionarAcervo.Name = "bntAdicionarAcervo";
            this.bntAdicionarAcervo.Size = new System.Drawing.Size(75, 23);
            this.bntAdicionarAcervo.TabIndex = 3;
            this.bntAdicionarAcervo.Text = "Adicionar";
            this.bntAdicionarAcervo.UseVisualStyleBackColor = true;
            this.bntAdicionarAcervo.Click += new System.EventHandler(this.BntAdicionarAcervo_Click);
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
            this.DataGridView.Location = new System.Drawing.Point(10, 59);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(1086, 382);
            this.DataGridView.TabIndex = 7;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsulta.Location = new System.Drawing.Point(124, 29);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(371, 23);
            this.txtConsulta.TabIndex = 2;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 196;
            this.label4.Text = "Filtrar Por:";
            // 
            // bntExportarAcervo
            // 
            this.bntExportarAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntExportarAcervo.Location = new System.Drawing.Point(1021, 29);
            this.bntExportarAcervo.Name = "bntExportarAcervo";
            this.bntExportarAcervo.Size = new System.Drawing.Size(75, 23);
            this.bntExportarAcervo.TabIndex = 6;
            this.bntExportarAcervo.Text = "Exportar";
            this.bntExportarAcervo.UseVisualStyleBackColor = true;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Todos",
            "CDD",
            "Título",
            "Categoria",
            "Localização",
            "ISBN"});
            this.cbFiltro.Location = new System.Drawing.Point(10, 29);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(107, 23);
            this.cbFiltro.TabIndex = 1;
            this.cbFiltro.DropDownClosed += new System.EventHandler(this.cbFiltro_DropDownClosed);
            // 
            // bntAlterarAcervo
            // 
            this.bntAlterarAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAlterarAcervo.Location = new System.Drawing.Point(867, 29);
            this.bntAlterarAcervo.Name = "bntAlterarAcervo";
            this.bntAlterarAcervo.Size = new System.Drawing.Size(75, 23);
            this.bntAlterarAcervo.TabIndex = 4;
            this.bntAlterarAcervo.Text = "Alterar";
            this.bntAlterarAcervo.UseVisualStyleBackColor = true;
            this.bntAlterarAcervo.Click += new System.EventHandler(this.bntAlterarAcervo_Click);
            // 
            // FormConsultarAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1108, 470);
            this.Controls.Add(this.bntAlterarAcervo);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.bntExportarAcervo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.BntExcluirAcervo);
            this.Controls.Add(this.Registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntAdicionarAcervo);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Name = "FormConsultarAcervo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Acervos";
            this.Activated += new System.EventHandler(this.FormConsultarAcervo_Activated);
            this.Load += new System.EventHandler(this.FormConsultarAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntExcluirAcervo;
        private System.Windows.Forms.Label Registros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntAdicionarAcervo;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntExportarAcervo;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button bntAlterarAcervo;
    }
}