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
    public partial class FormNotlar : Form
    {
        public FormNotlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void OkunmayanNotlar()
        {
            var degerler = from u in db.Notlar
                           where u.Durum == false
                           select new
                           {
                               u.Id,
                               u.Icerik,
                               u.Baslik,
                           };
            gridControl1.DataSource = degerler.ToList();

        }
        void OkunanNotlar()
        {

            var degerler = from u in db.Notlar
                           where u.Durum == true
                           select new
                           {
                               u.Id,
                               u.Icerik,
                               u.Baslik,
                           };
            gridControl2.DataSource = degerler.ToList();


        }
        private void FormNotlar_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            OkunanNotlar();
            OkunmayanNotlar();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Notlar notlar = new Notlar();
            notlar.Baslik = txtBaslik.Text;
            notlar.Icerik = txtIcerik.Text;
            notlar.Durum = false;
            db.Notlar.Add(notlar);
            db.SaveChanges();
            MessageBox.Show("Not Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            OkunanNotlar();
            OkunmayanNotlar();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Güncellemeyi onaylıyor musunuz ?", "UYARI !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                var notlar = db.Notlar.Find(id);
                notlar.Baslik = txtBaslik.Text;
                notlar.Icerik = txtIcerik.Text;
                notlar.Durum = checkEdit1.Checked ? true : false;
                db.SaveChanges();
                MessageBox.Show("Not Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Ürün başarı ile Güncellendi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtBaslik.Text = gridView1.GetFocusedRowCellValue("Baslik").ToString();
            txtIcerik.Text = gridView1.GetFocusedRowCellValue("Icerik").ToString();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView2.GetFocusedRowCellValue("Id").ToString();
            txtBaslik.Text = gridView2.GetFocusedRowCellValue("Baslik").ToString();
            txtIcerik.Text = gridView2.GetFocusedRowCellValue("Icerik").ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtBaslik.Text = "";
            txtIcerik.Text = "";
        }
    }
}
