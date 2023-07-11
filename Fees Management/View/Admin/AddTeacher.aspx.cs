using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Fees_Management.View.Admin
{
    public partial class AddTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaddadminteacher_Click(object sender, EventArgs e)
        {
            string Role = "";
            if (rdbadmin.Checked == true)
            {
                Role = rdbadmin.Text;
            }
            else
            {
                Role = rdbteacher.Text;
            }
            string maicon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(maicon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into LogInUser (UserEmail,UserPassword,UserRole) values(@UserEmail,@UserPassword,@UserRole)", con);
            cmd.Parameters.AddWithValue("@UserEmail", txtemail.Text);
            cmd.Parameters.AddWithValue("@UserPassword", txtpass.Text);
            cmd.Parameters.AddWithValue("@UserRole", Role);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("<script>alert('Successful.....')</script>");
            }
            else
            {
                Response.Write("<script>alert('Failed.....')</script>");
            }
        }
    }
}