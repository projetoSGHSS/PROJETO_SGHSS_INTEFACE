namespace projetoSGHSS
{
    partial class frmPaciente
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
            this.btnAbrirPrescricao = new System.Windows.Forms.Button();
            this.btnAbrirTeleconsulta = new System.Windows.Forms.Button();
            this.btnAgendarTeleConsulta = new System.Windows.Forms.Button();
            this.btnAgendarConsulta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirPrescricao
            // 
            this.btnAbrirPrescricao.BackColor = System.Drawing.Color.Azure;
            this.btnAbrirPrescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirPrescricao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirPrescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPrescricao.Location = new System.Drawing.Point(371, 127);
            this.btnAbrirPrescricao.Name = "btnAbrirPrescricao";
            this.btnAbrirPrescricao.Size = new System.Drawing.Size(175, 86);
            this.btnAbrirPrescricao.TabIndex = 9;
            this.btnAbrirPrescricao.Text = "Abrir Prescrição";
            this.btnAbrirPrescricao.UseVisualStyleBackColor = false;
            // 
            // btnAbrirTeleconsulta
            // 
            this.btnAbrirTeleconsulta.BackColor = System.Drawing.Color.LightYellow;
            this.btnAbrirTeleconsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirTeleconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirTeleconsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirTeleconsulta.Location = new System.Drawing.Point(190, 127);
            this.btnAbrirTeleconsulta.Name = "btnAbrirTeleconsulta";
            this.btnAbrirTeleconsulta.Size = new System.Drawing.Size(175, 86);
            this.btnAbrirTeleconsulta.TabIndex = 8;
            this.btnAbrirTeleconsulta.Text = "Abrir Teleconsulta";
            this.btnAbrirTeleconsulta.UseVisualStyleBackColor = false;
            this.btnAbrirTeleconsulta.Click += new System.EventHandler(this.btnAbrirTeleconsulta_Click);
            // 
            // btnAgendarTeleConsulta
            // 
            this.btnAgendarTeleConsulta.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgendarTeleConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendarTeleConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgendarTeleConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarTeleConsulta.Location = new System.Drawing.Point(371, 12);
            this.btnAgendarTeleConsulta.Name = "btnAgendarTeleConsulta";
            this.btnAgendarTeleConsulta.Size = new System.Drawing.Size(175, 86);
            this.btnAgendarTeleConsulta.TabIndex = 7;
            this.btnAgendarTeleConsulta.Text = "Agendar Teleconsulta";
            this.btnAgendarTeleConsulta.UseVisualStyleBackColor = false;
            // 
            // btnAgendarConsulta
            // 
            this.btnAgendarConsulta.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgendarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgendarConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarConsulta.Location = new System.Drawing.Point(190, 12);
            this.btnAgendarConsulta.Name = "btnAgendarConsulta";
            this.btnAgendarConsulta.Size = new System.Drawing.Size(175, 86);
            this.btnAgendarConsulta.TabIndex = 6;
            this.btnAgendarConsulta.Text = "Agendar Consulta";
            this.btnAgendarConsulta.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoSGHSS.Properties.Resources.iconeUsuariosMaior;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(568, 412);
            this.Controls.Add(this.btnAbrirPrescricao);
            this.Controls.Add(this.btnAbrirTeleconsulta);
            this.Controls.Add(this.btnAgendarTeleConsulta);
            this.Controls.Add(this.btnAgendarConsulta);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPaciente";
            this.Text = "SGHSS - Tela Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirPrescricao;
        private System.Windows.Forms.Button btnAbrirTeleconsulta;
        private System.Windows.Forms.Button btnAgendarTeleConsulta;
        private System.Windows.Forms.Button btnAgendarConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}