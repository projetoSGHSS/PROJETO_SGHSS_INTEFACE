namespace projetoSGHSS
{
    partial class frmMenuPrincipal
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
            this.lblTituloMenor = new System.Windows.Forms.Label();
            this.lblTituloMaior = new System.Windows.Forms.Label();
            this.btnAdministrativo = new System.Windows.Forms.Button();
            this.btnPrescricao = new System.Windows.Forms.Button();
            this.btnProfissionalSaude = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.pbTelaPrincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloMenor
            // 
            this.lblTituloMenor.AutoSize = true;
            this.lblTituloMenor.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTituloMenor.Location = new System.Drawing.Point(344, 86);
            this.lblTituloMenor.Name = "lblTituloMenor";
            this.lblTituloMenor.Size = new System.Drawing.Size(383, 44);
            this.lblTituloMenor.TabIndex = 13;
            this.lblTituloMenor.Text = "Sistema de Gerenciamento de Hospitais \r\ne Serviços de Saúde";
            this.lblTituloMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloMaior
            // 
            this.lblTituloMaior.AutoSize = true;
            this.lblTituloMaior.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMaior.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTituloMaior.Location = new System.Drawing.Point(511, 12);
            this.lblTituloMaior.Name = "lblTituloMaior";
            this.lblTituloMaior.Size = new System.Drawing.Size(127, 37);
            this.lblTituloMaior.TabIndex = 12;
            this.lblTituloMaior.Text = "SGHSS";
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdministrativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrativo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdministrativo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrativo.Image = global::projetoSGHSS.Properties.Resources.iconeAdm;
            this.btnAdministrativo.Location = new System.Drawing.Point(825, 261);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.Size = new System.Drawing.Size(198, 186);
            this.btnAdministrativo.TabIndex = 17;
            this.btnAdministrativo.Text = "Administrativo";
            this.btnAdministrativo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdministrativo.UseVisualStyleBackColor = false;
            // 
            // btnPrescricao
            // 
            this.btnPrescricao.BackColor = System.Drawing.SystemColors.Info;
            this.btnPrescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrescricao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescricao.Image = global::projetoSGHSS.Properties.Resources.iconePrescricao;
            this.btnPrescricao.Location = new System.Drawing.Point(554, 261);
            this.btnPrescricao.Name = "btnPrescricao";
            this.btnPrescricao.Size = new System.Drawing.Size(198, 186);
            this.btnPrescricao.TabIndex = 16;
            this.btnPrescricao.Text = "Prescrição";
            this.btnPrescricao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrescricao.UseVisualStyleBackColor = false;
            // 
            // btnProfissionalSaude
            // 
            this.btnProfissionalSaude.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProfissionalSaude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfissionalSaude.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfissionalSaude.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfissionalSaude.Image = global::projetoSGHSS.Properties.Resources.iconeProfissional;
            this.btnProfissionalSaude.Location = new System.Drawing.Point(283, 261);
            this.btnProfissionalSaude.Name = "btnProfissionalSaude";
            this.btnProfissionalSaude.Size = new System.Drawing.Size(198, 186);
            this.btnProfissionalSaude.TabIndex = 15;
            this.btnProfissionalSaude.Text = "Profissional";
            this.btnProfissionalSaude.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfissionalSaude.UseVisualStyleBackColor = false;
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.Image = global::projetoSGHSS.Properties.Resources.iconeUsuarios;
            this.btnPaciente.Location = new System.Drawing.Point(12, 261);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(198, 186);
            this.btnPaciente.TabIndex = 14;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // pbTelaPrincipal
            // 
            this.pbTelaPrincipal.Image = global::projetoSGHSS.Properties.Resources.iconeTelaLogin;
            this.pbTelaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pbTelaPrincipal.Name = "pbTelaPrincipal";
            this.pbTelaPrincipal.Size = new System.Drawing.Size(198, 203);
            this.pbTelaPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTelaPrincipal.TabIndex = 11;
            this.pbTelaPrincipal.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1037, 484);
            this.Controls.Add(this.btnAdministrativo);
            this.Controls.Add(this.btnPrescricao);
            this.Controls.Add(this.btnProfissionalSaude);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.lblTituloMenor);
            this.Controls.Add(this.lblTituloMaior);
            this.Controls.Add(this.pbTelaPrincipal);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Menu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMenor;
        private System.Windows.Forms.Label lblTituloMaior;
        private System.Windows.Forms.PictureBox pbTelaPrincipal;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnProfissionalSaude;
        private System.Windows.Forms.Button btnPrescricao;
        private System.Windows.Forms.Button btnAdministrativo;
    }
}