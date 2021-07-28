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
    public partial class FormArizaliUrunDetayListesi : Form
    {
        public FormArizaliUrunDetayListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Listele()
        {
            var degerler = from x in db.UrunTakip
                           select new
                           {
                               x.SeriNo,
                               x.Aciklama,
                               x.Tarih,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FormArizaliUrunDetayListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
