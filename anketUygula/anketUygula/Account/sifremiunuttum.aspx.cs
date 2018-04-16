using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace anketUygula
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService.WebService1SoapClient webservis = new WebService.WebService1SoapClient();

            bool result = webservis.SifremiUnuttum(sifremiunutttummail.Text);
            if (result == true)
            {
                Label1.Text = "Mail Gönderildi";
                Label1.Visible=true;
            }
            else{
                Label1.Text = "Geçersiz Mail";
                    Label1.Visible=true;
               
            }

        }
    }
}