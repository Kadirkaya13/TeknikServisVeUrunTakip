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
    public partial class FormYeniKategori : Form
    {
        public FormYeniKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kategori urun = new Kategori();
            urun.Ad = txtAd.Text;
            
            db.Kategori.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
