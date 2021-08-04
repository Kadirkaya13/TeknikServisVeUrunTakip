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
    public partial class FormYeniDepartman : Form
    {
        public FormYeniDepartman()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text!="")
            {
                Departman departman = new Departman();
                departman.Ad = txtAd.Text;
                db.Departman.Add(departman);
                db.SaveChanges();
                MessageBox.Show("Departman Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
