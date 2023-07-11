<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddTeacher.aspx.cs" Inherits="Fees_Management.View.Admin.AddTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <style type="text/css">

        .all-space{
            display:flex;
            justify-content:space-around;
            align-items:center;
        }

        .submit-btn{
            width:250px;
            height:35px;
            border:none;
            outline:none;
            border-radius:6px;
            margin:20px;
            background:#bf6d67;
            color:#fff;
        }
        .cls{
            border:1px solid black;
            display:flex;
            flex-direction:row;
            justify-content:flex-start;
            align-items:center;
            border-radius:5px;
        }
        .cls2{
            padding-right:60px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row p-5 all-space">
        <div class="col-md-5">
            <asp:Label Text="UserEmail" ID="TName" runat="server" autoComplete="off" />
            <asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-5">
            <asp:Label Text="UserPassword" ID="TEmail" runat="server" autoComplete="off" />
            <asp:TextBox ID="txtpass" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-5">
            <asp:Label Text="UserRole" ID="TPhone" runat="server" autoComplete="off" /><br />
            <div class="cls">
                 <asp:RadioButton ID="rdbadmin" runat="server" Text="Admin" GroupName="Role" CssClass="cls2" />
                  <asp:RadioButton ID="rdbteacher" runat="server" Text="Teacher" GroupName="Role"  />
            </div>
        </div>       
        <div class="col-12 m-3 text-center">
            <asp:Button ID="btnaddadminteacher" runat="server" Text="Add Person" CssClass="submit-btn" OnClick="btnaddadminteacher_Click" />
        </div>
    </div>
</asp:Content>
