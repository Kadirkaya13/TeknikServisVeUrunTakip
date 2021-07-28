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
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FormUrunListesi fr = new formlar.FormUrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniUrun fr = new Formlar.FormYeniUrun();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.KategoriFormu fr = new Formlar.KategoriFormu();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniKategori fr= new Formlar.FormYeniKategori();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormIstatistik fr = new Formlar.FormIstatistik();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormMarkalar fr = new Formlar.FormMarkalar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCariListesi fr = new Formlar.FormCariListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCariIstatistik fr = new Formlar.FormCariIstatistik();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCariEkleme fr = new Formlar.FormCariEkleme();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormDepartman fr = new Formlar.FormDepartman();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniDepartman fr = new Formlar.FormYeniDepartman();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormPersonelListesi fr = new Formlar.FormPersonelListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnHesapMakine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormNotlar fr = new Formlar.FormNotlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormKurlar fr = new Formlar.FormKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad.exe");
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYouTube fr = new Formlar.FormYouTube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormArizaliUrunListesi fr = new Formlar.FormArizaliUrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnYeniUrunSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormUrunSatis fr = new Formlar.FormUrunSatis();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormSatislar fr = new Formlar.FormSatislar();
            fr.MdiParent = this;
            fr.Show();
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
            Formlar.FormArizaliUrunDetayListesi fr = new Formlar.FormArizaliUrunDetayListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormQrCode fr = new Formlar.FormQrCode();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormFaturaListesi fr = new Formlar.FormFaturaListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnFaturaKalemGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormFaturaKalem fr = new Formlar.FormFaturaKalem();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnFaturaSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormFaturaKalemleriListesi fr = new Formlar.FormFaturaKalemleriListesi();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
