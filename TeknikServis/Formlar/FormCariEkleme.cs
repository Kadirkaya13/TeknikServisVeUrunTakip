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
    public partial class FormCariEkleme : Form
    {
        public FormCariEkleme()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text!=""&& txtSoyad.Text!=""&& txtMail.Text!=""&& txtVergiNo.Text!="")
            {
                Cariler cari = new Cariler();
                cari.Ad = txtAd.Text;
                cari.Soyad = txtSoyad.Text;
                cari.Telefon = txtTelefon.Text;
                cari.Mail = txtMail.Text;
                cari.Adres = txtAdres.Text;
                cari.Il = txtIl.Text;
                cari.Ilce = txtIlce.Text;
                cari.Banka = txtBanka.Text;
                cari.VergiAdresi = txtVergiDairesi.Text;
                cari.VergiNo = txtVergiNo.Text;
                cari.Statu = txtStatu.Text;
                db.Cariler.Add(cari);
                db.SaveChanges();
                MessageBox.Show("Cari Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
