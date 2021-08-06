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
    public partial class FormCariListesi : Form
    {
        public FormCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void CariListesi()
        {
            var degerler = from u in db.Cariler
                           select new
                           {
                               u.Id,
                               u.Ad,
                               u.Soyad,
                               u.Telefon,
                               u.Mail,
                               u.Adres,
                               u.Banka,
                               u.VergiNo,
                               u.VergiAdresi,
                               u.Il,
                               u.Ilce,
                               u.Statu,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void FormCariListesi_Load(object sender, EventArgs e)
        {
            CariListesi();
            txtCariId.Enabled = false;
            lblToplamCari.Text = db.Cariler.Count().ToString();
            lblToplamIl.Text = (from x in db.Cariler select x.Il).Distinct().Count().ToString();
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CariListesi();

        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (txtCariAd.Text != "" && txtCariSoyad.Text != "" && txtMail.Text != "" && txtVergiNo.Text != "")
            {
                Cariler cari = new Cariler();
                cari.Ad = txtCariAd.Text;
                cari.Soyad = txtCariSoyad.Text;
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

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Ürünü Silmek istediğinize emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtCariId.Text);
                var deger = db.Cariler.Find(id);
                db.Cariler.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Ürün başarı ile silindi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtCariId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
                txtCariAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
                txtCariSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
                txtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
                txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
                txtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
                txtIl.Text = gridView1.GetFocusedRowCellValue("Il").ToString();
                txtIlce.Text = gridView1.GetFocusedRowCellValue("Ilce").ToString();
                txtBanka.Text = gridView1.GetFocusedRowCellValue("Banka").ToString();
                txtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VergiAdresi").ToString();
                txtVergiNo.Text = gridView1.GetFocusedRowCellValue("VergiNo").ToString();
                txtStatu.Text = gridView1.GetFocusedRowCellValue("Statu").ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu \n Hata : " + ex, "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Güncellemeyi onaylıyor musunuz ?", "UYARI !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtCariId.Text);
                var cari = db.Cariler.Find(id);
                cari.Ad = txtCariAd.Text;
                cari.Soyad = txtCariSoyad.Text;
                cari.Telefon = txtTelefon.Text;
                cari.Mail = txtMail.Text;
                cari.Adres = txtAdres.Text;
                cari.Il = txtIl.Text;
                cari.Ilce = txtIlce.Text;
                cari.Banka = txtBanka.Text;
                cari.VergiAdresi = txtVergiDairesi.Text;
                cari.VergiNo = txtVergiNo.Text;
                cari.Statu = txtStatu.Text;
                db.SaveChanges();
                MessageBox.Show("Ürün başarı ile Güncellendi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtCariId.Text = "";
            txtCariAd.Text = "";
            txtCariSoyad.Text = "";
            txtTelefon.Text = "";
            txtMail.Text = "";
            txtAdres.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtBanka.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            txtStatu.Text = "";
        }
    }
}
