using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fees_Management.View.FeesMaster
{
    public partial class DashBoard2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentCount();
            GroupsCount();
            TeacherCount();
        }

        private void TeacherCount()
        {
            string strConnString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) as TotalCount from LogInUser where UserRole='Teacher' ", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Label3.Text = reader["TotalCount"].ToString();
                }
                reader.Close();
            }
            con.Close();
            con.Dispose();
        }

        private void GroupsCount()
        {
            string strConnString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) as TotalCount from AddGroupName1", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Label1.Text = reader["TotalCount"].ToString();
                }
                reader.Close();
            }
            con.Close();
            con.Dispose();
        }

        private void StudentCount()
        {
            String strConnString = ConfigurationManager
                              .ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) as TotalCount FROM StudentRegister1", con);
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Label2.Text = reader["TotalCount"].ToString();
                }
                reader.Close();
            }
            con.Close();
            con.Dispose();
        }
    }
}