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
    public partial class FormArizaDetaylar : Form
    {
        public FormArizaDetaylar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UrunTakip urunTakip = new UrunTakip();
            urunTakip.SeriNo = txtSeriNo.Text;
            urunTakip.Tarih = DateTime.Parse( txtTarih.Text);
            urunTakip.Aciklama = txtAciklama.Text;
            db.UrunTakip.Add(urunTakip);
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayı Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
