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

            if (result)
            {
                Label10.Visible = true;
                Label10.Text = "KAYIT BAŞARILI";
            }
            else
            {
                Label10.Visible = true;
                Label10.Text = "KAYIT BAŞARISIZ";
            }
        }
    }
}