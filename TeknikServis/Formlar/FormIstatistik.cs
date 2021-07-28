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
            lblKritSayi.Text = "10";
            lblStokTaEnCokUrun.Text = (from x in db.Urun orderby x.Stok descending select x.Ad).FirstOrDefault();
            lblStoktaEnAzUrun.Text = (from x in db.Urun orderby x.Stok ascending select x.Ad).FirstOrDefault();
            lblEnYuksekFiyatliUrun.Text = (from x in db.Urun orderby x.SatisFiyat descending select x.Ad).FirstOrDefault();
            lblEnDusukFiyatlUrun.Text = (from x in db.Urun orderby x.SatisFiyat ascending select x.Ad).FirstOrDefault();
            lblBeyazEsya.Text = db.Urun.Count(x=>x.Kategori==4).ToString();
            lblToplamBilgisayar.Text = db.Urun.Count(x=>x.Kategori==1).ToString();
            lblKucukEvaletSayı.Text = db.Urun.Count(x=>x.Kategori==3).ToString();
            lblToplamMarka.Text = (from x in db.Urun select x.Marka).Distinct().Count().ToString();
        }

        private void pictureEdit18_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
