<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log In.aspx.cs" Inherits="Fees_Management.Log_In" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body{
            padding:0px;
            margin:0px;
        }

       ::-webkit-scrollbar {
         display: none;
        }
        .main{
           height:100vh;
           width:100%;
           position:relative;
           overflow:hidden;
        }
        .main img{
            width:100%;
            height:100vh;
        }
        h1{
            position:absolute;
            top:150px;
            left:53%;
            color:#fff;
           /* background-image: linear-gradient(180deg, red, yellow);*/

        }
        .login-container{
            height:250px;
            width:300px;
            background-color:rgba(255, 255, 255, 0.3);
            border-radius:7px;
            display:flex;
            flex-direction:column;
            justify-content:space-around;
            align-items:center;
            position:absolute;
            top:250px;
            left:50%;
            padding:35px;
          
        }
        .login-input{
            width:100%;
            height:45px;
            background-color:rgba(0 ,0 ,0 ,0.3);
            border:none;
            outline:none;
            border-radius:2px;
            padding:0px 10px;
            color:#fff;
            font-size:17px;
        }
        .login-btn{
            width:107%;
            height:40px;
            border:none;
            outline:none;
            color:#fff;
            background-color:#010000;
            font-size:18px;
            font-weight:600;
            border-radius:3px;
            cursor:pointer;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="main">
           <img src="Assets/Images/student-01.jpg" />
            <h1>Student Login Form</h1>
            <div class="login-container">
                <asp:TextBox ID="txtemail" runat="server" CssClass="login-input" placeholder="Email"></asp:TextBox>
                <asp:TextBox ID="txtpass" runat="server"  CssClass="login-input"  placeholder="Password"></asp:TextBox>
                <asp:Button ID="btnlogin" runat="server" Text="Log In" CssClass="login-btn" OnClick="btnlogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
