using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Home : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Bike;Integrated Security=True");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        string a = "select id,topic,image,decription from topic";
        da = new SqlDataAdapter(a, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "yes")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string s = "Select topic,image,decription from topic where id='" + i + "'";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["tid"] = i;
                Session["topic"] = ds.Tables[0].Rows[0][0].ToString();
                Session["image"] = ds.Tables[0].Rows[0][1].ToString();
                Session["decription"] = ds.Tables[0].Rows[0][2].ToString();
                Response.Redirect("HCom.aspx");
            }
        }
    }
}