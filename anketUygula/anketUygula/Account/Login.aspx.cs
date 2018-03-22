using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using anketUygula.Models;
using anketUygula.WebService;

namespace anketUygula.Account
{
    public partial class Login : Page

    {
        private Boolean result = true;
        private Boolean result2 = true;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void LogIn(object sender, EventArgs e)
        {

            if (giris(UserName.Text, Password.Text))
            {
                Response.Redirect("admin.aspx");
            }
            else
            {
                Label1.Visible = true;
            }



            if (giris2(UserName.Text, Password.Text))
            {
                Response.Redirect("yönetici.aspx");
            }
            else
            {
                Label1.Visible = true;
            }
        }



        public Boolean giris(string ad, string parola)
        {
            WebService.WebService1SoapClient webservis = new WebService.WebService1SoapClient();

            result = webservis.anketAdminLogin(ad, parola);
            return result;
            


        }
        public Boolean giris2(string ad, string parola)
        {

            WebService.WebService1SoapClient webservis2 = new WebService.WebService1SoapClient();

            result2 = webservis2.anketLogin(ad, parola);
            return result2;



        }

            }
        }
    
