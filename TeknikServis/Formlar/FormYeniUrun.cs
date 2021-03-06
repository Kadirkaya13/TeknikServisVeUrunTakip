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
        private void FormYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEditKategoriler();
        }
        void lookUpEditKategoriler()
        {
            lookUpEdit1.Properties.DataSource = (from x in db.Kategori
                                                 select new
                                                 {
                                                     x.Id,
                                                     x.Ad
                                                 }).ToList();
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


        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtMarka.Text != "" && txtAlısFiyat.Text != "" && txtSatisFiyat.Text != "" && txtStok.Text != "")
            {
                Urun urun = new Urun();
                urun.Ad = txtAd.Text;
                urun.Marka = txtMarka.Text;
                urun.AlisFiyat = Convert.ToDecimal(txtAlısFiyat.Text);
                urun.SatisFiyat = Convert.ToDecimal(txtSatisFiyat.Text);
                urun.Stok = Convert.ToInt16(txtStok.Text);
                urun.Durum = false;
                urun.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.Urun.Add(urun);
                db.SaveChanges();
                MessageBox.Show("Ürün Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
