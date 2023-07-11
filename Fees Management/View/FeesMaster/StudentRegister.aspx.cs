using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;

namespace Fees_Management.View.FeesMaster
{
    public partial class StudentRegister : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddDays(-1));
            Response.Cache.SetNoStore();
            Response.Cache.SetProxyMaxAge(new TimeSpan(0, 0, 0));
            Response.Cache.SetValidUntilExpires(false);
            Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);

            lblsecondinstal.Visible = false;
            txtsecinstall.Visible = false;
            lblSecond_IstallmentDate.Visible = false;
            txtsecdate.Visible = false;
            lblThird_Istallment.Visible = false;
            txtthird.Visible = false;
            lblThird_IstallmentDate.Visible = false;
            txtthirddate.Visible = false;

            txtjoin.Text = DateTime.Now.ToString();
            txtpaid.ReadOnly = false;
            //txtsecdate.Text = "0";
           // txtthirddate.Text = "0";
            if (!IsPostBack)
            {
                ShowPlan();
            }

        }

        private void ShowPlan()
        {
            ddlgroup.Items.Add(new ListItem("-- Select Group --", ""));
            ddlgroup.AppendDataBoundItems = true;
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
                ddlgroup.DataSource = cmd.ExecuteReader();
                ddlgroup.DataTextField = "GroupName";
                ddlgroup.DataValueField = "Id";
                ddlgroup.DataBind();
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

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (rdbmale.Checked == true)
            {
                Gender = rdbmale.Text;
            }
            else
            {
                Gender = rdbfemale.Text;
            }
            String strConnString = ConfigurationManager
                        .ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into StudentRegister1 (Name ,Email ,Phone ,Gender,JoinDate,GroupName,Fees,MinFeesPay,CourseYear,Installments,PaymentMode,Paid_Amount,Balence,SecondInstallment,Second_IstallmentDate,ThirdInstallment,Third_InstallmentDate) values(@Name,@Email,@Phone,@Gender,@JoinDate,@GroupName,@Fees,@MinFeesPay,@CourseYear,@Installments,@PaymentMode,@Paid_Amount,@Balence,@SecondInstallment,@Second_IstallmentDate,@ThirdInstallment,@Third_InstallmentDate)", con);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@JoinDate", txtjoin.Text);
            cmd.Parameters.AddWithValue("@GroupName", ddlgroup.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Fees", txtfees.Text);          
            cmd.Parameters.AddWithValue("@MinFeesPay", txtminfees.Text);
            cmd.Parameters.AddWithValue("@CourseYear", ddlcourseyear.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Installments", ddlinstallments.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@PaymentMode", ddlpaymentmode.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@Paid_Amount", txtpaid.Text);
            cmd.Parameters.AddWithValue("@Balence", txtbalence.Text);
            cmd.Parameters.AddWithValue("@SecondInstallment", txtsecinstall.Text);
            cmd.Parameters.AddWithValue("@Second_IstallmentDate", txtsecdate.Text);
            cmd.Parameters.AddWithValue("@ThirdInstallment", txtthird.Text);
            cmd.Parameters.AddWithValue("@Third_InstallmentDate", txtthirddate.Text);
            int i = cmd.ExecuteNonQuery();
            if (ddlinstallments.Text == "1")
            {
                MailMessage mm = new MailMessage("software.trainee1@brihaspathi.com", txtemail.Text);
                mm.Subject = "Student Registation Details....!";
                mm.Body = "Hi ,<br/>Mr/Ms " + txtname.Text + "<br />Your Course Name   :  " + ddlgroup.SelectedItem.Text + "<br />Group Joining Date   :      " + txtjoin.Text + "<br/>Your Group Fees is   :     " + txtfees.Text + "<br />You have Paid Amount :   " + txtpaid.Text + "<br/>" +"You Group fees was cleared <br/>Thank You";
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                NetworkCredential nc = new NetworkCredential("software.trainee1@brihaspathi.com", "RAVI8297");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = nc;
                smtp.Send(mm);
            }
            else if (ddlinstallments.Text == "2")
            {
                MailMessage mm = new MailMessage("software.trainee1@brihaspathi.com", txtemail.Text);
                mm.Subject = "Student Registation Details....!";
                mm.Body = "Hi ,<br/>Mr/Ms " + txtname.Text + "<br />Your Group Name  : " + ddlgroup.SelectedItem.Text + "<br />Group Joining Date   :      " + txtjoin.Text + "<br/>Your Group Fees is   :     " + txtfees.Text + "<br />You have Paid Amount :   " + txtpaid.Text + "<br/>The Remaining Due is :   " + txtbalence.Text + "<br/>2nd Installment Date :   " + txtsecdate.Text + "<br/>" +
                  "<h3 style='color:red'>Note : The certificate will not Issued Untill the balence Amount is clear</h3>";
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                NetworkCredential nc = new NetworkCredential("software.trainee1@brihaspathi.com", "RAVI8297");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = nc;
                smtp.Send(mm);
            }
            else if (ddlinstallments.Text == "3")
            {
                MailMessage mm = new MailMessage("software.trainee1@brihaspathi.com", txtemail.Text);
                mm.Subject = "Student Registation Details....!";
                mm.Body = "Hi ,<br/>Mr/Ms " + txtname.Text + "<br />Your Group Name  : " + ddlgroup.SelectedItem.Text + "<br />Group Joining Date   :      " + txtjoin.Text + "<br/>Your Group Fees is   :     " + txtfees.Text + "<br />You have Paid Amount :   " + txtpaid.Text + "<br/>The Remaining Due is :   " + txtbalence.Text + "<br/>2nd Installment Date :   " + txtsecdate.Text + "<br/>3rd Installment Date :   " + txtthirddate.Text + "<br/>" +
                  "<h3 style='color:red'>Note : The certificate will not Issued Untill the balence Amount is clear</h3>";
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                NetworkCredential nc = new NetworkCredential("software.trainee1@brihaspathi.com", "RAVI8297");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = nc;
                smtp.Send(mm);
            }
            if (i > 0)
            {
                Response.Write("<script>alert('Registered Successfully.....!')</script>");
            }
            con.Close();
            txtname.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtpaid.Text = "";
            txtbalence.Text = "";
            txtsecinstall.Text = "";
            txtthird.Text = "";
            txtfees.Text = "";
            txtminfees.Text = "";
            ddlgroup.SelectedItem.Value = "";
            ddlcourseyear.SelectedItem.Value = "";
            ddlinstallments.SelectedItem.Value = "";
            ddlpaymentmode.SelectedItem.Value = "";
        }


        protected void ddlgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            String strConnString = ConfigurationManager
                         .ConnectionStrings["MyConnection"].ConnectionString;
            String strQuery = "select Amount, MinPaid from AddGroupName1 where" +
                              " Id = @Id";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Id", ddlgroup.SelectedItem.Value);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;          
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtfees.Text = sdr[0].ToString();
                    txtminfees.Text = sdr["MinPaid"].ToString();                
                }
                string word = ConvertNumbertoWords(Convert.ToInt32(txtfees.Text));
                lblwords.Text = word;
                lblwords.ForeColor = System.Drawing.Color.Green;
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

        protected void txtpaid_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtminfees.Text) < Convert.ToInt32(txtpaid.Text))
            {
                int bal = Convert.ToInt32(txtfees.Text) - Convert.ToInt32(txtpaid.Text);
                txtbalence.Text = bal.ToString();
                if (ddlinstallments.Text == "2")
                {
                    lblsecondinstal.Visible = true;
                    txtsecinstall.Visible = true;
                    lblSecond_IstallmentDate.Visible = true;
                    txtsecdate.Visible = true;
                    lblThird_Istallment.Visible = false;
                    txtthird.Visible = false;
                    lblThird_IstallmentDate.Visible = false;
                    txtthirddate.Visible = false;
                    txtpaid.ReadOnly = false;
                }
                else if (ddlinstallments.Text == "3")
                {
                    lblsecondinstal.Visible = true;
                    txtsecinstall.Visible = true;
                    lblSecond_IstallmentDate.Visible = true;
                    txtsecdate.Visible = true;
                    lblsecondinstal.Visible = true;
                    txtsecinstall.Visible = true;
                    lblSecond_IstallmentDate.Visible = true;
                    txtsecdate.Visible = true;
                    lblThird_Istallment.Visible = true;
                    txtthird.Visible = true;
                    lblThird_IstallmentDate.Visible = true;
                    txtthirddate.Visible = true;
                    txtpaid.ReadOnly = false;
                }
            }
            else
            {
                // Response.Write("Please Paid  "+txtminfees.Text+"  Above");
                Response.Write("<script>alert('Please Paid  " + txtminfees.Text + "  Above...')</script>");
            }
        }

        protected void ddlinstallments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlinstallments.SelectedValue == "1")
            {
                txtpaid.Text = txtfees.Text;
                txtbalence.Text = "0";
                txtsecinstall.Text = "0";
                txtthird.Text = "0";
                txtpaid.ReadOnly = true;
                txtsecdate.Text = "0";
                txtthirddate.Text = "0";

                lblsecondinstal.Visible = false;
                txtsecinstall.Visible = false;
                lblSecond_IstallmentDate.Visible = false;
                txtsecdate.Visible = false;
                lblThird_Istallment.Visible = false;
                txtthird.Visible = false;
                lblThird_IstallmentDate.Visible = false;
                txtthirddate.Visible = false;
            }
            else if (ddlinstallments.SelectedValue == "2")
            {
                txtsecinstall.Text = "0";
                txtsecinstall.ReadOnly = true;
                txtpaid.Text = "";
                // txtbalence.Text = "0";
                DateTime nowdate = DateTime.Now;
                DateTime newDate = nowdate.AddMonths(6);
                txtsecdate.Text = newDate.ToString("dd/MM/yyyy");
                txtthird.Text = "0";
                txtthird.ReadOnly = true;
                txtthirddate.Text = "0";

                lblsecondinstal.Visible = true;
                txtsecinstall.Visible = true;
                lblSecond_IstallmentDate.Visible = true;
                txtsecdate.Visible = true;
                lblThird_Istallment.Visible = false;
                txtthird.Visible = false;
                lblThird_IstallmentDate.Visible = false;
                txtthirddate.Visible = false;
            }
            else
            {
                txtpaid.Text = "";
                txtbalence.Text = "0";
                DateTime nowdate = DateTime.Now;
                DateTime newDate = nowdate.AddMonths(3);
                DateTime newDate2 = nowdate.AddMonths(6);
                txtsecdate.Text = newDate.ToString("dd/MM/yyyy");
                txtthirddate.Text = newDate2.ToString("dd/MM/yyyy");
                txtsecinstall.Text = "0";
                txtsecinstall.ReadOnly = true;
                txtthird.Text = "0";
                txtthird.ReadOnly = true;

                lblsecondinstal.Visible = true;
                txtsecinstall.Visible = true;
                lblSecond_IstallmentDate.Visible = true;
                txtsecdate.Visible = true;
                lblThird_Istallment.Visible = true;
                txtthird.Visible = true;
                lblThird_IstallmentDate.Visible = true;
                txtthirddate.Visible = true;
            }
        }
        public static string ConvertNumbertoWords(int number)
        {
            if (number == 0)
                return "ZERO";
            if (number < 0)
                return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000000) + " MILLION ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                    words += "AND ";
                var unitsMap = new[] { "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
                var tensMap = new[] { "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }
    }
}