using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class BikeDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Bike;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string d = "select Pimg,PName,Psdesc,Pprice from Products where Pid='" + Session["id"].ToString() + "'";
        da = new SqlDataAdapter(d, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Image1.ImageUrl = ds.Tables[0].Rows[0][0].ToString();
            Label2.Text = ds.Tables[0].Rows[0][1].ToString();
            Label3.Text = ds.Tables[0].Rows[0][2].ToString();
            Label4.Text = ds.Tables[0].Rows[0][3].ToString();



        }
    }
    
}