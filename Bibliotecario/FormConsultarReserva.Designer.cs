namespace Bibliotecario
{
    partial class FormConsultarReserva
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
            this.bntAlterarReserva = new System.Windows.Forms.Button();
            this.cbFiltroReserva = new System.Windows.Forms.ComboBox();
            this.bntExportarReserva = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConsultaReserva = new System.Windows.Forms.TextBox();
            this.BntExcluirReserva = new System.Windows.Forms.Button();
            this.Registros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntAdicionarReserva = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAlterarReserva
            // 
            this.bntAlterarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAlterarReserva.Location = new System.Drawing.Point(870, 29);
            this.bntAlterarReserva.Name = "bntAlterarReserva";
            this.bntAlterarReserva.Size = new System.Drawing.Size(75, 23);
            this.bntAlterarReserva.TabIndex = 200;
            this.bntAlterarReserva.Text = "Alterar";
            this.bntAlterarReserva.UseVisualStyleBackColor = true;
            // 
            // cbFiltroReserva
            // 
            this.cbFiltroReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroReserva.FormattingEnabled = true;
            this.cbFiltroReserva.Items.AddRange(new object[] {
            "CDD",
            "Título",
            "Categoria",
            "Localização",
            "ISBN"});
            this.cbFiltroReserva.Location = new System.Drawing.Point(13, 28);
            this.cbFiltroReserva.Name = "cbFiltroReserva";
            this.cbFiltroReserva.Size = new System.Drawing.Size(125, 23);
            this.cbFiltroReserva.TabIndex = 197;
            // 
            // bntExportarReserva
            // 
            this.bntExportarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntExportarReserva.Location = new System.Drawing.Point(1024, 29);
            this.bntExportarReserva.Name = "bntExportarReserva";
            this.bntExportarReserva.Size = new System.Drawing.Size(75, 23);
            this.bntExportarReserva.TabIndex = 202;
            this.bntExportarReserva.Text = "Exportar";
            this.bntExportarReserva.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 206;
            this.label4.Text = "Filtrar Por:";
            // 
            // txtConsultaReserva
            // 
            this.txtConsultaReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaReserva.Location = new System.Drawing.Point(146, 29);
            this.txtConsultaReserva.Name = "txtConsultaReserva";
            this.txtConsultaReserva.Size = new System.Drawing.Size(430, 23);
            this.txtConsultaReserva.TabIndex = 198;
            // 
            // BntExcluirReserva
            // 
            this.BntExcluirReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntExcluirReserva.Location = new System.Drawing.Point(947, 29);
            this.BntExcluirReserva.Name = "BntExcluirReserva";
            this.BntExcluirReserva.Size = new System.Drawing.Size(75, 23);
            this.BntExcluirReserva.TabIndex = 201;
            this.BntExcluirReserva.Text = "Excluir";
            this.BntExcluirReserva.UseVisualStyleBackColor = true;
            // 
            // Registros
            // 
            this.Registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Registros.AutoSize = true;
            this.Registros.Location = new System.Drawing.Point(127, 444);
            this.Registros.Name = "Registros";
            this.Registros.Size = new System.Drawing.Size(55, 15);
            this.Registros.TabIndex = 205;
            this.Registros.Text = "Registros";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 204;
            this.label1.Text = "Foram Localizados:";
            // 
            // bntAdicionarReserva
            // 
            this.bntAdicionarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAdicionarReserva.Location = new System.Drawing.Point(793, 29);
            this.bntAdicionarReserva.Name = "bntAdicionarReserva";
            this.bntAdicionarReserva.Size = new System.Drawing.Size(75, 23);
            this.bntAdicionarReserva.TabIndex = 199;
            this.bntAdicionarReserva.Text = "Adicionar";
            this.bntAdicionarReserva.UseVisualStyleBackColor = true;
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
            this.DataGridView.Location = new System.Drawing.Point(13, 59);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(1086, 382);
            this.DataGridView.TabIndex = 203;
            // 
            // FormConsultarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1108, 470);
            this.Controls.Add(this.bntAlterarReserva);
            this.Controls.Add(this.cbFiltroReserva);
            this.Controls.Add(this.bntExportarReserva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConsultaReserva);
            this.Controls.Add(this.BntExcluirReserva);
            this.Controls.Add(this.Registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntAdicionarReserva);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Reservas de Acervos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAlterarReserva;
        private System.Windows.Forms.ComboBox cbFiltroReserva;
        private System.Windows.Forms.Button bntExportarReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsultaReserva;
        private System.Windows.Forms.Button BntExcluirReserva;
        private System.Windows.Forms.Label Registros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntAdicionarReserva;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}