using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FormMarkalar : Form
    {
        public FormMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbTeknikServis;Integrated Security=True");

        private void labelControl17_Click(object sender, EventArgs e)
        {

        }

        private void FormMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.Urun.OrderBy(x => x.Marka).GroupBy(y => y.Marka).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count() 
            }).OrderByDescending(c=>c.Toplam);
            //var makr=db.Urun.Sum(x => x.)
            var enCokUrunuOlanMarka = db.Urun.OrderBy(x => x.Marka).GroupBy(y => y.Marka).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            }).Select(c => c.Marka).OrderBy(x=> x).FirstOrDefault();

            var MarkayaGoreUrunSayisi = db.Urun.OrderBy(x => x.Marka).GroupBy(y => y.Marka).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            }).Select(c => c.Marka).OrderByDescending(x => x).FirstOrDefault();

            gridControl1.DataSource = degerler.ToList();

            lblToplamMarka.Text = (from x in db.Urun select x.Marka).Distinct().Count().ToString();
            lblEnYuksekFiyatliMarka.Text = (from x in db.Urun orderby x.SatisFiyat descending select x.Marka).FirstOrDefault();
            lblEnÇokUrunOlanMarka.Text = enCokUrunuOlanMarka.ToString();

            //chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 3);
            //chartControl1.Series["Series 1"].Points.AddPoint("Lenova", 2);
            //chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 1);
            //chartControl1.Series["Series 1"].Points.AddPoint("Bosch", 1);
            //chartControl1.Series["Series 1"].Points.AddPoint("Lg", 1);

            sqlConnection.Open();

            SqlCommand markaCommand = new SqlCommand("select Marka,Count(*) from Urun group by Marka", sqlConnection);

            SqlDataReader sqlDataReader = markaCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(sqlDataReader[0].ToString(), Convert.ToInt32(sqlDataReader[1]));

            }
            sqlDataReader.Close();
            
            //chartControl2.Series["Series 1"].Points.AddPoint("Beyaz Eşya", 4);
            //chartControl2.Series["Series 1"].Points.AddPoint("Bilgisayar", 2);
            //chartControl2.Series["Series 1"].Points.AddPoint("Tv", 1);
            //chartControl2.Series["Series 1"].Points.AddPoint("Küçük Ev Aletleri", 1);

            
            SqlCommand kategoriCommand = new SqlCommand("select Kategori,Count(*) from Urun group by Kategori", sqlConnection);

            SqlDataReader kategoriSqlDataReader = kategoriCommand.ExecuteReader();

            while (kategoriSqlDataReader.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(kategoriSqlDataReader[0].ToString(), Convert.ToInt32(kategoriSqlDataReader[1]));
            }
            kategoriSqlDataReader.Close();
            sqlConnection.Close();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
