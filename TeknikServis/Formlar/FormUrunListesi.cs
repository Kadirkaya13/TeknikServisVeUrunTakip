using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TeknikServis.formlar
{
    public partial class FormUrunListesi : Form
    {
        public FormUrunListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void UrunListesi()
        {
            var degerler = from u in db.Urun
                           select new
                           {
                               u.Id,
                               u.Ad,
                               u.Marka,
                               u.AlisFiyat,
                               u.SatisFiyat,
                               u.Stok,
                               Kategori = u.Kategori1.Ad

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        void lookUpEditKategoriler()
        {
            lookUpEdit1.Properties.DataSource = (from x in db.Kategori
                                                 select new
                                                 {
                                                     x.Id,
                                                     x.Ad
                                                 }).ToList();
        }
        private void FormUrunListesi_Load(object sender, EventArgs e)
        {
            //var degerler = db.Urun.ToList();
            txtUrunId.Enabled = false;
            UrunListesi();
            lookUpEditKategoriler();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text != "" && txtUrunMarka.Text != "" && txtUrunAlısFiyat.Text != "" && txtUrunSatisFiyat.Text != "" && txtUrunStok.Text != "")
            {
                Urun urun = new Urun();
                urun.Ad = txtUrunAd.Text;
                urun.Marka = txtUrunMarka.Text;
                urun.AlisFiyat = Convert.ToDecimal(txtUrunAlısFiyat.Text);
                urun.SatisFiyat = Convert.ToDecimal(txtUrunSatisFiyat.Text);
                urun.Stok = Convert.ToInt16(txtUrunStok.Text);
                urun.Durum = false;
                urun.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.Urun.Add(urun);
                db.SaveChanges();
                MessageBox.Show("Ürün Başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doldurulmayan Alanları Doldurunuz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

                txtUrunId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
                txtUrunAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
                txtUrunMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
                txtUrunAlısFiyat.Text = gridView1.GetFocusedRowCellValue("AlisFiyat").ToString();
                txtUrunSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SatisFiyat").ToString();
                txtUrunStok.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
                lookUpEdit1.EditValue = gridView1.GetFocusedRowCellValue("Kategori").ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu \n Hata : "+ ex ,"Hata !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Ürünü Silmek istediğinize emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtUrunId.Text);
                var deger = db.Urun.Find(id);
                db.Urun.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Ürün başarı ile silindi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Güncellemeyi onaylıyor musunuz ?", "UYARI !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtUrunId.Text);
                var deger = db.Urun.Find(id);
                deger.Ad = txtUrunAd.Text;
                deger.Stok = short.Parse(txtUrunStok.Text);
                deger.Marka = txtUrunMarka.Text;
                deger.SatisFiyat = decimal.Parse(txtUrunSatisFiyat.Text);
                deger.AlisFiyat = decimal.Parse(txtUrunAlısFiyat.Text);
                deger.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Ürün başarı ile Güncellendi !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtUrunId.Text = "";
            txtUrunAd.Text = "";
            txtUrunMarka.Text = "";
            txtUrunAlısFiyat.Text = "";
            txtUrunSatisFiyat.Text = "";
            txtUrunStok.Text = "";
            lookUpEdit1.EditValue = "";
        }
    }
}
