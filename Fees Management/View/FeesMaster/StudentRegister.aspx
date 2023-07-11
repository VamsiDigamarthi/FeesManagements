<%@ Page Title="" Language="C#" MasterPageFile="~/View/FeesMaster/FeesMaster.Master" AutoEventWireup="true" CodeBehind="StudentRegister.aspx.cs" Inherits="Fees_Management.View.FeesMaster.StudentRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style type="text/css">
        /* *{
            margin:0;
            padding:0;
            box-sizing:border-box;
            font-family:'Segoe UI',Tahoma,Verdana, Geneva, Tahoma, sans-serif,
        }
        body{
            color:#fff;
            display:flex;
            height:100vh;
            justify-content:center;
            align-items:center;
            background:linear-gradient(135deg,#05073a,#dc0606ca);
            padding:10px;
        }*/
        .container {
           /* max-width: 800px;*/
           height:80vh;
            width: 100%;
            padding: 25px 30px;
           /* border-radius: 25px;*/
            /* background:linear-gradient(135deg,#dc0606ca,#05073a);*/
           /* background: linear-gradient(#d09a8d,#fdbb2d);*/
        }

            .container .header {
                font-size: 25px;
                font-weight: 500;
                position: relative;
                text-align: center;
                padding: 0 0 20px 0;
            }

                .container .header::before {
                    content: '';
                    position: absolute;
                    height: 3px;
                    left: 0;
                    bottom: 0;
                    width: 100%;
                    background: linear-gradient(135deg,#71b7e6,#9b5b);
                }

            .container .card-details {
                margin-top: 25px;
                display: flex;
                flex-wrap: wrap;
                justify-content: space-between;
            }

        .card-details .card-box {
            width: 300px;
            margin-bottom: 15px;
        
        }

        .card-details .card-box .details {
            display: block;
            font-weight: 500;
            margin-bottom: 5px;
        }

        .card-details .card-box .txt {
            height: 40px;
            width: 100%;
            outline: none;
            border-radius: 5px;
            border: 1px solid #ccc;
            padding-left: 15px;
            font-size: 16px;
            border-bottom-width: 2px;
            transition: all 0.3s ease;
        }

            .card-details .card-box txt:focus, .card-details .card-box txt:valid {
                border-color: #9b59b6;
            }

        .circle-form .circle-title {
            font-size: 20px;
            font-weight: 500;
            border-bottom: 2px solid;
        }

        .circle-form .catagiry {
            margin-top: 10px;
            margin-bottom: 10px;
        }

         .button {
            text-align: center;
            height:35px;
        }

             .button .btn {
                padding: 10px 0;
                margin-top: 10px;
                
                width: 50%;
                outline: none;
                color: white;
                border: none;
                font-size: 18px;
                font-weight: 500;
                border-radius: 5px;
                letter-spacing: 1px;             
                background: green;
             }

                .button .btn:hover {
                     background:linear-gradient(135deg,#05073a,#dc0606ca);
                }

        @media(max-width:584px) {
            .container {
                max-width: 100%;
            }

            form .card-details .card-box {
                margin-bottom: 15px;
                width: 100%;
            }

            form .circle-form .catagiry {
                width: 100%;
            }

            .container form .card-details {
                max-height: 300px;
                overflow: scroll;
            }
            /*.card-details::_webkit-scrollbar{
                     width:0;
                 }*/
        }
        .rdbb{
            margin-right:50px;           
        }
        .dd1{
            width:300px;
            height:40px;
            border-radius:5px;
            outline:none;
          
        }
        h2{
            border-bottom:2px solid pink;
            width:fit-content;
            color:#bd374f;
        }
        .bb-div{
            border:1px solid black;
            height:40px;
            border-radius:5px;
            padding:0 20px;
        }
        .grd1{
              background:linear-gradient(rgb(188, 12, 241), rgb(212, 4, 4));          
        }
    </style>
       <script type="text/javascript" language="javascript">
              function numeric(evt)
              {
              var charCode = (evt.which) ? evt.which : event.keyCode
              if(charCode > 31 && ((charCode >= 48 && charCode <= 57) || charCode == 46))
                return true;
                 else
                {
                 alert('Please Enter Numeric values.');
                 return false;
                }
              }
       </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <section id="main-content">
        <section class="wrapper site-min-height">
            <div class="container">         
                <h2>Student Registration & Fees Details</h2>
                <div class="card-details">                     
                    <div class="card-box">                   
                         <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
                       <h6 class="grd1"> <asp:TextBox ID="txtname" runat="server" CssClass="txt"></asp:TextBox> </h6>       
                    </div>
                     <div class="card-box">
                          <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
                      <h6 class="grd1">  <asp:TextBox ID="txtemail" runat="server" CssClass="txt"></asp:TextBox>   </h6>          
                    </div>
                     <div class="card-box">
                          <asp:Label ID="lblphone" runat="server" Text="Phone"></asp:Label>
                       <h6 class="grd1"> <asp:TextBox ID="txtphone" runat="server" CssClass="txt" onkeypress="return numeric(event)"></asp:TextBox>  </h6>           
                    </div>
                    <div class="card-box">
                         <asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label>
                       <div class="bb-div">
                          <asp:RadioButton ID="rdbmale" runat="server" Text="Male"  GroupName="Gender" CssClass="rdbb" />    
                         <asp:RadioButton ID="rdbfemale" runat="server" Text="FeMale" GroupName="Gender"  /> 
                        </div>
                    </div>
                     <div class="card-box">
                          <asp:Label ID="lbljoin" runat="server" Text="Joining Date"></asp:Label>
                      <h6 class="grd1">  <asp:TextBox ID="txtjoin" runat="server" CssClass="txt"></asp:TextBox>   </h6>          
                    </div>
                     <div class="card-box">
                          <asp:Label ID="lblgroup" runat="server" Text="Group Name"></asp:Label>
                        <h6 class="grd1"> <asp:DropDownList ID="ddlgroup" runat="server" CssClass="txt" AutoPostBack="true" OnSelectedIndexChanged="ddlgroup_SelectedIndexChanged">

                         </asp:DropDownList></h6>
                   </div>
                     <div class="card-box">
                          <asp:Label ID="lblfees" runat="server" Text="Fees"></asp:Label>
                       <h6 class="grd1">  <asp:TextBox ID="txtfees" runat="server" CssClass="txt" ReadOnly="true"></asp:TextBox> </h6>
                        <asp:Label ID="lblwords" runat="server"></asp:Label>
                    </div>
                     <div class="card-box">
                          <asp:Label ID="lblminfeespay" runat="server" Text="Minimum Fees Pay"></asp:Label>
                      <h6 class="grd1">  <asp:TextBox ID="txtminfees" runat="server" CssClass="txt" ReadOnly="true"></asp:TextBox>   </h6>                     
                    </div>
                    <div class="card-box">
                         <asp:Label ID="lblcourseyear" runat="server" Text="Course Year"></asp:Label>
                       <h6 class="grd1"> <asp:DropDownList ID="ddlcourseyear" runat="server" CssClass="dd1">
                            <asp:ListItem>-- Select Year --</asp:ListItem>
                             <asp:ListItem>1st Year</asp:ListItem>
                             <asp:ListItem>2nd Year</asp:ListItem>
                        </asp:DropDownList></h6>
                    </div>     
                   
                    <div class="card-box">
                         <asp:Label ID="lblinstalments" runat="server" Text="Installments"></asp:Label>
                     <h6 class="grd1">   <asp:DropDownList ID="ddlinstallments" runat="server" CssClass="txt" AutoPostBack="true" OnSelectedIndexChanged="ddlinstallments_SelectedIndexChanged">   
                            <asp:ListItem>-- Select Installments --</asp:ListItem>
                             <asp:ListItem Text="1" Value="1"></asp:ListItem>
                             <asp:ListItem Text="2" Value="2"></asp:ListItem>
                             <asp:ListItem Text="3" Value="3"></asp:ListItem>
                        </asp:DropDownList>  </h6>                      
                   </div> 
                     <div class="card-box">
                          <asp:Label ID="lblpaymentmode" runat="server" Text="Payment Mode"></asp:Label>
                      <h6 class="grd1">  <asp:DropDownList ID="ddlpaymentmode" runat="server" CssClass="txt">
                            <asp:ListItem>-- Select PaymentMode--</asp:ListItem>
                             <asp:ListItem> Online </asp:ListItem>
                             <asp:ListItem> Cash </asp:ListItem>
                        </asp:DropDownList></h6>
                    </div> 
                    <div class="card-box">
                         <asp:Label ID="lblpaidamount" runat="server" Text="Paid Amount"></asp:Label>
                  <h6 class="grd1"> <asp:TextBox ID="txtpaid" runat="server" CssClass="txt" AutoPostBack="true" OnTextChanged="txtpaid_TextChanged" onkeypress="return numeric(event)"></asp:TextBox></h6>
                    </div>
                     <div class="card-box">
                          <asp:Label ID="lblbalence" runat="server" Text="Balance"></asp:Label>
                     <h6 class="grd1">   <asp:TextBox ID="txtbalence" runat="server" CssClass="txt" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                     <div class="card-box">
                         <asp:Label ID="lblsecondinstal" runat="server" Text="Second Istallment"></asp:Label>
                     <h6 class="grd1">   <asp:TextBox ID="txtsecinstall" runat="server" CssClass="txt" ReadOnly="true"></asp:TextBox></h6>
                    </div>  
                     <div class="card-box">
                         <asp:Label ID="lblSecond_IstallmentDate" runat="server" Text="Second Installment Date"></asp:Label>
                      <h6 class="grd1">  <asp:TextBox ID="txtsecdate" runat="server" CssClass="txt" ReadOnly="true"></asp:TextBox></h6>
                    </div> 
                     <div class="card-box">
                          <asp:Label ID="lblThird_Istallment" runat="server" Text="Third Installment"></asp:Label>
                      <h6 class="grd1">  <asp:TextBox ID="txtthird" runat="server" CssClass="txt" ReadOnly="true"></asp:TextBox></h6>
                    </div> 
                     <div class="card-box">
                          <asp:Label ID="lblThird_IstallmentDate" runat="server" Text="Third Installment Date"></asp:Label>
                      <h6 class="grd1">  <asp:TextBox ID="txtthirddate" runat="server" CssClass="txt" ReadOnly="true"></asp:TextBox></h6>
                    </div> 
                                                                       
                </div>
                 <div class="button">
                        <asp:Button ID="BtnRegister" runat="server" Text="Register" CssClass="btn" ForeColor="#003366" OnClick="BtnRegister_Click"/>
                    </div>
            </div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </section>
    </section>
</asp:Content>
