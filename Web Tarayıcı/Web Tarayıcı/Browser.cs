using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Tarayıcı
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void Git_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(aramayeri.Text);
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void İleri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
