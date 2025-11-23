using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoSGHSS
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void btnAbrirTeleconsulta_Click(object sender, EventArgs e)
        {
            frmTeleConsulta ftc = new frmTeleConsulta();
            ftc.ShowDialog();
        }
    }
}
