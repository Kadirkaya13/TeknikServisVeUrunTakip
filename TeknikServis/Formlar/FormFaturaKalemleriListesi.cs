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
    public partial class FormFaturaKalemleriListesi : Form
    {
        public FormFaturaKalemleriListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public int id;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtFaturaId.Text!="")
            {
                id = int.Parse(txtFaturaId.Text);
            }
            string seri = txtSeri.Text;
            string siraNo = txtSiraNo.Text;
            if (id>0)
            {
                idGoreListeleme(id);
            }
            else if (seri!=null)
            {
                SeriGoreListeleme(seri);
            }
            else if(siraNo!=null)
            {
                siraNoGoreSirala(siraNo);
            }

        }
        void siraNoGoreSirala(string siraNo)
        {
            var degerler = (from x in db.FaturaDetay
                            select new
                            {
                                x.FaturaDetayId,
                                x.FaturaId,
                                x.Urun,
                                x.FaturaBilgi,
                                x.FaturaBilgi.Seri,
                                x.Adet,
                                x.Fiyat,
                                x.Tutar,

                            }).Where(x => x.FaturaBilgi.SıraNo == siraNo);
            gridControl1.DataSource = degerler.ToList();
        }
        void kalemListeleme()
        {
            var degerler = from x in db.FaturaDetay
                           select new
                           {
                               x.FaturaDetayId,
                               x.FaturaId,
                               x.Urun,
                               x.FaturaBilgi.Seri,
                               x.Adet,
                               x.Fiyat,
                               x.Tutar,

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        void idGoreListeleme(int faturaId)
        {
            var degerler = (from x in db.FaturaDetay
                           select new
                           {
                               x.FaturaDetayId,
                               x.FaturaId,
                               x.Urun,
                               x.FaturaBilgi.Seri,
                               x.Adet,
                               x.Fiyat,
                               x.Tutar,

                           }).Where(x=>x.FaturaId==faturaId);
            gridControl1.DataSource = degerler.ToList();
        }
        void SeriGoreListeleme(string seri)
        {
            var degerler = (from x in db.FaturaDetay
                            select new
                            {
                                x.FaturaDetayId,
                                x.FaturaId,
                                x.Urun,
                                x.FaturaBilgi,
                                x.FaturaBilgi.Seri,
                                x.Adet,
                                x.Fiyat,
                                x.Tutar,

                            }).Where(x=>x.FaturaBilgi.Seri==seri);
            gridControl1.DataSource = degerler.ToList();
        }

        private void FormFaturaKalemleriListesi_Load(object sender, EventArgs e)
        {
            kalemListeleme();
        }
    }
}
