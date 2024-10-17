using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _25112023_WebformsVeritabani
{
    public partial class KisiDuzenle : System.Web.UI.Page
    {
        int _id = 0;
        Entities db=new Entities();
        string kullanicim=string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] !=null)
            {
                _id = int.Parse(Request.QueryString["id"]);
            }
            if (!IsPostBack)
            {
                var k = db.Kullanicilar.Find(_id);
                if (k != null) 
                {
                    Response.Redirect("KullaniciListe.aspx");
                }
                else
                {
                    //txtAd.Text = k.Ad;
                    //kullanicim= k.Ad;
                    //txtSoyad.Text = k.Soyad;
                    //txtKullAdi.Text = k.KullaniciAdi;
                    //chkDurum.Checked= k.Durum;
                }
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            var edit = db.Kullanicilar.Find(_id);
            edit.Ad= txtAd.Text;
            edit.Soyad= txtSoyad.Text;
            edit.Parola=txtParola.Text;
            edit.KullaniciAdi = txtKullAdi.Text;
            edit.Durum=chkDurum.Checked;

            var kullaniciAdiKontrol = db.Kullanicilar.FirstOrDefault(x=> x.KullaniciAdi ==edit.KullaniciAdi);
            if (kullaniciAdiKontrol != null)
            {
                lblBilgi.Text = "Bu kullanıcı adı daha önce alınış";
                txtKullAdi.Text = string.Empty;
                txtKullAdi.Focus();
            }
            else
            {
                try
                {
                    db.SaveChanges();
                    Response.Redirect("KullaniciListe.aspx");
                }
                catch (Exception ex)
                {

                    lblBilgi.Text = ex.Message;
                }

            }
        }
    }
}