using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class ProductEntry : System.Web.UI.Page
{
    String image, path;
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\as403\OneDrive\Desktop\Bikers Portal System\Project\Bike Portal\App_Data\Database.mdf;Integrated Security=True");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd;
        string a = "select top 1 Pid from Products order by Pid desc";
        con.Open();
        cmd = new SqlCommand(a, con);
        object count = cmd.ExecuteScalar();
        int c = Convert.ToInt32(count);
        if (c != 0)
        {
            c = c + 1;
            Txtprodid.Text = Convert.ToString(c);
            Txtprodid.ReadOnly = true;

        }
        else
        {
            Txtprodid.Text = "101";
            Txtprodid.ReadOnly = true;
        }
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        image = FileUpload1.FileName;
        path = Server.MapPath("~\\images\\");
        FileUpload1.SaveAs(path + image);
        Image1.ImageUrl="images\\" + image;
    }
    public static string RemoveSpecialCharacters(string str)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in str)
        {
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_'|| c==' ')
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into Products values('" + Txtprodid.Text + "','" + txtprodname.Text + "','" + Image1.ImageUrl + "','" + RemoveSpecialCharacters(txtsdesc.Text) + "'," + txtprice.Text + ")", con);
        cmd.ExecuteNonQuery();
        con.Close();
        String alertmsg = "Entry Made";
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        Response.Redirect("AddBike.aspx");
        txtprodname.Text = "";
        Image1.ImageUrl = "";
        txtsdesc.Text = "";
        txtprice.Text = "";



    }
}