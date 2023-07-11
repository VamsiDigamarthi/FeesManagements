<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddGroups.aspx.cs" Inherits="Fees_Management.View.Admin.AddGroups" %>

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

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row p-5 all-space">
        <div class="col-md-5">
            <asp:Label Text="GroupName" ID="GroupName" runat="server" autoComplete="off" />
            <asp:TextBox ID="txtgroupname" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-5">
            <asp:Label Text="Amount" ID="Amount" runat="server" autoComplete="off" />
            <asp:TextBox ID="txtamount" runat="server" CssClass="form-control"></asp:TextBox>
        </div>   
        <div class="col-md-5">
            <asp:Label Text="Minimum Fees" ID="minifees" runat="server" autoComplete="off" />
            <asp:TextBox ID="txtminfees" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-12 m-3 text-center">
            <asp:Button ID="btnaddgroup" runat="server" Text="Add Group" CssClass="submit-btn" OnClick="btnaddgroup_Click" />
        </div>
    </div>
</asp:Content>
