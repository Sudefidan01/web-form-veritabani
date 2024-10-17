using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _25112023_WebformsVeritabani
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"]!=null)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            Entities db=new Entities();
            var k = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == txtKullanici.Text && x.Parola ==txtParola.Text);
            if (k == null) 
            {
                lblBilgi.Text = "Kullanıcı adı veya Parola Hatalı";
            }
            else
            {
                if (k.Durum)
                {
                    Session.Add("Kullanici",k);
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    lblBilgi.Text = "Üyeliğiniz devre dışı bırakılmıştır.Lütfen sistem yöneticisi ile iletişime geçiniz. a@a.com";
                }
            }
        }
    }
}