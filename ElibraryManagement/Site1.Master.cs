using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    LinkButton1.Visible = true;  //user login button
                    LinkButton2.Visible = true;  //sign up button
                    LinkButton3.Visible = false;  //logout button
                    LinkButton7.Visible = false;  //hello user button

                    LinkButton6.Visible = true;  //admin login button
                    LinkButton11.Visible = false;  //author management button
                    LinkButton12.Visible = false;  //publisher management button
                    LinkButton8.Visible = false;  //book inventary button
                    LinkButton9.Visible = false;  //book issueing button
                    LinkButton10.Visible = false;  //member management button
                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false;  //user login button
                    LinkButton2.Visible = false;  //sign up button
                    LinkButton3.Visible = true;  //logout button
                    LinkButton7.Visible = true;  //hello user button
                    LinkButton7.Text = "Hello" + " " + Session["username"].ToString();

                    LinkButton6.Visible = true;  //admin login button
                    LinkButton11.Visible = false;  //author management button
                    LinkButton12.Visible = false;  //publisher management button
                    LinkButton8.Visible = false;  //book inventary button
                    LinkButton9.Visible = false;  //book issueing button
                    LinkButton10.Visible = false;  //member management button
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;  //user login button
                    LinkButton2.Visible = false;  //sign up button
                    LinkButton3.Visible = true;  //logout button
                    LinkButton7.Visible = true;  //hello user button
                    LinkButton7.Text = "Hello Admin";

                    LinkButton6.Visible = false;  //admin login button
                    LinkButton11.Visible = true;  //author management button
                    LinkButton12.Visible = true;  //publisher management button
                    LinkButton8.Visible = true;  //book inventary button
                    LinkButton9.Visible = true;  //book issueing button
                    LinkButton10.Visible = true;  //member management button
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissueing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["UserName"] = "";
            Session["FullName"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true;  //user login button
            LinkButton2.Visible = true;  //sign up button
            LinkButton3.Visible = false;  //logout button
            LinkButton7.Visible = false;  //hello user button

            LinkButton6.Visible = true;  //admin login button
            LinkButton11.Visible = false;  //author management button
            LinkButton12.Visible = false;  //publisher management button
            LinkButton8.Visible = false;  //book inventary button
            LinkButton9.Visible = false;  //book issueing button
            LinkButton10.Visible = false;  //member management button

            Response.Redirect("homepage.aspx");
        }
    }
}