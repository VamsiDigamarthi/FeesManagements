<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Fees_Management.View.Admin.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .content{
            position:relative;
           /* margin-top:10vh;*/
            min-height:90vh;
        }
        .cards{
            padding:20px 15px;
            display:flex;
            flex-direction :row;
            align-items:center;
            justify-content:space-between;
            
        }
            .card{
              width: 350px;
            height: 150px;
           /* background: #3acccf;*/
            margin: 25px 10px;
            display: flex;
            flex-direction: row;
            justify-content: space-around;
            align-items: center;
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2) 0,6px,20px,0 rgba(0,0,0,0.19);
            border-radius:7px;
          }
             .main1{
            padding:20px;      
            display:flex;
            justify-content:space-between;
            align-items:center;
        }
        .btn1{
            height:35px;
            width:130px;
            border:none;
            color:white;
            background:#0c606e;
            border-radius:5px;
        }

        .sorting-div{
            width:50%;
            display:flex;
            justify-content:space-between;
            align-items:center;
           /* border:1px solid red;*/
            margin:0px 20px;
        }
        .sort-by-year{
            width:190px;
        }
        .grdd12{
            margin-left:40px;
            margin-top:40px;
        }
        .sea-btn{
             background:#279c65;
            border-radius:5px;
            color:white;
            width:120px;
            height:35px;
        }
        .dimg{
            height:65px;
            width:65px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="cards">
            <div class="card">
                <div class="box">
                  <b style="color:#647782;"> Total :</b>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="20pt"></asp:Label>
                    <h3  style="font-family: cursive;">Groups</h3>
                </div>
                <div class="icon-case">
                   <%-- <img src="../../Assets/Images/students.png" />--%>
                    <img src="../../Assets/Images/books.png" class="dimg" />
                </div>
            </div>
             <div class="card">
                <div class="box">
                     <b style="color:#647782;"> Total :</b>
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="20pt"></asp:Label>
                    <h3  style="font-family: cursive;">Students</h3>
                </div>
                <div class="icon-case">
                    <%--<img src="../../Assets/Images/students.png" />--%>
                    <img src="../../Assets/Images/stdent.png" class="dimg" />
                </div>
            </div>
             <div class="card">
                <div class="box">
                     <b style="color:#647782;"> Total :</b>
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="20pt"></asp:Label>
                    <h3 style="font-family: cursive;">Teachers</h3>
                </div>
                <div class="icon-case">
                   <%-- <img src="../../Assets/Images/students.png" />--%>
                    <img src="../../Assets/Images/teacher.png" class="dimg" />
                </div>
            </div>
        </div>


        <div class="main1">
         <%--    <asp:Button ID="btngroup" runat="server" Text="Add Group" CssClass="btn1" OnClick="btngroup_Click" />
             <asp:Button ID="btnteacher" runat="server" Text="Add Teacher" CssClass="btn1" OnClick="btnteacher_Click" />--%>
        </div>


        <div class="sorting-div">
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="sort-by-year btn1">
                    <asp:ListItem>-- Select Year --</asp:ListItem>
                    <asp:ListItem>1st Year</asp:ListItem>
                    <asp:ListItem>2nd Year</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="sort-by-year btn1" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                
            </asp:DropDownList>
            <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" CssClass="sea-btn" />
           
        </div>
         <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="grdd12">
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
