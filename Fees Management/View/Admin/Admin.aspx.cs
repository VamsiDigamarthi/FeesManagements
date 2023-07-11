using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fees_Management.View.Admin
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentCount();
            GroupsCount();
            TeacherCount();
            if (!IsPostBack)
            {
                ShowPlan();
            }
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

        private void ShowPlan()
        {
            DropDownList2.Items.Add(new ListItem("-- Select Group --", ""));
            DropDownList2.AppendDataBoundItems = true;
            string maincon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(maincon);
            String strQuery = "select Id, GroupName from AddGroupName1";
            SqlConnection con = new SqlConnection(maincon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;
            try
            {
                con.Open();
                DropDownList2.DataSource = cmd.ExecuteReader();
                DropDownList2.DataTextField = "GroupName";
                DropDownList2.DataValueField = "Id";
                DropDownList2.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void GroupsCount()
        {
            string strConnString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
           SqlCommand cmd = new SqlCommand("select count(*) as TotalCount from AddGroupName1", con);
           using(SqlDataReader reader = cmd.ExecuteReader())
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

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maicon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(maicon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select GroupName from StudentRegister1 where" +
                              " GroupName = @GroupName", con);
            cmd.Parameters.AddWithValue("@GroupName", DropDownList2.SelectedItem.Text);
           
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            string maicon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(maicon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select StId,Name,JoinDate,GroupName,Fees,CourseYear,Paid_Amount,SecondInstallment,ThirdInstallment,Balence from StudentRegister1 where CourseYear='" + DropDownList1.SelectedItem.Text+ "' and GroupName='"+DropDownList2.SelectedItem.Text+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        //protected void btngroup_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("AddGroups.aspx");
        //}

        //protected void btnteacher_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("AddTeacher.aspx");
        //}
    }
}