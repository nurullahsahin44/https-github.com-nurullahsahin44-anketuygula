using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace anketUygula
{
    public partial class anket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService.WebService1SoapClient webservis = new WebService.WebService1SoapClient();

            bool result = webservis.anketWebYoneticiAdd(yöneticiTC.Text,yöneticiSifre.Text,yöneticiisim.Text,yöneticiSoyisim.Text,yöneticiTelefon.Text,yöneticimail.Text,yöneticikonum.SelectedItem.Text);

          /*  if (result)
            {
                Label10.Visible = true;
                Label10.Text = "KAYIT BAŞARILI";
            }
            else
            {
                Label10.Visible = true;
                Label10.Text = "KAYIT BAŞARISIZ";
            }
           * */
            
            //TC kimlik no KONTROL*********************************************************************************
            string tckimlik;

            try
            {

                tckimlik = yöneticiTC.Text;

                int index = 0;

                int toplam = 0;

                foreach (char n in tckimlik)
                {
                    if (index < 10)
                    {
                        toplam += Convert.ToInt32(char.ToString(n));
                    }
                    index++;
                }
                if (toplam % 10 == Convert.ToInt32(tckimlik[10].ToString()))
                {

                    Label11.Text = "Tc geçerli";
                    
                    if (yöneticiSifre.Text == yoneticisifre2.Text)
                    {
                        result = true;
                        Label10.Text = "Kayıt Başarılı";
                        Label10.Visible = true;
                        
                    }
                    else
                    {
                        result = false;
                        Label10.Text = "Kayıt Başarısız";
                        Label10.Visible = true;
                    }
                }
                else
                {
                    Label11.Visible = true;
                    Label11.Text="Geçersiz Tc Kimlik Numarası";
                    result = false;
                    Label10.Text = "Kayıt Başarısız";  
                }
            }
 catch
            {
                Label11.Visible = true;
               Label11.Text="Girdiğiniz Tc kimlik numarası 11 haneli değil";
            }

            //KONTROL BİTİYO***************************************************************************
        }
    }
}