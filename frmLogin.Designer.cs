namespace projetoSGHSS
{
    partial class frmLogin
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
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaHashUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTituloMaior = new System.Windows.Forms.Label();
            this.lblTituloMenor = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pbTelaLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(8, 190);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(289, 26);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // txtSenhaHashUsuario
            // 
            this.txtSenhaHashUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaHashUsuario.Location = new System.Drawing.Point(8, 299);
            this.txtSenhaHashUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenhaHashUsuario.Name = "txtSenhaHashUsuario";
            this.txtSenhaHashUsuario.Size = new System.Drawing.Size(289, 26);
            this.txtSenhaHashUsuario.TabIndex = 3;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUsuario.Location = new System.Drawing.Point(8, 244);
            this.txtEmailUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(289, 26);
            this.txtEmailUsuario.TabIndex = 2;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(8, 354);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(289, 26);
            this.cbTipoUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUsuario.Location = new System.Drawing.Point(5, 169);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 19);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmail.Location = new System.Drawing.Point(5, 224);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 19);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSenha.Location = new System.Drawing.Point(5, 278);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 19);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTipo.Location = new System.Drawing.Point(5, 333);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 19);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblTituloMaior
            // 
            this.lblTituloMaior.AutoSize = true;
            this.lblTituloMaior.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMaior.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTituloMaior.Location = new System.Drawing.Point(255, 30);
            this.lblTituloMaior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloMaior.Name = "lblTituloMaior";
            this.lblTituloMaior.Size = new System.Drawing.Size(127, 37);
            this.lblTituloMaior.TabIndex = 9;
            this.lblTituloMaior.Text = "SGHSS";
            // 
            // lblTituloMenor
            // 
            this.lblTituloMenor.AutoSize = true;
            this.lblTituloMenor.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTituloMenor.Location = new System.Drawing.Point(144, 78);
            this.lblTituloMenor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloMenor.Name = "lblTituloMenor";
            this.lblTituloMenor.Size = new System.Drawing.Size(383, 44);
            this.lblTituloMenor.TabIndex = 10;
            this.lblTituloMenor.Text = "Sistema de Gerenciamento de Hospitais \r\ne Serviços de Saúde";
            this.lblTituloMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Salmon;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::projetoSGHSS.Properties.Resources.fechar;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(417, 285);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 53);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCadastrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.Image = global::projetoSGHSS.Properties.Resources.usuarioMenor;
            this.btnCadastrarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(307, 285);
            this.btnCadastrarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(106, 53);
            this.btnCadastrarUsuario.TabIndex = 6;
            this.btnCadastrarUsuario.Text = "Novo";
            this.btnCadastrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Image = global::projetoSGHSS.Properties.Resources.salvar;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrar.Location = new System.Drawing.Point(307, 228);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(203, 53);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pbTelaLogin
            // 
            this.pbTelaLogin.Image = global::projetoSGHSS.Properties.Resources.iconeTelaLogin;
            this.pbTelaLogin.Location = new System.Drawing.Point(8, 8);
            this.pbTelaLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pbTelaLogin.Name = "pbTelaLogin";
            this.pbTelaLogin.Size = new System.Drawing.Size(132, 132);
            this.pbTelaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTelaLogin.TabIndex = 0;
            this.pbTelaLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(518, 399);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblTituloMenor);
            this.Controls.Add(this.lblTituloMaior);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.txtSenhaHashUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.pbTelaLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGHSS - Tela de Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTelaLogin;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtSenhaHashUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTituloMaior;
        private System.Windows.Forms.Label lblTituloMenor;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrarUsuario;
    }
}

