using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Fees_Management
{
    public partial class Log_In : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            String strConnString = ConfigurationManager
                        .ConnectionStrings["MyConnection"].ConnectionString;

            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from LogInUser", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int rowcount = dt.Rows.Count;
            for (int i = 0; i < rowcount; i++)
            {
                string username = dt.Rows[i]["UserEmail"].ToString();
                string password = dt.Rows[i]["UserPassword"].ToString();
                if (username == txtemail.Text && password == txtpass.Text)
                {
                    Session["UserEmail"] = username;
                    if (dt.Rows[i]["UserRole"].ToString() == "Admin")
                    {
                        Response.Redirect("View/Admin/Admin.aspx");
                    }
                    else if (dt.Rows[i]["UserRole"].ToString() == "Teacher")
                    {
                        Response.Redirect("View/FeesMaster/Cashear.aspx");
                    }                  
                    else
                    {
                        Response.Redirect("Log In.aspx");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Failed....')</script>");
                }
            }          
        }
    }
}