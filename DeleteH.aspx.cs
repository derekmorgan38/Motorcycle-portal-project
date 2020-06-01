using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class DeleteH : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Bike;Integrated Security=True");
    
   protected void Page_Load(object sender, EventArgs e)
    {
       
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.Text == "--Select--")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Select Type');", true);
        }
        if (TextBox1.Text == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Enter Product ID !!!');", true);
        }
        else
        {
            if (DropDownList1.Text == "Bike")
            {
                SqlCommand cmd = new SqlCommand("Select Pimg,PName from Products where Pid='" + TextBox1.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Image1.ImageUrl = dr[0].ToString();
                    Session["name"] = dr[1].ToString();
                    Panel3.Visible = true;
                    Button1.Visible = false;
                    DropDownList1.Enabled = false;


                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Invalid Type');", true);
                }
                con.Close();
            }
            if (DropDownList1.Text == "Parts")
            {
                SqlCommand cmd = new SqlCommand("Select img,name from Parts where id='" + TextBox1.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Image1.ImageUrl = dr[0].ToString();
                    Session["name"] = dr[1].ToString();
                    Panel3.Visible = true;
                    Button1.Visible = false;
                    DropDownList1.Enabled = false;

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Invalid Type');", true);
                }
                con.Close();
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (DropDownList1.Text == "Bike")
        {
            SqlCommand cmd = new SqlCommand("Delete From Products where PName like '%" + Session["name"].ToString() + "%'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("DeleteH.aspx");
        }
        else if(DropDownList1.Text == "Parts")
        {
            SqlCommand cmd = new SqlCommand("Delete From Parts where name like '%" + Session["name"].ToString() + "%'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("DeleteH.aspx");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteH.aspx");
    }
   
    
    }
