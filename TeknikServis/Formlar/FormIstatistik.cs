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
    public partial class FormIstatistik : Form
    {
        public FormIstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FormIstatistik_Load(object sender, EventArgs e)
        {
            lblUrunSayi.Text = db.Urun.Count().ToString();
            lblKategoriSayi.Text = db.Kategori.Count().ToString();
            lblStokSayi.Text = db.Urun.Sum(x => x.Stok).ToString();
            lblKritSayi.Text = "30";
            lblStokTaEnCokUrun.Text = (from x in db.Urun orderby x.Stok descending select x.Ad).FirstOrDefault();
            lblStoktaEnAzUrun.Text = (from x in db.Urun orderby x.Stok ascending select x.Ad).FirstOrDefault();
            lblEnYuksekFiyatliUrun.Text = (from x in db.Urun orderby x.SatisFiyat descending select x.Ad).FirstOrDefault();
            lblEnDusukFiyatlUrun.Text = (from x in db.Urun orderby x.SatisFiyat ascending select x.Ad).FirstOrDefault();
            lblBeyazEsya.Text = db.Urun.Count(x=>x.Kategori==4).ToString();
            lblToplamBilgisayar.Text = db.Urun.Count(x=>x.Kategori==1).ToString();
            lblKucukEvaletSayı.Text = db.Urun.Count(x=>x.Kategori==3).ToString();
            lblToplamMarka.Text = (from x in db.Urun select x.Marka).Distinct().Count().ToString();
            lblToplamStokSayisi.Text = db.Urun.Sum(x => x.Stok).ToString();
            lblEnCokUrunBulunanKategori.Text = (db.Urun.OrderBy(x => x.Kategori1.Ad).GroupBy(y => y.Kategori1.Ad).Select(z => new
            {
                Kategori = z.Key,
                Toplam = z.Count()
            }).Select(c => c.Kategori).OrderBy(x => x).FirstOrDefault()).ToString();
            lblToplamSatilanUrun.Text = db.FaturaDetay.Sum(x => x.Adet).ToString();
            lblSatilanUrun.Text= db.FaturaDetay.Sum(x => x.Adet).ToString();

        }

        private void pictureEdit18_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
