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
    public partial class FormYeniUrun : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FormYeniUrun()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormYeniUrun_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Ad = txtAd.Text;
            urun.Marka = txtMarka.Text;
            urun.AlisFiyat = Convert.ToDecimal(txtAlısFiyat.Text);
            urun.SatisFiyat = Convert.ToDecimal(txtSatisFiyat.Text);
            urun.Stok = Convert.ToInt16(txtStok.Text);
            urun.Durum = false;
            urun.Kategori = byte.Parse(txtKategori.Text);
            db.Urun.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
