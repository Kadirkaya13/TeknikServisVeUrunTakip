using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using TeknikServ_Web.Entities;
using System.Web.UI.WebControls;

namespace TeknikServ_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        void Listele()
        {
            var degerler = db.UrunTakip.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Listele();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var degerler = db.UrunTakip.Where(x=>x.SeriNo == txtUrunSeriNo.Text).ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }
    }
}