using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Check;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Bike;Integrated Security=True");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        #region System Generated . . .
        Class1 c = new Class1();
        bool c1 = c.checkLoad("S233", con);
        if (!c1)
        {
            Response.Redirect("Login.aspx");
        }
        #endregion
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["id"] = txtusername.Text;
        if (txtusername.Text == "admin" && txtpassword.Text == "admin")
        {
            Session["fname"] = "admin";
           
            Response.Redirect("AddBike.aspx");
            
        }
        try
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select fname,mname,lname,contact,uid,email from Login where Uid='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", con);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            
            Session["fname"] = Convert.ToString(ds3.Tables[0].Rows[0][0]);
            Session["mname"] = Convert.ToString(ds3.Tables[0].Rows[0][1]);
            Session["lname"] = Convert.ToString(ds3.Tables[0].Rows[0][2]);
            Session["contact"] = Convert.ToString(ds3.Tables[0].Rows[0][3]);
            Session["uid"] = Convert.ToString(ds3.Tables[0].Rows[0][4]);
            Session["email"] = Convert.ToString(ds3.Tables[0].Rows[0][5]);


            SqlDataAdapter da2 = new SqlDataAdapter("Select uid,password from Login where Uid='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            if (ds2.Tables[0].Rows.Count != 0)
            {
                Session["type"] = "user";
                //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
               Response.Redirect("PostBlog.aspx");
            }
            else
            {
                String alertmsg = "Enter valid username / Password";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);

            }
        }
        catch (Exception exx)
        {
            String alertmsg = "Enter valid username / Password";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);

        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
