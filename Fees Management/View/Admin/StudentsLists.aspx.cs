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
    public partial class StudentsLists : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AllData();
            }
        }

        private void AllData()
        {
            String strConnString = ConfigurationManager
                               .ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM AddGroupName1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btngroup_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddGroups.aspx");
        }

        protected void btnteacher_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddTeacher.aspx");
        }
    }
}