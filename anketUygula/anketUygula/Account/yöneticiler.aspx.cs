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
        int sayac = 0;
        ArrayList arraylist = new ArrayList();
        string birles="";
        string[] yoneti = new string[500];
        int a1, b, c, d, e1, f, g,t,deger;

         
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

       

           
            t = arraylist.Count;
            int deger = t / 7;

            a1 = t - 7;
            b = t - 6;
            c = t - 5;
            d = t - 4;
            e1 = t - 3;
            f = t - 2;
            g = t - 1;

            for (int i = 1; i < deger; i++)
            {
                TableRow yenisatir = new TableRow();

                TableCell adin = new TableCell();
                adin.Text = arraylist[a1].ToString();
                yenisatir.Cells.Add(adin);

                TableCell adin1 = new TableCell();
                adin1.Text = arraylist[b].ToString();
                yenisatir.Cells.Add(adin1);

                TableCell adin2 = new TableCell();
                adin2.Text = arraylist[c].ToString();
                yenisatir.Cells.Add(adin2);

                TableCell adin3 = new TableCell();
                adin3.Text = arraylist[d].ToString();
                yenisatir.Cells.Add(adin3);

                TableCell adin4 = new TableCell();
                adin4.Text = arraylist[e1].ToString();
                yenisatir.Cells.Add(adin4);

                TableCell adin5 = new TableCell();
                adin5.Text = arraylist[f].ToString();
                yenisatir.Cells.Add(adin5);

                TableCell adin6 = new TableCell();
                adin6.Text = arraylist[g].ToString();
                yenisatir.Cells.Add(adin6);

                Table1.Rows.Add(yenisatir);

                a1 = a1 - 7;
                b = b - 7;
                c = c - 7;
                d = d - 7;
                e1 = e1 - 7;
                f = f - 7;
                g = g - 7;
            }
            
           

        }

       

    }
}