using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Fees_Management
{
    public partial class LogInRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            String strConnString = ConfigurationManager
                        .ConnectionStrings["MyConnection"].ConnectionString;
            
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into LogInUser(UserEmail,UserPassword,UserRole) values(@UserEmail,@UserPassword,@UserRole)", con);
            cmd.Parameters.AddWithValue("@UserEmail", txtemail.Text);
            cmd.Parameters.AddWithValue("@UserPassword", txtpassword.Text);
            cmd.Parameters.AddWithValue("@UserRole", txtrole.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("<script>alert('Inserted......')</Script>");
            }
            else
            {
                Response.Write("<script>alert('Failed......')</Script>");
            }
            con.Close();
        }
    }
}