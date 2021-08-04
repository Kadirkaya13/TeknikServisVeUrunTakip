using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace TeknikServis.Formlar
{
    public partial class FormQrCode : Form
    {
        public FormQrCode()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder qR = new QRCodeEncoder();
            if (txtSeriNo.Text != "")
            {
                pictureEdit1.Image = qR.Encode(txtSeriNo.Text);
            }
            else
            {
                MessageBox.Show("Doldurulmayan Alanları Doldurunuz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureEdit15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
