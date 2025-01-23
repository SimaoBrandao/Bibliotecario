namespace Bibliotecario
{
    partial class FormConsultarEmprestimo
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
            this.components = new System.ComponentModel.Container();
            this.bntDevolverEmprestimo = new System.Windows.Forms.Button();
            this.Registros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BntAdicionarEmprestimo = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarEmprestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirEmprestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.anularDevolucaoAcervoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.bntExportarEmprestimo = new System.Windows.Forms.Button();
            this.bntPesquizarEmprestimo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntDevolverEmprestimo
            // 
            this.bntDevolverEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntDevolverEmprestimo.Location = new System.Drawing.Point(944, 28);
            this.bntDevolverEmprestimo.Name = "bntDevolverEmprestimo";
            this.bntDevolverEmprestimo.Size = new System.Drawing.Size(75, 23);
            this.bntDevolverEmprestimo.TabIndex = 5;
            this.bntDevolverEmprestimo.Text = "Devolver";
            this.bntDevolverEmprestimo.UseVisualStyleBackColor = true;
            this.bntDevolverEmprestimo.Click += new System.EventHandler(this.bntDevoluçãoEmprestimo_Click);
            // 
            // Registros
            // 
            this.Registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Registros.AutoSize = true;
            this.Registros.Location = new System.Drawing.Point(125, 443);
            this.Registros.Name = "Registros";
            this.Registros.Size = new System.Drawing.Size(55, 15);
            this.Registros.TabIndex = 196;
            this.Registros.Text = "Registros";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 195;
            this.label1.Text = "Foram Localizados:";
            // 
            // BntAdicionarEmprestimo
            // 
            this.BntAdicionarEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntAdicionarEmprestimo.Location = new System.Drawing.Point(866, 28);
            this.BntAdicionarEmprestimo.Name = "BntAdicionarEmprestimo";
            this.BntAdicionarEmprestimo.Size = new System.Drawing.Size(75, 23);
            this.BntAdicionarEmprestimo.TabIndex = 4;
            this.BntAdicionarEmprestimo.Text = "Adicionar";
            this.BntAdicionarEmprestimo.UseVisualStyleBackColor = true;
            this.BntAdicionarEmprestimo.Click += new System.EventHandler(this.BntAdicionarEmprestimo_Click);
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
            this.DataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.DataGridView.Location = new System.Drawing.Point(10, 59);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(1086, 381);
            this.DataGridView.TabIndex = 7;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarEmprestimoToolStripMenuItem,
            this.excluirEmprestimoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.anularDevolucaoAcervoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 76);
            // 
            // alterarEmprestimoToolStripMenuItem
            // 
            this.alterarEmprestimoToolStripMenuItem.Name = "alterarEmprestimoToolStripMenuItem";
            this.alterarEmprestimoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.alterarEmprestimoToolStripMenuItem.Text = "Alterar";
            // 
            // excluirEmprestimoToolStripMenuItem
            // 
            this.excluirEmprestimoToolStripMenuItem.Name = "excluirEmprestimoToolStripMenuItem";
            this.excluirEmprestimoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.excluirEmprestimoToolStripMenuItem.Text = "Excluir";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // anularDevolucaoAcervoToolStripMenuItem
            // 
            this.anularDevolucaoAcervoToolStripMenuItem.Name = "anularDevolucaoAcervoToolStripMenuItem";
            this.anularDevolucaoAcervoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.anularDevolucaoAcervoToolStripMenuItem.Text = "Anular a Devolução";
            this.anularDevolucaoAcervoToolStripMenuItem.Click += new System.EventHandler(this.anularDevolucaoAcervoToolStripMenuItem_Click);
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Cliente",
            "CDD Acervo",
            "Título Acervo",
            "Data Empréstimo"});
            this.cbFiltro.Location = new System.Drawing.Point(10, 28);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(131, 23);
            this.cbFiltro.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 203;
            this.label4.Text = "Filtrar Por:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsulta.Location = new System.Drawing.Point(149, 28);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(331, 23);
            this.txtConsulta.TabIndex = 2;
            // 
            // bntExportarEmprestimo
            // 
            this.bntExportarEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntExportarEmprestimo.Location = new System.Drawing.Point(1021, 28);
            this.bntExportarEmprestimo.Name = "bntExportarEmprestimo";
            this.bntExportarEmprestimo.Size = new System.Drawing.Size(75, 23);
            this.bntExportarEmprestimo.TabIndex = 6;
            this.bntExportarEmprestimo.Text = "Exportar";
            this.bntExportarEmprestimo.UseVisualStyleBackColor = true;
            // 
            // bntPesquizarEmprestimo
            // 
            this.bntPesquizarEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntPesquizarEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPesquizarEmprestimo.Location = new System.Drawing.Point(482, 28);
            this.bntPesquizarEmprestimo.Name = "bntPesquizarEmprestimo";
            this.bntPesquizarEmprestimo.Size = new System.Drawing.Size(91, 23);
            this.bntPesquizarEmprestimo.TabIndex = 3;
            this.bntPesquizarEmprestimo.Text = "Pesquizar";
            this.bntPesquizarEmprestimo.UseVisualStyleBackColor = true;
            this.bntPesquizarEmprestimo.Click += new System.EventHandler(this.bntPesquizarEmprestimo_Click);
            // 
            // FormConsultarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1108, 470);
            this.Controls.Add(this.bntPesquizarEmprestimo);
            this.Controls.Add(this.bntExportarEmprestimo);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.bntDevolverEmprestimo);
            this.Controls.Add(this.Registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntAdicionarEmprestimo);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultarEmprestimo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Empréstimos";
            this.Activated += new System.EventHandler(this.FormConsultarEmprestimo_Activated);
            this.Load += new System.EventHandler(this.FormConsultarEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntDevolverEmprestimo;
        private System.Windows.Forms.Label Registros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntAdicionarEmprestimo;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button bntExportarEmprestimo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alterarEmprestimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirEmprestimoToolStripMenuItem;
        private System.Windows.Forms.Button bntPesquizarEmprestimo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anularDevolucaoAcervoToolStripMenuItem;
    }
}