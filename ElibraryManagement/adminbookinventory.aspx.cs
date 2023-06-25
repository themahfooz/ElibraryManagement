using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
    public partial class adminbookinventory : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        // Go Button
        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        // Add Button
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        // Update Button
        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        // Delete Button
        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        void fillAuthorPublisherValues() { 

        }

        void addNewBook() { 
        }

    }
}