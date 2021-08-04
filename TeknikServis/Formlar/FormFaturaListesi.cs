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
    public partial class FormFaturaListesi : Form
    {
        public FormFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void FaturaListe()
        {
            var deger = from x in db.FaturaBilgi
                        select new
                        {
                            x.Id,
                            x.Seri,
                            x.SıraNo,
                            Cari = x.Cariler.Ad + " " + x.Cariler.Soyad,
                            Personel = x.Personel1.Ad + " " + x.Personel1.Soyad,
                            x.VergiDaire,
                            x.Saat,
                            x.Tarih,
                        };
            gridControl1.DataSource = deger.ToList();
        }
        void CariLookUpEdit()
        {
            lueCari.Properties.DataSource = (from x in db.Cariler
                                             select new
                                             {
                                                 x.Id,
                                                 Cari = x.Ad + " " + x.Soyad,
                                             }).ToList();
        }
        void PersonelLookUpEdit()
        {
            luePersonel.Properties.DataSource = (from x in db.Personel
                                                 select new
                                                 {
                                                     x.Id,
                                                     Personel = x.Ad + " " + x.Soyad,
                                                     Departman = x.Departman1.Ad,
                                                 }).ToList();
        }
        private void FormFaturaListesi_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            FaturaListe();
            PersonelLookUpEdit();
            CariLookUpEdit();


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FaturaListe();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSeri.Text != "" && txtSiraNo.Text != "" && txtSaat.Text != "" && txtTarih.Text != "" && txtVergiDairesi.Text != "")
            {
                FaturaBilgi faturaBilgi = new FaturaBilgi();
                faturaBilgi.Seri = txtSeri.Text;
                faturaBilgi.SıraNo = txtSiraNo.Text;
                faturaBilgi.Saat = txtSaat.Text;
                faturaBilgi.Tarih = DateTime.Parse(txtTarih.Text);
                faturaBilgi.VergiDaire = txtVergiDairesi.Text;
                faturaBilgi.Cari = byte.Parse(lueCari.EditValue.ToString());
                faturaBilgi.Personel = byte.Parse(luePersonel.EditValue.ToString());
                db.FaturaBilgi.Add(faturaBilgi);
                db.SaveChanges();
                MessageBox.Show("Fatura Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doldurulmayan Alanları Doldurunuz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
