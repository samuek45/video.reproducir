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
    public partial class webBrowserApp : Form
    {
        public webBrowserApp()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Tener en cuenta que se abrirá la página de inicio definida en el Internet Explorer
            webBrowser1.GoHome();
        }
    }
}
