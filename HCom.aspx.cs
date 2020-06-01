using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class HCom : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Bike;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd;
        Label3.Text = Session["tid"].ToString();
        Label2.Text = Session["topic"].ToString();
        Image1.ImageUrl = Session["image"].ToString();
        Label4.Text = Session["decription"].ToString();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string a = "select comment from comment where id = '" + Session["tid"].ToString() + "'";
        da = new SqlDataAdapter(a, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}