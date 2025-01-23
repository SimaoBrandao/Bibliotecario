namespace Bibliotecario
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acervosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpréstimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acervosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acervoMaisLidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acervoNuncaEmprestadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UtilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeSegurançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reposicaoCopiaDeSegurancaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesDeEmpréstimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UtilizadorLogadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TerminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.EmpréstimosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.administraçãoToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.UtilizadorLogadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.formatosToolStripMenuItem,
            this.acervosToolStripMenuItem,
            this.modalidadesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reservasToolStripMenuItem1});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.categoriaToolStripMenuItem.Text = "Categorias";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // formatosToolStripMenuItem
            // 
            this.formatosToolStripMenuItem.Name = "formatosToolStripMenuItem";
            this.formatosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.formatosToolStripMenuItem.Text = "Formatos";
            this.formatosToolStripMenuItem.Click += new System.EventHandler(this.formatosToolStripMenuItem_Click);
            // 
            // acervosToolStripMenuItem
            // 
            this.acervosToolStripMenuItem.Name = "acervosToolStripMenuItem";
            this.acervosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.acervosToolStripMenuItem.Text = "Acervos";
            this.acervosToolStripMenuItem.Click += new System.EventHandler(this.acervosToolStripMenuItem_Click);
            // 
            // modalidadesToolStripMenuItem
            // 
            this.modalidadesToolStripMenuItem.Name = "modalidadesToolStripMenuItem";
            this.modalidadesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.modalidadesToolStripMenuItem.Text = "Modalidades";
            this.modalidadesToolStripMenuItem.Click += new System.EventHandler(this.modalidadesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem1
            // 
            this.reservasToolStripMenuItem1.Name = "reservasToolStripMenuItem1";
            this.reservasToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.reservasToolStripMenuItem1.Text = "Reservas";
            // 
            // EmpréstimosToolStripMenuItem
            // 
            this.EmpréstimosToolStripMenuItem.Name = "EmpréstimosToolStripMenuItem";
            this.EmpréstimosToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.EmpréstimosToolStripMenuItem.Text = "Empréstimos";
            this.EmpréstimosToolStripMenuItem.Click += new System.EventHandler(this.EmpréstimosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acervosCadastradosToolStripMenuItem,
            this.acervoMaisLidoToolStripMenuItem,
            this.acervoNuncaEmprestadoToolStripMenuItem,
            this.relatórioDeEmpréstimoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // acervosCadastradosToolStripMenuItem
            // 
            this.acervosCadastradosToolStripMenuItem.Name = "acervosCadastradosToolStripMenuItem";
            this.acervosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.acervosCadastradosToolStripMenuItem.Text = "Acervos Cadastrados";
            // 
            // acervoMaisLidoToolStripMenuItem
            // 
            this.acervoMaisLidoToolStripMenuItem.Name = "acervoMaisLidoToolStripMenuItem";
            this.acervoMaisLidoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.acervoMaisLidoToolStripMenuItem.Text = "Acervos mais Solicitados";
            // 
            // acervoNuncaEmprestadoToolStripMenuItem
            // 
            this.acervoNuncaEmprestadoToolStripMenuItem.Name = "acervoNuncaEmprestadoToolStripMenuItem";
            this.acervoNuncaEmprestadoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.acervoNuncaEmprestadoToolStripMenuItem.Text = "Acervos nunca Emprestado";
            // 
            // relatórioDeEmpréstimoToolStripMenuItem
            // 
            this.relatórioDeEmpréstimoToolStripMenuItem.Name = "relatórioDeEmpréstimoToolStripMenuItem";
            this.relatórioDeEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.relatórioDeEmpréstimoToolStripMenuItem.Text = "Relatório de Empréstimo";
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bibliotecaToolStripMenuItem,
            this.UtilizadoresToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.configuraçõesDeEmpréstimosToolStripMenuItem});
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // bibliotecaToolStripMenuItem
            // 
            this.bibliotecaToolStripMenuItem.Name = "bibliotecaToolStripMenuItem";
            this.bibliotecaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.bibliotecaToolStripMenuItem.Text = "Biblioteca";
            this.bibliotecaToolStripMenuItem.Click += new System.EventHandler(this.bibliotecaToolStripMenuItem_Click);
            // 
            // UtilizadoresToolStripMenuItem
            // 
            this.UtilizadoresToolStripMenuItem.Name = "UtilizadoresToolStripMenuItem";
            this.UtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.UtilizadoresToolStripMenuItem.Text = "Utilizadores";
            this.UtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.UtilizadoresToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaDeSegurançaToolStripMenuItem,
            this.reposicaoCopiaDeSegurancaToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // copiaDeSegurançaToolStripMenuItem
            // 
            this.copiaDeSegurançaToolStripMenuItem.Name = "copiaDeSegurançaToolStripMenuItem";
            this.copiaDeSegurançaToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.copiaDeSegurançaToolStripMenuItem.Text = "Cópia de Segurança";
            this.copiaDeSegurançaToolStripMenuItem.Click += new System.EventHandler(this.copiaDeSegurançaToolStripMenuItem_Click);
            // 
            // reposicaoCopiaDeSegurancaToolStripMenuItem
            // 
            this.reposicaoCopiaDeSegurancaToolStripMenuItem.Name = "reposicaoCopiaDeSegurancaToolStripMenuItem";
            this.reposicaoCopiaDeSegurancaToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.reposicaoCopiaDeSegurancaToolStripMenuItem.Text = "Reposição da Cópia de Segurança";
            this.reposicaoCopiaDeSegurancaToolStripMenuItem.Click += new System.EventHandler(this.reposicaoCopiaDeSegurancaToolStripMenuItem_Click);
            // 
            // configuraçõesDeEmpréstimosToolStripMenuItem
            // 
            this.configuraçõesDeEmpréstimosToolStripMenuItem.Name = "configuraçõesDeEmpréstimosToolStripMenuItem";
            this.configuraçõesDeEmpréstimosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.configuraçõesDeEmpréstimosToolStripMenuItem.Text = "Gestão de Empréstimos";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // AcercaToolStripMenuItem
            // 
            this.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem";
            this.AcercaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.AcercaToolStripMenuItem.Text = "Acerca";
            this.AcercaToolStripMenuItem.Click += new System.EventHandler(this.AcercaToolStripMenuItem_Click);
            // 
            // UtilizadorLogadoToolStripMenuItem
            // 
            this.UtilizadorLogadoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UtilizadorLogadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaContaToolStripMenuItem,
            this.toolStripSeparator1,
            this.TerminarSessãoToolStripMenuItem});
            this.UtilizadorLogadoToolStripMenuItem.Image = global::Bibliotecario.Properties.Resources.no_picture;
            this.UtilizadorLogadoToolStripMenuItem.Name = "UtilizadorLogadoToolStripMenuItem";
            this.UtilizadorLogadoToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.UtilizadorLogadoToolStripMenuItem.Text = "Utilizador da Conta";
            // 
            // minhaContaToolStripMenuItem
            // 
            this.minhaContaToolStripMenuItem.Name = "minhaContaToolStripMenuItem";
            this.minhaContaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.minhaContaToolStripMenuItem.Text = "Minha conta";
            this.minhaContaToolStripMenuItem.Click += new System.EventHandler(this.minhaContaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // TerminarSessãoToolStripMenuItem
            // 
            this.TerminarSessãoToolStripMenuItem.Name = "TerminarSessãoToolStripMenuItem";
            this.TerminarSessãoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.TerminarSessãoToolStripMenuItem.Text = "Terminar sessão";
            this.TerminarSessãoToolStripMenuItem.Click += new System.EventHandler(this.TerminarSessãoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotecário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AcercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UtilizadorLogadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TerminarSessãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UtilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaDeSegurançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reposicaoCopiaDeSegurancaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acervosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acervosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acervoMaisLidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeEmpréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliotecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesDeEmpréstimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acervoNuncaEmprestadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpréstimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modalidadesToolStripMenuItem;
    }
}

