<%@ Page Title="" Language="C#" MasterPageFile="~/View/FeesMaster/FeesMaster.Master" AutoEventWireup="true" CodeBehind="Cashear.aspx.cs" EnableEventValidation = "false" Inherits="Fees_Management.View.FeesMaster.Cashear" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <style type="text/css">
        .main1{
            padding:20px;      
            display:flex;
            justify-content:space-between;
            align-items:flex-start;
            flex-direction:row;           
        }

        .btn21{
            height:35px;
            width:130px;
            border:none;
            color:white;
            background-color:#4b73b3;     
            border-radius:2px;
        }      
        .txtx{
            height:35px;
            width:250px;
            margin-right:40px;
            margin-left:65px;
            border-radius:5px;
        }
         .btn22{
            height:35px;
            width:130px;
            border:none;
            color:white;
            background-color:#206ce6;    
            border-radius:1px;
         } 
          .container {
            /* max-width: 800px;*/
            height: 80vh;
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
            .button {
            text-align: center;
            height: 35px;
        }

             .btn {
               
               margin-top:25px;
                height: 40px;
                width: 100%;
                outline: none;
                color: white;
                border: none;
                font-size: 18px;
                font-weight: 500;
                border-radius: 5px;
                letter-spacing: 1px;
                background:linear-gradient(135deg,#05073a,#dc0606ca);
                background: green;
             }
   </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="main1">
       <div>
           <asp:TextBox ID="textboxid" runat="server" CssClass="txtx" placeholder="Enter Id....."></asp:TextBox>

           <asp:Button ID="btnsearch" runat="server" Text="Search.." CssClass="btn21" OnClick="btnsearch_Click" />
       </div>

        <div>
            <asp:Button ID="btnregister" runat="server" Text="Student Register" CssClass="btn22" OnClick="btnregister_Click" />
        </div>
       </div>
       <div class="container">
           <div class="card-details">              
                    <div class="card-box">
                        <asp:Label ID="Label2" runat="server" Text="Name" ForeColor="Blue"></asp:Label>
                         <h6 class="grd"><asp:TextBox ID="txtname" runat="server" CssClass="txt hov"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label3" runat="server" Text="Email" ForeColor="Blue"></asp:Label>
                        <h6 class="grd"><asp:TextBox ID="txtemail" runat="server" CssClass="txt hov"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label7" runat="server" Text="Phone Number" ForeColor="Blue"></asp:Label>
                       <h6 class="grd"><asp:TextBox ID="txtphone" runat="server" CssClass="txt hov"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label4" runat="server" Text="Joining Date" ForeColor="Blue"></asp:Label>
                        <h6 class="grd"><asp:TextBox ID="txtjoin" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label5" runat="server" Text="Group Name" ForeColor="Blue"></asp:Label>
                        <h6 class="grd"><asp:TextBox ID="txtgroup" runat="server" CssClass="txt hov"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label11" runat="server" Text="Course Year" ForeColor="Blue"></asp:Label>
                        <h6 class="grd"><asp:TextBox ID="txtcourseyear" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label6" runat="server" Text="Fees" ForeColor="Blue"></asp:Label>
                        <h6 class="grd"><asp:TextBox ID="txtfees" runat="server" CssClass="txt hov" OnTextChanged="txtfees_TextChanged" AutoPostBack="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label8" runat="server" Text="Paid Amount" ForeColor="Blue"></asp:Label>
                        <h6 class="grd"><asp:TextBox ID="txtpaid" runat="server" CssClass="txt hov" AutoPostBack="true" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label9" runat="server" Text="Balance" ForeColor="Blue"></asp:Label>
                        <h6 class="grd"><asp:TextBox ID="txtbalence" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Button ID="btnupdate" runat="server" Text="Update" CssClass="txt btn" OnClick="btnupdate_Click" />
                    </div>
           </div>
       </div>

  

</asp:Content>

