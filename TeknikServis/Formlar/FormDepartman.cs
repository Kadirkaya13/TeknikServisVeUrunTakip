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
    public partial class FormDepartman : Form
    {
        public FormDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void DepartmanListesi()
        {
            var degerler = from u in db.Departman
                           select new
                           {
                               u.Id,
                               u.Ad,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDepartmanAd.Text != "")
            {
                Departman departman = new Departman();
                departman.Ad = txtDepartmanAd.Text;
                db.Departman.Add(departman);
                db.SaveChanges();
                MessageBox.Show("Departman Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doldurulmayan Alanları Doldurunuz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void FormDepartman_Load(object sender, EventArgs e)
        {
            lblToplamDep.Text = db.Departman.Count().ToString();
            lblTopamPer.Text = db.Personel.Count().ToString();
            txtDepartmanId.Enabled = false;
            DepartmanListesi();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DepartmanListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Ürünü Silmek istediğinize emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtDepartmanId.Text);
                var deger = db.Departman.Find(id);
                db.Departman.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Ürün başarı ile silindi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Güncellemeyi onaylıyor musunuz ?", "UYARI !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtDepartmanId.Text);
                var deger = db.Departman.Find(id);
                deger.Ad = txtDepartmanAd.Text;
                db.SaveChanges();
                MessageBox.Show("Ürün başarı ile Güncellendi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtDepartmanId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
                txtDepartmanAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu \n Hata : " + ex, "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtDepartmanId.Text = "";
            txtDepartmanAd.Text = "";
        }
    }
}
