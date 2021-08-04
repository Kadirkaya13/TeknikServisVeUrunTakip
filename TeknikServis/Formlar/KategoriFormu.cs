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
    public partial class KategoriFormu : Form
    {
        public KategoriFormu()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void KategoriListesi()
        {
            var degerler = from u in db.Kategori
                           select new
                           {
                               u.Id,
                               u.Ad,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KategoriListesi();
        }



        private void gridControl1_Click(object sender, EventArgs e)
        {

        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtKategoriId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtKategoriAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void KategoriFormu_Load(object sender, EventArgs e)
        {
            KategoriListesi();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            KategoriListesi();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text != "")
            {
                Kategori kategori = new Kategori();
                kategori.Ad = txtKategoriAd.Text;
                db.Kategori.Add(kategori);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doldurulmayan Alanları Doldurunuz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Kategoryi Silmek istediğinize emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtKategoriId.Text);
                var deger = db.Kategori.Find(id);
                db.Kategori.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Kategori başarı ile silindi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Güncellemeyi onaylıyor musunuz ?", "UYARI !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtKategoriId.Text);
                var deger = db.Kategori.Find(id);
                deger.Ad = txtKategoriAd.Text;
                db.SaveChanges();
                MessageBox.Show("Kategori başarı ile Güncellendi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtKategoriId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtKategoriAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtKategoriId.Text = "";
            txtKategoriAd.Text = "";
        }
    }
}
