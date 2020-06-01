using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
        if (Session["fname"] == "admin")
        {
            Panel2.Visible = true;
            Panel1.Visible = false;


        }
            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
        }
        catch(Exception ex)
        {
        
        
            Panel1.Visible = true;
            Panel2.Visible = false;
        }

    }
   
}
