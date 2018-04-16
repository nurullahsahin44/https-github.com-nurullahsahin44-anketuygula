using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace anketUygula
{
    public partial class anket1 : System.Web.UI.Page
    {
        string tarih;
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            tarih=Convert.ToString(Calendar2.SelectedDate);
            labeltarih.Text=tarih;
            labeltarih.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          // string message = DropDownList1.SelectedItem.Text + " - " + DropDownList1.SelectedItem.Value;
    //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + message + "');", true);
            
            }

       
            }

       
        }

       
    
