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
    public partial class FormFaturaKalem : Form
    {
        public FormFaturaKalem()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void FaturaKalemListesi()
        {
            var deger = from x in db.FaturaDetay
                        select new
                        {
                            x.FaturaDetayId,
                            x.FaturaId,
                            x.Urun,
                            x.Adet,
                            x.Fiyat,
                            x.Tutar,
                        };
            gridControl1.DataSource = deger.ToList();

        }
        private void FormFaturaKalem_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            FaturaKalemListesi();

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FaturaKalemListesi();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtFaturaId.Text != "" && txtAdet.Text != "" && txtFiyat.Text != "" && txtAdet.Text != "")
            {
                FaturaDetay faturaKalem = new FaturaDetay();
                faturaKalem.FaturaId = int.Parse(txtFaturaId.Text);
                faturaKalem.Adet = short.Parse(txtAdet.Text);
                faturaKalem.Fiyat = decimal.Parse(txtFiyat.Text);
                faturaKalem.Tutar = short.Parse(txtAdet.Text) * decimal.Parse(txtFiyat.Text);
                faturaKalem.Urun = txtUrun.Text;
                db.FaturaDetay.Add(faturaKalem);
                db.SaveChanges();
                MessageBox.Show("Fatura Detayı Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doldurulmayan Alanları Doldurunuz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Güncellemeyi onaylıyor musunuz ?", "UYARI !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.FaturaDetay.Find(id);
                deger.Urun = txtUrun.Text;
                deger.Adet = short.Parse(txtAdet.Text);
                deger.Fiyat = decimal.Parse(txtFiyat.Text);
                deger.Tutar = short.Parse(txtAdet.Text) * decimal.Parse(txtFiyat.Text);
                db.SaveChanges();
                MessageBox.Show("Fatura Detayı Başarı ile Güncellendi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            decimal toplam = short.Parse(txtAdet.Text) * decimal.Parse(txtFiyat.Text);
            txtTutar.Text = toplam.ToString();

        }
    }
}
