using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using TeknikServ_Web.Entities;
using System.Web.UI.WebControls;

namespace TeknikServ_Web
{
    public partial class Default : System.Web.UI.Page
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        void UrunListeleme()
        {
            var degerler = (from x in db.Urun
                           select new
                           {
                               x.Ad,
                               x.Marka,
                               x.SatisFiyat,
                               Kategori = x.Kategori1.Ad
                           });
            UrunTekrarlayici.DataSource = degerler.ToList();
            UrunTekrarlayici.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.Hakkimizda.ToList();
            Repeater1.DataBind();
            UrunListeleme();
        }

        protected void btnIletisim_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.Ad = txtName.Text;
            iletisim.Mail = txtEmail.Text;
            iletisim.Mesaj = txtMesaj.Text;
            db.Iletisim.Add(iletisim);
            db.SaveChanges();
            txtName.Text = " ";
            txtEmail.Text = " ";
            txtMesaj.Text = " ";
        }
    }
}