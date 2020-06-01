using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class BuyParts : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Bike;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["trans"] == "Success")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Order Placed Successfully');", true);
            Session["trans"] = "";
        }
        if (!Page.IsPostBack)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            Button2.Visible = false;
            Button1.Visible = false;


            string s = "select id from Parts";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            Label16.Text = Convert.ToString(ds.Tables[0].Rows.Count);

            if (Convert.ToInt32(Label16.Text) > 12)
            {
                Button2.Visible = true;

            }
            else
            {
                Button2.Visible = false;
            }
            int count = 0;
            string s1 = ImageFiller1(0, count + 0);

            ImageButton1.ImageUrl = s1;
            if (s1 == "")
            {
                ImageButton1.Visible = false;
                LinkButton1.Visible = false;
                lblp1.Visible = false;
                // Label1.Visible = false;

            }

            string s2 = ImageFiller1(1, count + 1);
            ImageButton2.ImageUrl = s2;
            if (s2 == "")
            {
                ImageButton2.Visible = false;
                LinkButton2.Visible = false;
                lblp2.Visible = false;
                //Label2.Visible = false;

            }


            string s3 = ImageFiller1(2, count + 2);
            ImageButton3.ImageUrl = s3;
            if (s3 == "")
            {
                ImageButton3.Visible = false;
                LinkButton3.Visible = false;
                //Label3.Visible = false;
                lblp3.Visible = false;

            }


            string s4 = ImageFiller1(3, count + 3);
            ImageButton4.ImageUrl = s4;
            if (s4 == "")
            {
                ImageButton4.Visible = false;
                LinkButton4.Visible = false;
                lblp4.Visible = false;
                // Label4.Visible = false;

            }


            string s5 = ImageFiller1(4, count + 4);
            ImageButton5.ImageUrl = s5;
            if (s5 == "")
            {
                ImageButton5.Visible = false;
                LinkButton5.Visible = false;
                lblp5.Visible = false;
                //Label5.Visible = false;

            }


            string s6 = ImageFiller1(5, count + 5);
            ImageButton6.ImageUrl = s6;

            if (s6 == "")
            {
                ImageButton6.Visible = false;
                LinkButton6.Visible = false;
                lblp6.Visible = false;
                // Label6.Visible = false;
            }

            string s7 = ImageFiller1(6, count + 6);
            ImageButton7.ImageUrl = s7;
            if (s7 == "")
            {
                ImageButton7.Visible = false;
                LinkButton7.Visible = false;
                lblp7.Visible = false;
                //Label7.Visible = false;

            }
            string s8 = ImageFiller1(7, count + 7);
            ImageButton8.ImageUrl = s8;
            if (s8 == "")
            {
                ImageButton8.Visible = false;
                LinkButton8.Visible = false;
                lblp8.Visible = false;
                // Label8.Visible = false;

            }
            string s9 = ImageFiller1(8, count + 8);
            ImageButton9.ImageUrl = s9;
            if (s9 == "")
            {
                ImageButton9.Visible = false;
                LinkButton9.Visible = false;
                lblp9.Visible = false;
                // Label8.Visible = false;

            }

            string s10 = ImageFiller1(9, count + 9);
            ImageButton10.ImageUrl = s10;
            if (s10 == "")
            {
                ImageButton10.Visible = false;
                LinkButton10.Visible = false;
                lblp10.Visible = false;
                //Label8.Visible = false;

            }

            string s11 = ImageFiller1(10, count + 10);
            ImageButton11.ImageUrl = s11;
            if (s11 == "")
            {
                ImageButton11.Visible = false;
                LinkButton11.Visible = false;
                lblp11.Visible = false;
                // Label8.Visible = false;

            }

            string s12 = ImageFiller1(11, count + 11);
            ImageButton12.ImageUrl = s12;
            if (s12 == "")
            {
                ImageButton12.Visible = false;
                LinkButton12.Visible = false;
                lblp12.Visible = false;
                //Label8.Visible = false;

            }

        }

    }
    
   
  /*  protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }*/
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected String ImageFiller1(int i, int count)
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Bike;Integrated Security=True");
        con.Open();
        string s0 = " ";
        string s = "";
        string s1 = "";

        s1 = "select distinct img,name,price,id from Parts";
        //  s0 = "Rs. ";

        SqlDataAdapter sda = new SqlDataAdapter(s1, con);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        try
        {
            if (ds.Tables[0].Rows[0][0] != null)
            {

                if (count == 0)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton1.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp1.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label3.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton1.Visible = true;
                    LinkButton1.Visible = true;
                    lblp1.Visible = true;

                }
                // Label8.Text = Convert.ToString(ds.Tables[0].Rows[i][4]);
            }

            if (ds.Tables[0].Rows[1][0] != null)
            {
                if (count == 1)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton2.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp2.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label4.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton2.Visible = true;
                    LinkButton2.Visible = true;
                    lblp2.Visible = true;

                }
            }

            if (ds.Tables[0].Rows[2][0] != null)
            {
                if (count == 2)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton3.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp3.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label5.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton3.Visible = true;
                    LinkButton3.Visible = true;
                    lblp3.Visible = true;

                }
            }
            if (ds.Tables[0].Rows[3][0] != null)
            {
                if (count == 3)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton4.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp4.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label6.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton4.Visible = true;
                    LinkButton4.Visible = true;
                    lblp4.Visible = true;
                }
            }
            if (ds.Tables[0].Rows[4][0] != null)
            {
                if (count == 4)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton5.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp5.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label7.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton5.Visible = true;
                    LinkButton5.Visible = true;
                    lblp5.Visible = true;
                }
            }

            if (ds.Tables[0].Rows[5][0] != null)
            {
                if (count == 5)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton6.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp6.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label8.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton6.Visible = true;
                    LinkButton6.Visible = true;
                    lblp6.Visible = true;
                }
            }

            if (ds.Tables[0].Rows[6][0] != null)
            {
                if (count == 6)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton7.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp7.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label9.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton7.Visible = true;
                    LinkButton7.Visible = true;
                    lblp7.Visible = true;
                }
            }

            if (ds.Tables[0].Rows[7][0] != null)
            {
                if (count == 7)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton8.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp8.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label10.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton8.Visible = true;
                    LinkButton8.Visible = true;
                    lblp8.Visible = true;
                }
            }

            if (ds.Tables[0].Rows[8][0] != null)
            {
                if (count == 8)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton9.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp9.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label11.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton9.Visible = true;
                    LinkButton9.Visible = true;
                    lblp9.Visible = true;
                }
            }

            if (ds.Tables[0].Rows[9][0] != null)
            {
                if (count == 9)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton10.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp10.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label12.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton10.Visible = true;
                    LinkButton10.Visible = true;
                    lblp10.Visible = true;
                }
            }

            if (ds.Tables[0].Rows[10][0] != null)
            {
                if (count == 10)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton11.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp11.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label13.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton11.Visible = true;
                    LinkButton11.Visible = true;
                    lblp11.Visible = true;
                }
            }

            if (ds.Tables[0].Rows[11][0] != null)
            {
                if (count == 11)
                {
                    s = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LinkButton12.Text = Convert.ToString(ds.Tables[0].Rows[i][1]);
                    lblp12.Text = Convert.ToString(ds.Tables[0].Rows[i][2]);
                    Label14.Text = Convert.ToString(ds.Tables[0].Rows[i][3]);
                    ImageButton12.Visible = true;
                    LinkButton12.Visible = true;
                    lblp12.Visible = true;
                }
            }
            return (s);
        }
        catch (Exception e)
        {
            return (s);
        }

    }


    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label3.Text;
        Response.Redirect("ProductDetails.aspx");
    }

    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label3.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label4.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton2_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label4.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton3_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label5.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton3_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label5.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton4_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label6.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton4_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label6.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton5_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label7.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton5_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label7.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton6_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label8.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton6_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label8.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton7_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label9.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton7_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label9.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton8_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label10.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton8_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label10.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton9_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label11.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton9_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label11.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton10_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label12.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton10_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label12.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton11_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label13.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton11_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label13.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void ImageButton12_Click1(object sender, ImageClickEventArgs e)
    {
        Session["pid"] = Label14.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void LinkButton12_Click1(object sender, EventArgs e)
    {
        Session["pid"] = Label14.Text;
        Response.Redirect("ProductDetails.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label15.Text = Convert.ToString(Convert.ToInt32(Label15.Text) + 12);
        Label16.Text = Convert.ToString(Convert.ToInt32(Label16.Text) - 12);
        int count = 0;
        if (Convert.ToInt32(Label16.Text) <= Convert.ToInt32(Label15.Text))
        {
            Button2.Visible = false;
            Button1.Visible = true;
        }
        else if (Convert.ToInt32(Label15.Text) >= 12)
        {
            Button2.Visible = true;
            Button1.Visible = true;

        }
        string s1 = ImageFiller1(Convert.ToInt32(Label15.Text) + 0, count + 0);

        ImageButton1.ImageUrl = s1;
        if (s1 == "")
        {
            ImageButton1.Visible = false;
            LinkButton1.Visible = false;
            lblp1.Visible = false;
            // Label1.Visible = false;

        }

        string s2 = ImageFiller1(Convert.ToInt32(Label15.Text) + 1, count + 1);
        ImageButton2.ImageUrl = s2;
        if (s2 == "")
        {
            ImageButton2.Visible = false;
            LinkButton2.Visible = false;
            lblp2.Visible = false;
            //Label2.Visible = false;

        }


        string s3 = ImageFiller1(Convert.ToInt32(Label15.Text) + 2, count + 2);
        ImageButton3.ImageUrl = s3;
        if (s3 == "")
        {
            ImageButton3.Visible = false;
            LinkButton3.Visible = false;
            //Label3.Visible = false;
            lblp3.Visible = false;

        }


        string s4 = ImageFiller1(Convert.ToInt32(Label15.Text) + 3, count + 3);
        ImageButton4.ImageUrl = s4;
        if (s4 == "")
        {
            ImageButton4.Visible = false;
            LinkButton4.Visible = false;
            lblp4.Visible = false;
            // Label4.Visible = false;

        }


        string s5 = ImageFiller1(Convert.ToInt32(Label15.Text) + 4, count + 4);
        ImageButton5.ImageUrl = s5;
        if (s5 == "")
        {
            ImageButton5.Visible = false;
            LinkButton5.Visible = false;
            lblp5.Visible = false;
            //Label5.Visible = false;

        }


        string s6 = ImageFiller1(Convert.ToInt32(Label15.Text) + 5, count + 5);
        ImageButton6.ImageUrl = s6;

        if (s6 == "")
        {
            ImageButton6.Visible = false;
            LinkButton6.Visible = false;
            lblp6.Visible = false;
            // Label6.Visible = false;
        }

        string s7 = ImageFiller1(Convert.ToInt32(Label15.Text) + 6, count + 6);
        ImageButton7.ImageUrl = s7;
        if (s7 == "")
        {
            ImageButton7.Visible = false;
            LinkButton7.Visible = false;
            lblp7.Visible = false;
            //Label7.Visible = false;

        }
        string s8 = ImageFiller1(Convert.ToInt32(Label15.Text) + 7, count + 7);
        ImageButton8.ImageUrl = s8;
        if (s8 == "")
        {
            ImageButton8.Visible = false;
            LinkButton8.Visible = false;
            lblp8.Visible = false;
            // Label8.Visible = false;

        }
        string s9 = ImageFiller1(Convert.ToInt32(Label15.Text) + 8, count + 8);
        ImageButton9.ImageUrl = s9;
        if (s9 == "")
        {
            ImageButton9.Visible = false;
            LinkButton9.Visible = false;
            lblp9.Visible = false;
            // Label8.Visible = false;

        }

        string s10 = ImageFiller1(Convert.ToInt32(Label15.Text) + 9, count + 9);
        ImageButton10.ImageUrl = s10;
        if (s10 == "")
        {
            ImageButton10.Visible = false;
            LinkButton10.Visible = false;
            lblp10.Visible = false;
            //Label8.Visible = false;

        }

        string s11 = ImageFiller1(Convert.ToInt32(Label15.Text) + 10, count + 10);
        ImageButton11.ImageUrl = s11;
        if (s11 == "")
        {
            ImageButton11.Visible = false;
            LinkButton11.Visible = false;
            lblp11.Visible = false;
            // Label8.Visible = false;

        }

        string s12 = ImageFiller1(Convert.ToInt32(Label15.Text) + 11, count + 11);
        ImageButton12.ImageUrl = s12;
        if (s12 == "")
        {
            ImageButton12.Visible = false;
            LinkButton12.Visible = false;
            lblp12.Visible = false;
            //Label8.Visible = false;

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label15.Text = Convert.ToString(Convert.ToInt32(Label15.Text) - 12);
        Label16.Text = Convert.ToString(Convert.ToInt32(Label16.Text) + 12);
        if (Convert.ToInt32(Label15.Text) == 0)
        {
            Button1.Visible = false;
            Button2.Visible = true;
        }
        else if (Convert.ToInt32(Label16.Text) > 0)
        {
            Button1.Visible = true;
            Button2.Visible = true;
        }
        int count = 0;

        string s1 = ImageFiller1(Convert.ToInt32(Label15.Text) + 0, count + 0);

        ImageButton1.ImageUrl = s1;
        if (s1 == "")
        {
            ImageButton1.Visible = false;
            LinkButton1.Visible = false;
            lblp1.Visible = false;
            // Label1.Visible = false;

        }

        string s2 = ImageFiller1(Convert.ToInt32(Label15.Text) + 1, count + 1);
        ImageButton2.ImageUrl = s2;
        if (s2 == "")
        {
            ImageButton2.Visible = false;
            LinkButton2.Visible = false;
            lblp2.Visible = false;
            //Label2.Visible = false;

        }


        string s3 = ImageFiller1(Convert.ToInt32(Label15.Text) + 2, count + 2);
        ImageButton3.ImageUrl = s3;
        if (s3 == "")
        {
            ImageButton3.Visible = false;
            LinkButton3.Visible = false;
            //Label3.Visible = false;
            lblp3.Visible = false;

        }


        string s4 = ImageFiller1(Convert.ToInt32(Label15.Text) + 3, count + 3);
        ImageButton4.ImageUrl = s4;
        if (s4 == "")
        {
            ImageButton4.Visible = false;
            LinkButton4.Visible = false;
            lblp4.Visible = false;
            // Label4.Visible = false;

        }


        string s5 = ImageFiller1(Convert.ToInt32(Label15.Text) + 4, count + 4);
        ImageButton5.ImageUrl = s5;
        if (s5 == "")
        {
            ImageButton5.Visible = false;
            LinkButton5.Visible = false;
            lblp5.Visible = false;
            //Label5.Visible = false;

        }


        string s6 = ImageFiller1(Convert.ToInt32(Label15.Text) + 5, count + 5);
        ImageButton6.ImageUrl = s6;

        if (s6 == "")
        {
            ImageButton6.Visible = false;
            LinkButton6.Visible = false;
            lblp6.Visible = false;
            // Label6.Visible = false;
        }

        string s7 = ImageFiller1(Convert.ToInt32(Label15.Text) + 6, count + 6);
        ImageButton7.ImageUrl = s7;
        if (s7 == "")
        {
            ImageButton7.Visible = false;
            LinkButton7.Visible = false;
            lblp7.Visible = false;
            //Label7.Visible = false;

        }
        string s8 = ImageFiller1(Convert.ToInt32(Label15.Text) + 7, count + 7);
        ImageButton8.ImageUrl = s8;
        if (s8 == "")
        {
            ImageButton8.Visible = false;
            LinkButton8.Visible = false;
            lblp8.Visible = false;
            // Label8.Visible = false;

        }
        string s9 = ImageFiller1(Convert.ToInt32(Label15.Text) + 8, count + 8);
        ImageButton9.ImageUrl = s9;
        if (s9 == "")
        {
            ImageButton9.Visible = false;
            LinkButton9.Visible = false;
            lblp9.Visible = false;
            // Label8.Visible = false;

        }

        string s10 = ImageFiller1(Convert.ToInt32(Label15.Text) + 9, count + 9);
        ImageButton10.ImageUrl = s10;
        if (s10 == "")
        {
            ImageButton10.Visible = false;
            LinkButton10.Visible = false;
            lblp10.Visible = false;
            //Label8.Visible = false;

        }

        string s11 = ImageFiller1(Convert.ToInt32(Label15.Text) + 10, count + 10);
        ImageButton11.ImageUrl = s11;
        if (s11 == "")
        {
            ImageButton11.Visible = false;
            LinkButton11.Visible = false;
            lblp11.Visible = false;
            // Label8.Visible = false;

        }

        string s12 = ImageFiller1(Convert.ToInt32(Label15.Text) + 11, count + 11);
        ImageButton12.ImageUrl = s12;
        if (s12 == "")
        {
            ImageButton12.Visible = false;
            LinkButton12.Visible = false;
            lblp12.Visible = false;
            //Label8.Visible = false;

        }
    }
}