namespace Bibliotecario
{
    partial class FormConsultarCliente
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
            this.BntExcluirCliente = new System.Windows.Forms.Button();
            this.Registros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BntAdicionarCliente = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.bntAlterarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BntExcluirCliente
            // 
            this.BntExcluirCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntExcluirCliente.Location = new System.Drawing.Point(852, 15);
            this.BntExcluirCliente.Name = "BntExcluirCliente";
            this.BntExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.BntExcluirCliente.TabIndex = 4;
            this.BntExcluirCliente.Text = "Excluir";
            this.BntExcluirCliente.UseVisualStyleBackColor = true;
            this.BntExcluirCliente.Click += new System.EventHandler(this.BntExcluirCliente_Click);
            // 
            // Registros
            // 
            this.Registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Registros.AutoSize = true;
            this.Registros.Location = new System.Drawing.Point(110, 376);
            this.Registros.Name = "Registros";
            this.Registros.Size = new System.Drawing.Size(55, 15);
            this.Registros.TabIndex = 179;
            this.Registros.Text = "Registros";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 178;
            this.label1.Text = "Foram Localizados:";
            // 
            // BntAdicionarCliente
            // 
            this.BntAdicionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntAdicionarCliente.Location = new System.Drawing.Point(697, 15);
            this.BntAdicionarCliente.Name = "BntAdicionarCliente";
            this.BntAdicionarCliente.Size = new System.Drawing.Size(75, 23);
            this.BntAdicionarCliente.TabIndex = 2;
            this.BntAdicionarCliente.Text = "Adicionar";
            this.BntAdicionarCliente.UseVisualStyleBackColor = true;
            this.BntAdicionarCliente.Click += new System.EventHandler(this.BntAdicionarCliente_Click);
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
            this.DataGridView.Location = new System.Drawing.Point(9, 43);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(918, 330);
            this.DataGridView.TabIndex = 5;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Location = new System.Drawing.Point(9, 15);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(336, 23);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // bntAlterarCliente
            // 
            this.bntAlterarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAlterarCliente.Location = new System.Drawing.Point(775, 15);
            this.bntAlterarCliente.Name = "bntAlterarCliente";
            this.bntAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.bntAlterarCliente.TabIndex = 3;
            this.bntAlterarCliente.Text = "Alterar";
            this.bntAlterarCliente.UseVisualStyleBackColor = true;
            this.bntAlterarCliente.Click += new System.EventHandler(this.bntAlterarCliente_Click);
            // 
            // FormConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(933, 400);
            this.Controls.Add(this.bntAlterarCliente);
            this.Controls.Add(this.BntExcluirCliente);
            this.Controls.Add(this.Registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntAdicionarCliente);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txtCliente);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultarCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Activated += new System.EventHandler(this.FormConsultarCliente_Activated);
            this.Load += new System.EventHandler(this.FormConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntExcluirCliente;
        private System.Windows.Forms.Label Registros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntAdicionarCliente;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button bntAlterarCliente;
    }
}