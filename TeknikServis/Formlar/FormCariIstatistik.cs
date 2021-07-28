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
    public partial class FormCariIstatistik : Form
    {
        public FormCariIstatistik()
        {
            InitializeComponent();
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FormCariIstatistik_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint(" ",5);
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul",20);
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara",14);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir",10);

            gridControl1.DataSource = db.Cariler.OrderBy(x => x.Il).GroupBy(y => y.Il).Select(z => new {  Il =z.Key,  Toplam = z.Count() } ).OrderByDescending(z=>z.Toplam).ToList();

            sqlConnection.Open();
            
            SqlCommand command = new SqlCommand("select IL,Count(*) from Cariler group by Il",sqlConnection);
            
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(sqlDataReader[0].ToString(),Convert.ToInt32(sqlDataReader[1]));
            }
            sqlConnection.Close();
            
        }
    }
}
