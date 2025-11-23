using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace projetoSGHSS
{
    public partial class frmTeleConsulta : Form
    {
        private FilterInfoCollection videoDevices;   // Lista de dispositivos de vídeo
        private VideoCaptureDevice videoSource;      // Fonte de captura

        public frmTeleConsulta()
        {
            InitializeComponent();
        }

        private void btnIniciarPaciente_Click(object sender, EventArgs e)
        {
            // Obtém dispositivos de vídeo disponíveis
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Nenhuma câmera encontrada!");
                return;
            }

            // Seleciona a primeira câmera
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

            // Define o evento para receber os frames
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);

            // Inicia a captura
            videoSource.Start();
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Mostra o frame atual na PictureBox
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pbPaciente.Image = bitmap;
        }

        private void frmTeleConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Para a captura ao fechar o form
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}
