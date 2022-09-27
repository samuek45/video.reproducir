using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video.reproducir
{
    public partial class Form1 : Form
    {
        private string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblruta.Text = ruta;
            }
           

        }

        private void btnreproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();        }

        private void btnparar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();        }

        private void btnpausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnAbrirPdf_Click(object sender, EventArgs e)
        {
            pdfApp pdf = new pdfApp();
            pdf.Show();
            this.Hide();
        }
    }
}
