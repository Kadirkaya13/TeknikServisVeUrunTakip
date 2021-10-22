 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        Formlar.FormAnaSayfa anaSayfa;
        formlar.FormUrunListesi urunListesi;
        Formlar.KategoriFormu kategori;
        Formlar.FormIstatistik formIstatistik;
        Formlar.FormMarkalar markalar;
        Formlar.FormCariListesi cariListesi;
        Formlar.FormCariIstatistik formCariIstatistik;
        Formlar.FormDepartman departman;
        Formlar.FormPersonelListesi personelListesi;
        Formlar.FormNotlar notlar;
        Formlar.FormKurlar kurlar;
        Formlar.FormYouTube youTube;
        Formlar.FormArizaliUrunListesi arizaliUrunListesi;
        Formlar.FormSatislar satislar;
        Formlar.FormArizaliUrunDetayListesi arizaliUrunDetayListesi;
        Formlar.FormFaturaListesi faturaListesi;
        Formlar.FormFaturaKalem faturaKalem;
        Formlar.FormFaturaKalemleriListesi faturaKalemleriListesi;
        Formlar.FormGauge gauge;
        Formlar.FormHaritalar haritalar;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (anaSayfa == null || anaSayfa.IsDisposed )
            {
                anaSayfa = new Formlar.FormAnaSayfa();
                anaSayfa.MdiParent = this;
                anaSayfa.Show();
            }
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunListesi == null || urunListesi.IsDisposed)
            {
                urunListesi = new formlar.FormUrunListesi();
                urunListesi.MdiParent = this;
                urunListesi.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniUrun fr = new Formlar.FormYeniUrun();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kategori == null || kategori.IsDisposed)
            {
                kategori = new Formlar.KategoriFormu();
                kategori.MdiParent = this;
                kategori.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniKategori fr= new Formlar.FormYeniKategori();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formIstatistik == null || formIstatistik.IsDisposed)
            {
                formIstatistik = new Formlar.FormIstatistik();
                formIstatistik.MdiParent = this;
                formIstatistik.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (markalar == null || markalar.IsDisposed)
            {
                markalar = new Formlar.FormMarkalar();
                markalar.MdiParent = this;
                markalar.Show();
            }
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cariListesi == null || cariListesi.IsDisposed)
            {
                cariListesi = new Formlar.FormCariListesi();
                cariListesi.MdiParent = this;
                cariListesi.Show();
            }
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formCariIstatistik == null || formCariIstatistik.IsDisposed)
            {
                formCariIstatistik = new Formlar.FormCariIstatistik();
                formCariIstatistik.MdiParent = this;
                formCariIstatistik.Show();
            }
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCariEkleme fr = new Formlar.FormCariEkleme();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (departman == null || departman.IsDisposed)
            {
                departman = new Formlar.FormDepartman();
                departman.MdiParent = this;
                departman.Show();
            }
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniDepartman fr = new Formlar.FormYeniDepartman();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personelListesi == null || personelListesi.IsDisposed)
            {
                personelListesi = new Formlar.FormPersonelListesi();
                personelListesi.MdiParent = this;
                personelListesi.Show();
            }
        }

        private void btnHesapMakine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (notlar == null || notlar.IsDisposed)
            {
                notlar = new Formlar.FormNotlar();
                notlar.MdiParent = this;
                notlar.Show();
            }
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kurlar == null || kurlar.IsDisposed)
            {
                kurlar = new Formlar.FormKurlar();
                kurlar.MdiParent = this;
                kurlar.Show();
            }
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad.exe");
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (youTube == null || youTube.IsDisposed)
            {
                youTube = new Formlar.FormYouTube();
                youTube.MdiParent = this;
                youTube.Show();
            }
        }

        private void btnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (arizaliUrunListesi == null || arizaliUrunListesi.IsDisposed)
            {
                arizaliUrunListesi = new Formlar.FormArizaliUrunListesi();
                arizaliUrunListesi.MdiParent = this;
                arizaliUrunListesi.Show();
            }
        }

        private void btnYeniUrunSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormUrunSatis fr = new Formlar.FormUrunSatis();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (satislar == null || satislar.IsDisposed)
            {
                satislar = new Formlar.FormSatislar();
                satislar.MdiParent = this;
                satislar.Show();
            }
        }

        private void btnYeniArizaliUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormArizaliUrunKaydi fr = new Formlar.FormArizaliUrunKaydi();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnArızalıUrunDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormArizaDetaylar fr = new Formlar.FormArizaDetaylar();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnArizaliUrunDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (arizaliUrunDetayListesi == null || arizaliUrunDetayListesi.IsDisposed)
            {
                arizaliUrunDetayListesi = new Formlar.FormArizaliUrunDetayListesi();
                arizaliUrunDetayListesi.MdiParent = this;
                arizaliUrunDetayListesi.Show();
            }
        }

        private void btnQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormQrCode fr = new Formlar.FormQrCode();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (faturaListesi == null || faturaListesi.IsDisposed)
            {
                faturaListesi = new Formlar.FormFaturaListesi();
                faturaListesi.MdiParent = this;
                faturaListesi.Show();
            }
        }

        private void btnFaturaKalemGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (faturaKalem == null || faturaKalem.IsDisposed)
            {
                faturaKalem = new Formlar.FormFaturaKalem();
                faturaKalem.MdiParent = this;
                faturaKalem.Show();
            }
        }

        private void btnFaturaSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (faturaKalemleriListesi == null || faturaKalemleriListesi.IsDisposed)
            {
                faturaKalemleriListesi = new Formlar.FormFaturaKalemleriListesi();
                faturaKalemleriListesi.MdiParent = this;
                faturaKalemleriListesi.Show();
            }
        }

        private void btnHakkimizda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gauge == null || gauge.IsDisposed)
            {
                gauge = new Formlar.FormGauge();
                gauge.MdiParent = this;
                gauge.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (haritalar == null || haritalar.IsDisposed)
            {
                haritalar = new Formlar.FormHaritalar();
                haritalar.MdiParent = this;
                haritalar.Show();
            }
        }

        private void btnRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormRapor fr = new Formlar.FormRapor();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anaSayfa == null || anaSayfa.IsDisposed)
            {
                anaSayfa = new Formlar.FormAnaSayfa();
                anaSayfa.MdiParent = this;
                anaSayfa.Show();
            }
        }
    }
}
