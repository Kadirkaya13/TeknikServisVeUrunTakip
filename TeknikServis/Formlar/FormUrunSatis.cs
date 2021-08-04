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
    public partial class FormUrunSatis : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public FormUrunSatis()
        {
            InitializeComponent();
        }

        private void FormUrunSatis_Load(object sender, EventArgs e)
        {

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtMusteri.Text!=""&& txtPersonel.Text != "" && txtTarih.Text != "" && txtSatisFiyat.Text != "" && txtAdet.Text != "" && txtUrunSeriNo.Text != "")
            {
                UrunHareket urun = new UrunHareket();
                urun.Urun = int.Parse(txtId.Text);
                urun.Musteri = int.Parse(txtMusteri.Text);
                urun.Personel = short.Parse(txtPersonel.Text);
                urun.Tarih = Convert.ToDateTime(txtTarih.Text);
                urun.Fiyat = Convert.ToInt32(txtSatisFiyat.Text);
                urun.Adet = Convert.ToInt16(txtAdet.Text);
                urun.UrunSeriNo = txtUrunSeriNo.Text;
                db.UrunHareket.Add(urun);
                db.SaveChanges();
                MessageBox.Show("Ürün Satışı Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
