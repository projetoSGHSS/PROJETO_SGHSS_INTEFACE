namespace projetoSGHSS
{
    partial class frmTeleConsulta
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
            this.tlpTeleconsulta = new System.Windows.Forms.TableLayoutPanel();
            this.pbPaciente = new System.Windows.Forms.PictureBox();
            this.pbProfissional = new System.Windows.Forms.PictureBox();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.gbProfissional = new System.Windows.Forms.GroupBox();
            this.btnIniciarPaciente = new System.Windows.Forms.Button();
            this.btnIniciarProfissional = new System.Windows.Forms.Button();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblNomeProfissional = new System.Windows.Forms.Label();
            this.tlpTeleconsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfissional)).BeginInit();
            this.gbPaciente.SuspendLayout();
            this.gbProfissional.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTeleconsulta
            // 
            this.tlpTeleconsulta.ColumnCount = 2;
            this.tlpTeleconsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTeleconsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTeleconsulta.Controls.Add(this.pbPaciente, 0, 0);
            this.tlpTeleconsulta.Controls.Add(this.pbProfissional, 1, 0);
            this.tlpTeleconsulta.Controls.Add(this.gbPaciente, 0, 1);
            this.tlpTeleconsulta.Controls.Add(this.gbProfissional, 1, 1);
            this.tlpTeleconsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTeleconsulta.Location = new System.Drawing.Point(0, 0);
            this.tlpTeleconsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpTeleconsulta.Name = "tlpTeleconsulta";
            this.tlpTeleconsulta.RowCount = 2;
            this.tlpTeleconsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTeleconsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTeleconsulta.Size = new System.Drawing.Size(753, 424);
            this.tlpTeleconsulta.TabIndex = 0;
            // 
            // pbPaciente
            // 
            this.pbPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPaciente.Location = new System.Drawing.Point(4, 4);
            this.pbPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPaciente.Name = "pbPaciente";
            this.pbPaciente.Size = new System.Drawing.Size(368, 204);
            this.pbPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPaciente.TabIndex = 0;
            this.pbPaciente.TabStop = false;
            // 
            // pbProfissional
            // 
            this.pbProfissional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProfissional.Location = new System.Drawing.Point(380, 4);
            this.pbProfissional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbProfissional.Name = "pbProfissional";
            this.pbProfissional.Size = new System.Drawing.Size(369, 204);
            this.pbProfissional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfissional.TabIndex = 1;
            this.pbProfissional.TabStop = false;
            // 
            // gbPaciente
            // 
            this.gbPaciente.Controls.Add(this.lblNomePaciente);
            this.gbPaciente.Controls.Add(this.btnIniciarPaciente);
            this.gbPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaciente.Location = new System.Drawing.Point(4, 216);
            this.gbPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPaciente.Size = new System.Drawing.Size(368, 204);
            this.gbPaciente.TabIndex = 2;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Tela do paciente";
            // 
            // gbProfissional
            // 
            this.gbProfissional.Controls.Add(this.lblNomeProfissional);
            this.gbProfissional.Controls.Add(this.btnIniciarProfissional);
            this.gbProfissional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProfissional.Location = new System.Drawing.Point(380, 216);
            this.gbProfissional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProfissional.Name = "gbProfissional";
            this.gbProfissional.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProfissional.Size = new System.Drawing.Size(369, 204);
            this.gbProfissional.TabIndex = 3;
            this.gbProfissional.TabStop = false;
            this.gbProfissional.Text = "tela do profissional";
            // 
            // btnIniciarPaciente
            // 
            this.btnIniciarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarPaciente.BackColor = System.Drawing.Color.LightGreen;
            this.btnIniciarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPaciente.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnIniciarPaciente.Location = new System.Drawing.Point(7, 26);
            this.btnIniciarPaciente.Name = "btnIniciarPaciente";
            this.btnIniciarPaciente.Size = new System.Drawing.Size(353, 53);
            this.btnIniciarPaciente.TabIndex = 0;
            this.btnIniciarPaciente.Text = "Iniciar Teleconsulta";
            this.btnIniciarPaciente.UseVisualStyleBackColor = false;
            this.btnIniciarPaciente.Click += new System.EventHandler(this.btnIniciarPaciente_Click);
            // 
            // btnIniciarProfissional
            // 
            this.btnIniciarProfissional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarProfissional.BackColor = System.Drawing.Color.LightYellow;
            this.btnIniciarProfissional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarProfissional.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarProfissional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarProfissional.ForeColor = System.Drawing.Color.Firebrick;
            this.btnIniciarProfissional.Location = new System.Drawing.Point(8, 26);
            this.btnIniciarProfissional.Name = "btnIniciarProfissional";
            this.btnIniciarProfissional.Size = new System.Drawing.Size(353, 53);
            this.btnIniciarProfissional.TabIndex = 1;
            this.btnIniciarProfissional.Text = "Iniciar Teleconsulta";
            this.btnIniciarProfissional.UseVisualStyleBackColor = false;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.Location = new System.Drawing.Point(8, 105);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(153, 19);
            this.lblNomePaciente.TabIndex = 1;
            this.lblNomePaciente.Text = "Nome do paciente:";
            // 
            // lblNomeProfissional
            // 
            this.lblNomeProfissional.AutoSize = true;
            this.lblNomeProfissional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfissional.Location = new System.Drawing.Point(7, 105);
            this.lblNomeProfissional.Name = "lblNomeProfissional";
            this.lblNomeProfissional.Size = new System.Drawing.Size(178, 19);
            this.lblNomeProfissional.TabIndex = 2;
            this.lblNomeProfissional.Text = "Nome do profissional:";
            // 
            // frmTeleConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(753, 424);
            this.Controls.Add(this.tlpTeleconsulta);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTeleConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGHSS - TeleConsulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeleConsulta_FormClosing);
            this.tlpTeleconsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfissional)).EndInit();
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.gbProfissional.ResumeLayout(false);
            this.gbProfissional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTeleconsulta;
        private System.Windows.Forms.PictureBox pbPaciente;
        private System.Windows.Forms.PictureBox pbProfissional;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.GroupBox gbProfissional;
        private System.Windows.Forms.Button btnIniciarPaciente;
        private System.Windows.Forms.Button btnIniciarProfissional;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblNomeProfissional;
    }
}