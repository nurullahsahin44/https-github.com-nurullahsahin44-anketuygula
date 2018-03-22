using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace anketUygula
{
    public partial class yöneticiler : System.Web.UI.Page
    {
        string[] dizi = null;
        ArrayList arraylist = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {

            WebService.WebService1SoapClient webservis1 = new WebService.WebService1SoapClient();
            Label2.Text = "";
            string result = webservis1.anketYoneticiTumListe();
            int x = 0;
            int y = 0;
            int z = 0;
            //Label2.Text = result;
            dizi = result.Split(',');
            foreach (string a in dizi)
            {



                x = a.IndexOf(':')+2;
                z = a.Length-1;
                y = z - x;

                arraylist.Add(a.Substring(x, y));

               

            }

            for (int i = 0; i < arraylist.Count; i++)
            {
                Label2.Text = Label2.Text + "\n" + arraylist[i];    
            }

        }

    }
}