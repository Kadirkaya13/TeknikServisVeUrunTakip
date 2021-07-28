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
    public partial class FormArizaliUrunListesi : Form
    {
        public FormArizaliUrunListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void lblEnÇokUrunOlanMarka_Click(object sender, EventArgs e)
        {

        }

        void ArizaliUrunListesi()
        {
            var degerler = from x in db.UrunKabul
                           select new
                           {
                               x.IslemId,
                               x.UrunSeriNo,
                               Cari = x.Cariler.Ad +" "+ x.Cariler.Soyad,
                               Personel = x.Personel1.Ad +" "+x.Personel1.Soyad,
                               x.GelisTarihi,
                               x.CikisTarihi

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FormArizaliUrunListesi_Load(object sender, EventArgs e)
        {
            ArizaliUrunListesi();
        }
    }
}
