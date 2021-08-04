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
    public partial class FormArizaliUrunKaydi : Form
    {
        public FormArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnGetir_Click(object sender, EventArgs e)
        {
           var deger = db.UrunHareket.SingleOrDefault(x => x.UrunSeriNo == txtUrunSeriNo.Text);
            if (deger!=null)
            {
                txtId.Text = deger.Musteri.ToString();

            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtId.Text !=""&&txtPersonel.Text!=""&& txtTarih.Text!=""&& txtUrunSeriNo.Text!="")
            {
                UrunKabul urunKabul = new UrunKabul();
                urunKabul.Cari = int.Parse(txtId.Text);
                urunKabul.Personel = short.Parse(txtPersonel.Text);
                urunKabul.GelisTarihi = DateTime.Parse(txtTarih.Text);
                urunKabul.UrunSeriNo = txtUrunSeriNo.Text;
                db.UrunKabul.Add(urunKabul);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doldurulmayan Alanları Doldurunuz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }
    }
}
