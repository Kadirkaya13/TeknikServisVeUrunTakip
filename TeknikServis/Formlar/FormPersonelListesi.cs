using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FormPersonelListesi : Form
    {
        public FormPersonelListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void PersonelListele()
        {
            var degerler = from u in db.Personel
                           select new
                           {
                               u.Id,
                               u.Ad,
                               u.Soyad,
                               u.Telefon,
                               u.Mail,
                               Departman = u.Departman1.Ad,

                           };
            gridControl1.DataSource = degerler.ToList();
        }

        void personelBilgisi_1()
        {
            string ad = db.Personel.First(x => x.Id == 1).Ad;
            string soyad = db.Personel.First(x => x.Id == 1).Soyad;
            lblAd_1.Text = ad + " " + soyad;
            lblDep_1.Text = db.Personel.First(x => x.Id == 1).Departman1.Ad;
            lblMail_1.Text = db.Personel.First(x => x.Id == 1).Mail;
        }
        void personelBilgisi_2()
        {
            string ad = db.Personel.First(x => x.Id == 2).Ad;
            string soyad = db.Personel.First(x => x.Id == 2).Soyad;
            lblAd_2.Text = ad + " " + soyad;
            lblDep_2.Text = db.Personel.First(x => x.Id == 2).Departman1.Ad;
            lblMail_2.Text = db.Personel.First(x => x.Id == 2).Mail;
        }
        void personelBilgisi_3()
        {
            string ad = db.Personel.First(x => x.Id == 3).Ad;
            string soyad = db.Personel.First(x => x.Id == 3).Soyad;
            lblAd_3.Text = ad + " " + soyad;
            lblDep_3.Text = db.Personel.First(x => x.Id == 3).Departman1.Ad;
            lblMail_3.Text = db.Personel.First(x => x.Id == 3).Mail;
        }
        void personelBilgisi_4()
        {
            string ad = db.Personel.First(x => x.Id == 4).Ad;
            string soyad = db.Personel.First(x => x.Id == 4).Soyad;
            lblAd_4.Text = ad + " " + soyad;
            lblDep_4.Text = db.Personel.First(x => x.Id == 4).Departman1.Ad;
            lblMail_4.Text = db.Personel.First(x => x.Id == 4).Mail;
        }
        void DepartmanListele()
        {
            lookUpEdit1.Properties.DataSource = (from x in db.Departman
                                                 select new
                                                 {
                                                     x.Id,
                                                     x.Ad
                                                 }).ToList();
        }
        private void FormPersonelListesi_Load(object sender, EventArgs e)
        {
            PersonelListele();
            personelBilgisi_1();
            personelBilgisi_2();
            personelBilgisi_3();
            personelBilgisi_4();
            DepartmanListele();
            txtPersonelId.Enabled = false;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text != "" && txtPersonelSoyad.Text != "" && txtMail.Text != "" && txtTelefon.Text != "")
            {
                Personel personel = new Personel();
                personel.Ad = txtPersonelAd.Text;
                personel.Soyad = txtPersonelSoyad.Text;
                personel.Mail = txtMail.Text;
                personel.Telefon = txtTelefon.Text;
                personel.Departman = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.Personel.Add(personel);
                db.SaveChanges();
                MessageBox.Show("Başarı ile eklendi");
            }
            else
            {
                MessageBox.Show("Doldurulmayan Alanları Doldurunuz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtPersonelId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
                txtPersonelAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
                txtPersonelSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
                txtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
                txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
                lookUpEdit1.EditValue = gridView1.GetFocusedRowCellValue("Departman").ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu \n Hata : " + ex, "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Personeli Silmek istediğinize emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtPersonelId.Text);
                var deger = db.Personel.Find(id);
                db.Personel.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Personeli başarı ile silindi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Güncellemeyi onaylıyor musunuz ?", "UYARI !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtPersonelId.Text);
                var deger = db.Personel.Find(id);
                deger.Ad = txtPersonelAd.Text;
                deger.Soyad = txtPersonelSoyad.Text;
                deger.Mail = txtMail.Text;
                deger.Telefon = txtTelefon.Text;
                deger.Departman = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Personel başarı ile Güncellendi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtPersonelId.Text = "";
            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";
            txtTelefon.Text = "";
            txtMail.Text = "";
            lookUpEdit1.EditValue = "";
        }
    }
}
