<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="InstallmentsList.aspx.cs" Inherits="Fees_Management.View.Admin.InstallmentsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .instal-list{
            
            height:15%;
            width:100%;
            display:flex;
            margin-top:10px;
            justify-content:space-around;
            align-items:center;
        }
        .inst-btn{
            width:165px;
            height:35px;
            color:#fff;
            background:#0c606e;
            border:none;
            border-radius:5px;
            outline:none;
        }
        .middel-grid{
            overflow-x:scroll;
            overflow-y:scroll;
            height:75%;
          padding:40px;
        }
        .excel-btn-div{
            height:10%;
            display:flex;
            justify-content:center;
            align-items:center;
        }
         .excel-btn-div .insta-btn1{
             margin-right:20px;
         }
    </style>
    <script type="text/javascript">
        function PrintPanel() {
            var PGrid = document.getElementById('<%=GridView1.ClientID %>');

            PGrid.border = 0;

            var Pwin = window.open('', 'PrintGrid', 'left=100,top=100,width=1024,height=768,tollbar=0,scrollbars=1,status=0,resizable=1');

            Pwin.document.write(PGrid.outerHTML);

            Pwin.document.close();

            Pwin.focus();

            Pwin.print();

            Pwin.close();
         }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="instal-list">
         <asp:Button ID="insta1btn" runat="server" Text="1st Installment" CssClass="inst-btn" OnClick="insta1btn_Click" />
         <asp:Button ID="insta2btn" runat="server" Text="2nd Installment"  CssClass="inst-btn" OnClick="insta2btn_Click" />
         <asp:Button ID="insta3btn" runat="server" Text="3rd Installment"  CssClass="inst-btn" OnClick="insta3btn_Click" />
        <asp:Button ID="compleateinstallbtn" runat="server" Text="Complete Installment" CssClass="inst-btn" OnClick="compleateinstallbtn_Click" />
    </div>
    <div class="middel-grid">      
        <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
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
    <div class="excel-btn-div">
         <asp:Button ID="excelpdf" runat="server" Text="Excel"  CssClass="inst-btn insta-btn1" OnClick="excelpdf_Click"  />
         <asp:Button ID="printbtn" runat="server" Text="Print"  CssClass="inst-btn" OnClick="printbtn_Click" OnClientClick="return PrintPanel()" />
    </div>
</asp:Content>
