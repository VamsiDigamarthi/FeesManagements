using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fees_Management.View.FeesMaster
{
    public partial class Cashear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnregister_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentRegister.aspx");
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            String connString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name, Email, Phone,JoinDate,GroupName,CourseYear,Fees,Paid_Amount,Balence,SecondInstallment,ThirdInstallment FROM StudentRegister1" +
                " where Id=@Id ", con);
            cmd.Parameters.AddWithValue("@Id", textboxid.Text);
            using (SqlDataReader myReader = cmd.ExecuteReader())
            {
                if (myReader.Read())
                {
                    txtname.Text = myReader["Name"].ToString();
                    txtemail.Text = myReader["Email"].ToString();
                    txtphone.Text = myReader["Phone"].ToString();
                    txtjoin.Text = myReader["JoinDate"].ToString();
                    txtgroup.Text = myReader["GroupName"].ToString();
                    txtcourseyear.Text = myReader["CourseYear"].ToString();
                    txtfees.Text = myReader["Fees"].ToString();                  
                    txtpaid.Text = myReader["Paid_Amount"].ToString();
                    txtbalence.Text = myReader["Balence"].ToString();
                }
            }
        }

        protected void txtfees_TextChanged(object sender, EventArgs e)
        {
            int bale = Convert.ToInt32(txtfees.Text) - Convert.ToInt32(txtpaid.Text);
            txtbalence.Text = bale.ToString();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            String connString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update StudentRegister1 set Name=@Name,Email=@Email,Phone=@Phone,JoinDate=@JoinDate,GroupName=@GroupName,CourseYear=@CourseYear,Fees=@Fees,Paid_Amount=@Paid_Amount,Balence=@Balence where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", textboxid.Text);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@JoinDate", txtjoin.Text);
            cmd.Parameters.AddWithValue("@GroupName", txtgroup.Text);
            cmd.Parameters.AddWithValue("@CourseYear", txtcourseyear.Text);
            cmd.Parameters.AddWithValue("@Fees", txtfees.Text);
            cmd.Parameters.AddWithValue("@Paid_Amount", txtpaid.Text);
            cmd.Parameters.AddWithValue("@Balence", txtbalence.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("<script>alert('UPDATED SUCCESSFULLY...')</script>");
            }
            else
            {
                Response.Write("<script>alert('Failed...')</script>");
            }

        }
    }
}