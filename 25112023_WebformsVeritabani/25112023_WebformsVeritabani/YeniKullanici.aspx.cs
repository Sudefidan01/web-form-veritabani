using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _25112023_WebformsVeritabani
{
    public partial class YeniKullanici : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            Entities db= new Entities();

            Kullanicilar k=new Kullanicilar();
            k.Ad = txtAd.Text;
            k.Soyad= txtSoyad.Text;
            k.KullaniciAdi=txtKullAdi.Text;
            k.Parola = txtParola.Text;
            k.Durum=chkDurum.Checked;
            k.Silindi = false;
            k.Tarih=DateTime.Now;

            var kullanici = db.Kullanicilar.FirstOrDefault(x=> x.KullaniciAdi ==k.KullaniciAdi);
            if (kullanici != null)
            {
                lblBilgi.Text = "Bu kullanıcı adı daha önce alınmış";
                txtKullAdi.Text = string.Empty;
                txtKullAdi.Focus();
            }
            else
            {
                try
                {
                    db.Kullanicilar.Add(k);
                    db.SaveChanges();
                    Response.Redirect("KullaniciListesi.aspx");
                }
                catch (Exception ex)
                {
                    lblBilgi.Text = ex.Message;
                    
                }

            }

        }
    }
}