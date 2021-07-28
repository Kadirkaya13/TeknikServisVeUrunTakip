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
    public partial class FormSatislar : Form
    {
        public FormSatislar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void Liste()
        {
            var degerler = from x in db.UrunHareket
                           select new
                           {
                               x.HareketId,
                               x.UrunSeriNo,
                               Urun = x.Urun1.Ad,
                               Musteri = x.Cariler.Ad + " " + x.Cariler.Soyad,
                               Personel = x.Personel1.Ad + " " + x.Personel1.Soyad,
                               x.Adet,
                               x.Fiyat,
                               x.Tarih,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FormSatislar_Load(object sender, EventArgs e)
        {
            Liste();
        }
    }
}
