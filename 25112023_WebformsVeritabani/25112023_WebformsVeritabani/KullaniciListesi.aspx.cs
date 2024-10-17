using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _25112023_WebformsVeritabani
{
    public partial class KullaniciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Entities db= new Entities();

            rptListe.DataSource = db.Kullanicilar.Where(x => !x.Silindi).ToList();
            rptListe.DataBind();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            Response.Redirect("YeniKullanici.aspx");
        }
    }
}