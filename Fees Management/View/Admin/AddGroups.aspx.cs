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
    public partial class AddGroups : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaddgroup_Click(object sender, EventArgs e)
        {
            string maincon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(maincon);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("insert into AddGroupName1(GroupName,Amount,MinPaid) values(@GroupName,@Amount,@MinPaid)", sqlcon);
            cmd.Parameters.AddWithValue("@GroupName", txtgroupname.Text);
            cmd.Parameters.AddWithValue("@Amount", txtamount.Text);
            cmd.Parameters.AddWithValue("@MinPaid", txtminfees.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("<script>alert('Insertedd Successfully.....!')</script>");
            }
            else
            {
                
            }
            sqlcon.Close();
        }
    }
}