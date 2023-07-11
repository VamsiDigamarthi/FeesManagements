<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="StudentsLists.aspx.cs" Inherits="Fees_Management.View.Admin.StudentsLists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
         .main1{
            padding:20px;      
            display:flex;
            justify-content:space-between;
            align-items:center;
        }
        .btn1{
            height:35px;
            width:150px;
            border:none;
            color:white;
            background:#0c606e;
             border-radius:5px;
        }
        .grd{
            margin:50px;
            overflow:auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="main1">
              <asp:Button ID="btngroup" runat="server" Text="Add Group" CssClass="btn1" OnClick="btngroup_Click" />
              <asp:Button ID="btnteacher" runat="server" Text="Add Admin/Teacher" CssClass="btn1" OnClick="btnteacher_Click" />
        </div>

    <div style="overflow:auto">
    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="grd">
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        </div>
</asp:Content>
