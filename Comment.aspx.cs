using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

public partial class Comment : System.Web.UI.Page
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



    protected void Button1_Click(object sender, EventArgs e)
    {
        Popup(true);
    }


    void Popup(bool isDisplay)
    {
        StringBuilder builder = new StringBuilder();
        if (isDisplay)
        {
            builder.Append("<script language=JavaScript> ShowPopup(); </script>\n");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "ShowPopup", builder.ToString());
        }
        else
        {
            builder.Append("<script language=JavaScript> HidePopup(); </script>\n");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "HidePopup", builder.ToString());
        }
    }
   

    protected void add_Click(object sender, EventArgs e)
    {
        if (TextBox4.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Enter Comment !!!')", true);
        }
        else
        {
            string aa = ((Button)sender).CommandArgument;
            SqlCommand cmd;
            string s = "insert into comment values('" + Session["uid"].ToString() + "','" + TextBox4.Text + "','" + Label3.Text + "')";
            con.Open();
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            TextBox4.Text = "";
            Response.Redirect("Comment.aspx");
        }    
    }
}
