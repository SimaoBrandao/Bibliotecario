namespace Bibliotecario
{
    partial class FormConsultarUtilizador
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
            this.bntExcluirUtilizador = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Registros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntAdicionarUtilizador = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.utilizadorContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redefinirSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtpesquiza = new System.Windows.Forms.TextBox();
            this.bntAlterarUtilizador = new System.Windows.Forms.Button();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.utilizadorContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntExcluirUtilizador
            // 
            this.bntExcluirUtilizador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntExcluirUtilizador.Location = new System.Drawing.Point(829, 13);
            this.bntExcluirUtilizador.Name = "bntExcluirUtilizador";
            this.bntExcluirUtilizador.Size = new System.Drawing.Size(75, 23);
            this.bntExcluirUtilizador.TabIndex = 4;
            this.bntExcluirUtilizador.Text = "Excluir";
            this.bntExcluirUtilizador.UseVisualStyleBackColor = true;
            this.bntExcluirUtilizador.Click += new System.EventHandler(this.BntExcluirUtilizador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 166;
            this.label2.Text = "Localizar Utilizador:";
            // 
            // Registros
            // 
            this.Registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Registros.AutoSize = true;
            this.Registros.Location = new System.Drawing.Point(121, 307);
            this.Registros.Name = "Registros";
            this.Registros.Size = new System.Drawing.Size(55, 15);
            this.Registros.TabIndex = 165;
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
            this.label1.TabIndex = 164;
            this.label1.Text = "Foram Localizados:";
            // 
            // bntAdicionarUtilizador
            // 
            this.bntAdicionarUtilizador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAdicionarUtilizador.Location = new System.Drawing.Point(674, 13);
            this.bntAdicionarUtilizador.Name = "bntAdicionarUtilizador";
            this.bntAdicionarUtilizador.Size = new System.Drawing.Size(75, 23);
            this.bntAdicionarUtilizador.TabIndex = 2;
            this.bntAdicionarUtilizador.Text = "Adicionar";
            this.bntAdicionarUtilizador.UseVisualStyleBackColor = true;
            this.bntAdicionarUtilizador.Click += new System.EventHandler(this.BntAdicionarUtilizador_Click);
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
            this.DataGridView.ContextMenuStrip = this.utilizadorContextMenuStrip;
            this.DataGridView.Location = new System.Drawing.Point(14, 44);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(890, 260);
            this.DataGridView.TabIndex = 5;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // utilizadorContextMenuStrip
            // 
            this.utilizadorContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redefinirSenhaToolStripMenuItem,
            this.bloquearToolStripMenuItem,
            this.desbloquearToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.utilizadorContextMenuStrip.Name = "utilizadorContextMenuStrip";
            this.utilizadorContextMenuStrip.Size = new System.Drawing.Size(181, 114);
            // 
            // redefinirSenhaToolStripMenuItem
            // 
            this.redefinirSenhaToolStripMenuItem.Name = "redefinirSenhaToolStripMenuItem";
            this.redefinirSenhaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.redefinirSenhaToolStripMenuItem.Text = "Redefinir senha";
            this.redefinirSenhaToolStripMenuItem.Click += new System.EventHandler(this.redefinirSenhaToolStripMenuItem_Click);
            // 
            // bloquearToolStripMenuItem
            // 
            this.bloquearToolStripMenuItem.Name = "bloquearToolStripMenuItem";
            this.bloquearToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bloquearToolStripMenuItem.Text = "Bloquear";
            this.bloquearToolStripMenuItem.Click += new System.EventHandler(this.bloquearToolStripMenuItem_Click);
            // 
            // desbloquearToolStripMenuItem
            // 
            this.desbloquearToolStripMenuItem.Name = "desbloquearToolStripMenuItem";
            this.desbloquearToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.desbloquearToolStripMenuItem.Text = "Desbloquear";
            this.desbloquearToolStripMenuItem.Click += new System.EventHandler(this.desbloquearToolStripMenuItem_Click);
            // 
            // txtpesquiza
            // 
            this.txtpesquiza.Location = new System.Drawing.Point(135, 13);
            this.txtpesquiza.Name = "txtpesquiza";
            this.txtpesquiza.Size = new System.Drawing.Size(336, 23);
            this.txtpesquiza.TabIndex = 1;
            // 
            // bntAlterarUtilizador
            // 
            this.bntAlterarUtilizador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAlterarUtilizador.Location = new System.Drawing.Point(752, 13);
            this.bntAlterarUtilizador.Name = "bntAlterarUtilizador";
            this.bntAlterarUtilizador.Size = new System.Drawing.Size(75, 23);
            this.bntAlterarUtilizador.TabIndex = 3;
            this.bntAlterarUtilizador.Text = "Alterar";
            this.bntAlterarUtilizador.UseVisualStyleBackColor = true;
            this.bntAlterarUtilizador.Click += new System.EventHandler(this.bntAlterarUtilizador_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // FormConsultarUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(918, 333);
            this.Controls.Add(this.bntAlterarUtilizador);
            this.Controls.Add(this.bntExcluirUtilizador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntAdicionarUtilizador);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txtpesquiza);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Name = "FormConsultarUtilizador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizadores";
            this.Activated += new System.EventHandler(this.FormConsultarUtilizador_Activated);
            this.Load += new System.EventHandler(this.FormConsultarUtilizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.utilizadorContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntExcluirUtilizador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Registros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntAdicionarUtilizador;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox txtpesquiza;
        private System.Windows.Forms.ContextMenuStrip utilizadorContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem redefinirSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desbloquearToolStripMenuItem;
        private System.Windows.Forms.Button bntAlterarUtilizador;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}