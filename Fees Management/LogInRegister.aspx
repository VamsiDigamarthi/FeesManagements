<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogInRegister.aspx.cs" Inherits="Fees_Management.LogInRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:TextBox ID="txtemail" runat="server" Height="31px" Width="324px"></asp:TextBox><br />
             <asp:TextBox ID="txtpassword" runat="server" Height="26px" Width="320px"></asp:TextBox><br />
             <asp:RadioButton ID="txtrole" runat="server" Text="Admin" /><br />
            <asp:Button ID="btnregister" runat="server" Text="Register" OnClick="btnregister_Click" />
        </div>
    </form>
</body>
</html>
