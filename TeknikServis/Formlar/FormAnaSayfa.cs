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
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void KritikStokListesi()
        {
            gridControl1.DataSource = (from x in db.Urun
                                       select new
                                       {
                                           x.Ad,
                                           x.Stok,
                                       }).Where(x => x.Stok < 30).ToList();
        }
        void CariListesi()
        {
            gridControl3.DataSource = (from x in db.Cariler
                                      select new
                                      {
                                          x.Ad,
                                          x.Soyad,
                                          x.Il,
                                      }).OrderBy(x=>x.Ad).ToList();
        }
        void UrunKategori()
        {
            gridControl4.DataSource = db.urunkategori().ToList();
        }
        void OkunmayanNotlar()
        {

            var degerler = (from u in db.Notlar
                           where u.Durum == false
                           select new
                           {
                               u.Icerik,
                               u.Baslik,
                               u.Tarih
                           }).Where(x=>x.Tarih==DateTime.Today);
            gridControl2.DataSource = degerler.ToList();


        }
        void Mesajlar()
        {
            string konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5,
                konu6, ad6, konu7, ad7, konu8, ad8, konu9, ad9, konu10, ad10;
            konu1 =db.Iletisim.First(x=>x.Id==1).Mesaj;
            ad1 =db.Iletisim.First(x=>x.Id==1).Ad;

            konu2 = db.Iletisim.First(x => x.Id == 2).Mesaj.ToString();
            ad2 = db.Iletisim.First(x => x.Id == 2).Ad.ToString();

            konu3 = db.Iletisim.First(x => x.Id == 3).Mesaj.ToString();
            ad3 = db.Iletisim.First(x => x.Id == 3).Ad.ToString();

            konu4 = db.Iletisim.First(x => x.Id == 4).Mesaj.ToString();
            ad4 = db.Iletisim.First(x => x.Id == 4).Ad.ToString();

            konu5 = db.Iletisim.First(x => x.Id == 5).Mesaj.ToString();
            ad5 = db.Iletisim.First(x => x.Id == 5).Ad.ToString();

            konu6 = db.Iletisim.First(x => x.Id == 6).Mesaj.ToString();
            ad6 = db.Iletisim.First(x => x.Id == 6).Ad.ToString();

            konu7 = db.Iletisim.First(x => x.Id == 7).Mesaj.ToString();
            ad7 = db.Iletisim.First(x => x.Id == 7).Ad.ToString();

            konu8 = db.Iletisim.First(x => x.Id == 8).Mesaj.ToString();
            ad8 = db.Iletisim.First(x => x.Id == 8).Ad.ToString();

            konu9 = db.Iletisim.First(x => x.Id == 9).Mesaj.ToString();
            ad9 = db.Iletisim.First(x => x.Id == 9).Ad.ToString();

            konu10 = db.Iletisim.First(x => x.Id == 10).Mesaj.ToString();
            ad10 = db.Iletisim.First(x => x.Id == 10).Ad.ToString();

            label1.Text = ad1 + " - " + konu1;
            label2.Text = ad2 + " - " + konu2;
            label3.Text = ad3 + " - " + konu3;
            label4.Text = ad4 + " - " + konu4;
            label5.Text = ad5 + " - " + konu5;
            label6.Text = ad6 + " - " + konu6;
            label7.Text = ad7 + " - " + konu7;
            label8.Text = ad8 + " - " + konu8;
            label9.Text = ad9 + " - " + konu9;
            label10.Text = ad10 + " - " + konu10;

        }
        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            KritikStokListesi();
            CariListesi();
            UrunKategori();
            OkunmayanNotlar();
            Mesajlar();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
