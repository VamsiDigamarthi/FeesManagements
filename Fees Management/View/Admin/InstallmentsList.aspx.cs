using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Text;

namespace Fees_Management.View.Admin
{
    public partial class InstallmentsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insta1btn_Click(object sender, EventArgs e)
        {
            string strConnString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select StId,Name,GroupName,Fees,CourseYear,Installments,Paid_Amount from StudentRegister1 where Installments='1'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void insta2btn_Click(object sender, EventArgs e)
        {
            string strConnString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select StId,Name,GroupName,Fees,CourseYear,Installments,Paid_Amount,SecondInstallment,Balence from StudentRegister1 where Installments='2'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void insta3btn_Click(object sender, EventArgs e)
        {
            string strConnString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select StId,Name,GroupName,Fees,CourseYear,Installments,Paid_Amount,SecondInstallment,ThirdInstallment,Balence from StudentRegister1 where Installments='3'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void excelpdf_Click(object sender, EventArgs e)
        {
            if (GridView1.Rows.Count > 0)
            {
                Response.Clear();
                Response.Buffer = true;
                Response.ClearContent();
                Response.ClearHeaders();
                Response.Charset = "";
                string FileName = "School" + DateTime.Now + ".xls";
                StringWriter strwritter = new StringWriter();
                HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.ContentType = "application/vnd.ms-excel";
                Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
                GridView1.GridLines = GridLines.Both;
                GridView1.HeaderStyle.Font.Bold = true;
                GridView1.RenderControl(htmltextwrtter);
                Response.Write(strwritter.ToString());
                Response.End();
            }
            else
            {
                Response.Write("<script>alert('No Record Found.......')</script>");
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }

        protected void compleateinstallbtn_Click(object sender, EventArgs e)
        {
            string strConnString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select StId,Name,GroupName,Fees,CourseYear,Installments,Paid_Amount,SecondInstallment,ThirdInstallment,Balence from StudentRegister1 where Balence='0'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void printbtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Report");
        }
    }
}