using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class PostBlog : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\as403\OneDrive\Desktop\Bikers Portal System\Project\Bike Portal\App_Data\Database.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd;
        string a = "select top 1 id from topic order by id desc";
        cmd = new SqlCommand(a, con);
        object count = cmd.ExecuteScalar();
        int c = Convert.ToInt32(count);
        if (c != 0)
        {
            c = c + 1;
            TextBox3.Text = Convert.ToString(c);
            TextBox3.ReadOnly = true;

        }
        else
        {
            TextBox3.Text = "1";
            TextBox3.ReadOnly = true;
        }
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String image, path;
        try
        {
            string fileName = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.PostedFile.SaveAs(Server.MapPath("images/" + fileName));
            Image1.ImageUrl = fileName;
            Button1.Visible = false;
            Session["File"] = fileName;
        }
        catch (Exception ep)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Please Select your photo');", true);
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('fill the details');", true);
        }
        if (Image1.ImageUrl == "")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Select Image !!!');", true);
        }
        else
        {
            con.Open();
            string s = "insert into topic values('" + Session["uid"].ToString() + "','" + TextBox3.Text + "','" + TextBox1.Text + "','images/" + Image1.ImageUrl + "','" + TextBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            Response.Redirect("PostBlog.aspx");
            //Response.Write("<script langauge=\"javascript\">alert(\"Your data was inserted successfully\");</script>");
            Image1.ImageUrl = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}