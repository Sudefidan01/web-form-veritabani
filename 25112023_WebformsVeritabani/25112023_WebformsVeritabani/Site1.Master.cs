using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _25112023_WebformsVeritabani
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                var k =(Kullanicilar) Session["Kullanici"];
                lblKullanici.Text = k.Ad + " " + k.Soyad;

            }
        }

        protected void btnCikis_Click(object sender, EventArgs e)
        {
            Session.Remove("Kullanici");
            Response.Redirect("Login.aspx");
        }
    }
}