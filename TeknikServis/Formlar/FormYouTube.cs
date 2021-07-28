using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FormYouTube : Form
    {
        public FormYouTube()
        {
            InitializeComponent();
        }

        private void FormYouTube_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=xPYVfLeZJo0&ab_channel=khaleesi%27sZone");
        }
    }
}
