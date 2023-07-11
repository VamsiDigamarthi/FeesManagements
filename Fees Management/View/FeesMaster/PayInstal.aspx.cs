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
using System.IO;

namespace Fees_Management.View.FeesMaster
{
    public partial class PayInstal : System.Web.UI.Page
    {
        string UserName= "software.trainee1@brihaspathi.com";
        string PassWord="RAVI8297";
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["UserEmail"] != null && Session["UserPassword"]!=null)
            //{
            //    UsernamePassword();
            //}

            txtid.Visible = true;
            txtname.Visible = false;
            txtemail.Visible = false;
            txtjoin.Visible = false;
            txtgroup.Visible = false;
            txtfees.Visible = false;
            txtinstalments.Visible = false;
            txtfirst.Visible = false;
            txtbalence.Visible = false;
            txtsecond.Visible = false;
            txtthird.Visible = false;
            txtcourseyear.Visible = false;

            Label1.Visible = true;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            Label6.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            lblthird.Visible = false;
            btnpayinstallments.Visible = false;
        }

        //private void UsernamePassword()
        //{
        //    UserName = Session["UserEmail"].ToString();
        //    PassWord = Session["UserPassword"].ToString();
        //    String connString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        //    SqlConnection con = new SqlConnection(connString);
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select UserEmail,UserPassword from LogInUser where UserEmail=@UserEmail,UserPassword=@UserPassword", con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);                       
        //}

        protected void txtid_TextChanged(object sender, EventArgs e)
        {            
            
            txtname.Visible = true;
            txtemail.Visible = true;
            txtjoin.Visible = true;
            txtgroup.Visible = true;
            txtfees.Visible = true;
            txtinstalments.Visible = true;
            txtfirst.Visible = true;
            txtbalence.Visible = true;
            txtsecond.Visible = true;
            txtthird.Visible = true;
            txtcourseyear.Visible = true;
            btnpayinstallments.Visible = true;

            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label6.Visible = true;
            Label7.Visible = true;
            Label8.Visible = true;
            Label9.Visible = true;
            Label10.Visible = true;
            Label11.Visible = true;
            String connString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);           
                con.Open();
            SqlCommand cmd =new SqlCommand("SELECT Name, Email, JoinDate,GroupName,CourseYear,Fees,Installments,Paid_Amount,Balence,SecondInstallment,ThirdInstallment FROM StudentRegister1" +
                " where Id=@Id ", con);
            cmd.Parameters.AddWithValue("@Id", txtid.Text);
            cmd.Parameters.AddWithValue("@StId", txtid.Text);
              using (SqlDataReader myReader = cmd.ExecuteReader())
              {
                    if (myReader.Read())
                    {
                        lblmsg.Visible = false;
                        txtname.Text = myReader["Name"].ToString();
                        txtemail.Text = myReader["Email"].ToString();
                        txtjoin.Text = myReader["JoinDate"].ToString();
                        txtgroup.Text = myReader["GroupName"].ToString();
                        txtcourseyear.Text = myReader["CourseYear"].ToString();
                        txtfees.Text = myReader["Fees"].ToString();
                        txtinstalments.Text = myReader["Installments"].ToString();
                        txtfirst.Text = myReader["Paid_Amount"].ToString();
                        txtbalence.Text = myReader["Balence"].ToString();
                    if (myReader["Balence"].ToString() == "0")
                    {
                        btnpayinstallments.Visible = false;
                        lblmsg.Text = "You have cleared Your fees amount...";
                        Response.Write("<script>alert('You have cleared Your fees amount...')</script>");
                    }
                        if (myReader["SecondInstallment"].ToString() == "0")
                        {
                            txtsecond.Text = myReader["SecondInstallment"].ToString();
                            txtthird.ReadOnly = true;
                            txtthird.Visible = false;
                            lblthird.Visible = false;
                        }
                        if (myReader["SecondInstallment"].ToString() != "0")
                        {
                            txtsecond.Text = myReader["SecondInstallment"].ToString();
                            txtsecond.ReadOnly = true;
                            txtthird.ReadOnly = false;
                        }
                        if (myReader["ThirdInstallment"].ToString() != "0" || myReader["ThirdInstallment"].ToString() != "")
                        {
                            txtthird.Text = myReader["ThirdInstallment"].ToString();
                            txtthird.ReadOnly = true;
                        }                     
                        if (txtinstalments.Text == "2")
                        {
                             if (txtbalence.Text == "0")
                             {
                                txtthird.Visible = false;
                                lblthird.Visible = false;
                             }
                        }
                        if (txtinstalments.Text == "1")
                        {
                            txtsecond.ReadOnly = true;
                            txtthird.Text = "0";
                            lblthird.Visible = true;
                        }

                        if (txtinstalments.Text == "3")
                        {
                            if (txtsecond.Text != "0" || txtsecond.Text != "")
                            {
                                txtthird.ReadOnly = false;
                                lblthird.Visible = true;
                                txtthird.Visible = true;
                            }
                        }
                        if (txtinstalments.Text == "3")
                        {
                            if (txtbalence.Text == "0")
                            {
                                txtthird.ReadOnly = true;
                            }
                        }
                        else
                        {
                            txtthird.Visible = true;
                            lblthird.Visible = true;
                        }
                    }
                    else
                    {
                        txtname.Visible = false;
                        txtemail.Visible = false;
                        txtjoin.Visible = false;
                        txtgroup.Visible = false;
                        txtfees.Visible = false;
                        txtinstalments.Visible = false;
                        txtfirst.Visible = false;
                        txtbalence.Visible = false;
                        txtsecond.Visible = false;
                        txtthird.Visible = false;
                        txtcourseyear.Visible = false;

                        Label1.Visible = true;
                        Label2.Visible = false;
                        Label3.Visible = false;
                        Label4.Visible = false;
                        Label5.Visible = false;
                        Label6.Visible = false;
                        Label7.Visible = false;
                        Label8.Visible = false;
                        Label9.Visible = false;
                        Label10.Visible = false;
                        Label11.Visible = false;
                        lblthird.Visible = false;
                        btnpayinstallments.Visible = false;
                        lblmsg.Text = "You Entered " + txtid.Text + " Its Wrong Id .......";
                        lblmsg.ForeColor = System.Drawing.Color.Red;
                    }
              }
                con.Close();
                                                           
        }

        protected void btnpayinstallments_Click(object sender, EventArgs e)
        {
            String connString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            con.Open();                      
            if (txtinstalments.Text == "2")
            {              
                int Remaining1 = ((Convert.ToInt32(txtfees.Text)) - (Convert.ToInt32(txtfirst.Text) + Convert.ToInt32(txtsecond.Text)));

                if (Convert.ToInt32(txtbalence.Text) == Convert.ToInt32(txtsecond.Text))
                {                  
                    SqlCommand cmd = new SqlCommand("update StudentRegister1 set SecondInstallment='" + txtsecond.Text + "',ThirdInstallment='" + txtthird.Text + "',Balence='" + Remaining1.ToString() + "' where Id='" + txtid.Text + "'", con);
                     int i = cmd.ExecuteNonQuery();
                     MailMessage mm = new MailMessage(UserName, txtemail.Text);
                     mm.Subject = "Student Registation Details....!";
                     mm.Body = "Hi,<br/> Mr/Ms   : " + txtname.Text + "<br />Your Group Name :  " + txtgroup.Text + "<br />The Group of " + txtgroup.Text + " " + txtcourseyear.Text + " 2nd installment Due is" + txtsecond.Text + "<br/>  Remaining Due : " + Remaining1.ToString() + "<br/>Your Fees amount was Cleared<br/> Thank You";
                     mm.IsBodyHtml = true;
                     SmtpClient smtp = new SmtpClient();
                     smtp.Host = "smtp.gmail.com";
                     smtp.Port = 587;
                     smtp.EnableSsl = true;
                     NetworkCredential nc = new NetworkCredential(UserName, PassWord);
                     smtp.UseDefaultCredentials = true;
                     smtp.Credentials = nc;
                     smtp.Send(mm);
                     if (i > 0)
                     {
                     txtthird.Text = "0";
                     ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + txtid.Text + "','" + txtname.Text + "','" + txtemail.Text + "','" + txtjoin.Text + "','" + txtgroup.Text + "','" + txtcourseyear.Text + "','" + txtfees.Text + "','" + txtinstalments.Text + "','" + txtfirst.Text + "','" + Remaining1.ToString() + "','" + txtsecond.Text + "','" + txtthird.Text + "');", true);                       
                     }
                     else
                     {
                         Response.Write("<script>alert('FAILED .......!')</script>");
                     }
                }
                else
                {
                     txtname.Visible = true;
                     txtemail.Visible = true;
                     txtjoin.Visible = true;
                     txtgroup.Visible = true;
                     txtfees.Visible = true;
                     txtinstalments.Visible = true;
                     txtfirst.Visible = true;
                     txtbalence.Visible = true;
                     txtsecond.Visible = true;
                     txtthird.Visible = true;
                     txtcourseyear.Visible = true;
                     btnpayinstallments.Visible = true;

                     Label2.Visible = true;
                     Label3.Visible = true;
                     Label4.Visible = true;
                     Label5.Visible = true;
                     Label6.Visible = true;
                     Label7.Visible = true;
                     Label8.Visible = true;
                     Label9.Visible = true;
                     Label10.Visible = true;
                     Label11.Visible = true;
                     lblthird.Visible = true;
                     lblmsg.Text = "Please Paid  Total Due of  " + txtbalence.Text + " Rs";
                     lblmsg.ForeColor = System.Drawing.Color.Red;
                     lblmsg.Visible = true;
                }                
            }
            else if(txtinstalments.Text=="3")
            {              
                if(txtthird.Text != "" && txtthird.Text!="0")
                {
                    int Remaining = ((Convert.ToInt32(txtfees.Text)) - (Convert.ToInt32(txtfirst.Text) + Convert.ToInt32(txtsecond.Text) + Convert.ToInt32(txtthird.Text)));
                    txtthird.ReadOnly = false;
                    txtsecond.ReadOnly = true;
                    if (Convert.ToInt32(txtbalence.Text) == Convert.ToInt32(txtthird.Text))
                    {
                        SqlCommand cmd = new SqlCommand("update StudentRegister1 set ThirdInstallment='" + txtthird.Text + "',Balence='" + Remaining.ToString() + "' where Id='" + txtid.Text + "'", con);
                        int i = cmd.ExecuteNonQuery();
                        MailMessage mm = new MailMessage(UserName, txtemail.Text);
                        mm.Subject = "Student Registation Details....!";
                        mm.Body = "Hi,<br/> Mr/Ms   : " + txtname.Text + "<br />Your Group Name :  " + txtgroup.Text + "<br />The Group of :  " + txtcourseyear.Text + "3rd Installment Due is" + txtsecond.Text + "<br/>  Remaining Due :" + Remaining.ToString() + "<br/>Your Fees amount was Cleared<br/> Thank You";
                        mm.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        NetworkCredential nc = new NetworkCredential(UserName,PassWord);
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = nc;
                        smtp.Send(mm);
                        if (i > 0)
                        {
                            txtname.Visible = true;
                            txtemail.Visible = true;
                            txtjoin.Visible = true;
                            txtgroup.Visible = true;
                            txtfees.Visible = true;
                            txtinstalments.Visible = true;
                            txtfirst.Visible = true;
                            txtbalence.Visible = true;
                            txtsecond.Visible = true;
                            txtthird.Visible = true;
                            txtcourseyear.Visible = true;
                          
                            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + txtid.Text + "','" + txtname.Text + "','" + txtemail.Text + "','" + txtjoin.Text + "','" + txtgroup.Text + "','" + txtcourseyear.Text + "','" + txtfees.Text + "','" + txtinstalments.Text + "','" + txtfirst.Text + "','" + Remaining.ToString() + "','" + txtsecond.Text + "','" + txtthird.Text + "');", true);
                        }
                        else
                        {
                            Response.Write("<script>alert('FAILED .......!')</script>");
                        }
                    }
                    else
                    {
                        txtname.Visible = true;
                        txtemail.Visible = true;
                        txtjoin.Visible = true;
                        txtgroup.Visible = true;
                        txtfees.Visible = true;
                        txtinstalments.Visible = true;
                        txtfirst.Visible = true;
                        txtbalence.Visible = true;
                        txtsecond.Visible = true;
                        txtthird.Visible = true;
                        txtcourseyear.Visible = true;
                        btnpayinstallments.Visible = true;

                        Label2.Visible = true;
                        Label3.Visible = true;
                        Label4.Visible = true;
                        Label5.Visible = true;
                        Label6.Visible = true;
                        Label7.Visible = true;
                        Label8.Visible = true;
                        Label9.Visible = true;
                        Label10.Visible = true;
                        Label11.Visible = true;
                        lblmsg.Text = ("Please Paid  Total Due of  " + txtbalence.Text + "");
                        lblmsg.ForeColor = System.Drawing.Color.Red;
                        lblmsg.Visible = true;
                    }
                }
                else
                {
                    int Remaining2 = ((Convert.ToInt32(txtfees.Text)) - (Convert.ToInt32(txtfirst.Text) + Convert.ToInt32(txtsecond.Text)));
                    SqlCommand cmd = new SqlCommand("update StudentRegister1 set SecondInstallment='" + txtsecond.Text + "',ThirdInstallment='" + txtthird.Text + "',Balence='" + Remaining2.ToString() + "' where Id='" + txtid.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    MailMessage mm = new MailMessage(UserName, txtemail.Text);
                    mm.Subject = "Student Registation Details....!";
                    mm.Body = "Student Name : " + txtname.Text + "<br />Your Group Name :  " + txtgroup.Text + "<br />The Group of :" + txtcourseyear.Text + "<br/>Your Group Fees is   :   " + txtfees.Text + "<br />You have Paid 2nd Installment :   " + txtsecond.Text + "<br/>The Remaining Due is :   " + Remaining2.ToString() + "<br/>Thank You" +
                        "<h3 style='color:red'>Note : The certificate will not Issued Untill the balence Amount is clear</h3>";
                    mm.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    NetworkCredential nc = new NetworkCredential(UserName,PassWord);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = nc;
                    smtp.Send(mm);
                    if (i > 0)
                    {
                        txtname.Visible = true;
                        txtemail.Visible = true;
                        txtjoin.Visible = true;
                        txtgroup.Visible = true;
                        txtfees.Visible = true;
                        txtinstalments.Visible = true;
                        txtfirst.Visible = true;
                        txtbalence.Visible = true;
                        txtsecond.Visible = true;
                        txtthird.Visible = true;
                        txtcourseyear.Visible = true;

                        ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + txtid.Text + "','" + txtname.Text + "','" + txtemail.Text + "','" + txtjoin.Text + "','" + txtgroup.Text + "','" + txtcourseyear.Text + "','" + txtfees.Text + "','" + txtinstalments.Text + "','" + txtfirst.Text + "','" + Remaining2.ToString() + "','" + txtsecond.Text + "','" + txtthird.Text + "');", true);
                    }
                    else
                    {
                        Response.Write("<script>alert('FAILED .......!')</script>");
                    }
                }
            }
            else
            {
               
            }
        }

        protected void btnprint_Click(object sender, EventArgs e)
        {

        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }       
    }
}