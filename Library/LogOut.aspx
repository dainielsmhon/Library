<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOut.aspx.cs" Inherits="Library.LogOut" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>התנתקות</title>
    <meta http-equiv="refresh" content="3;url=Default1.aspx" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="lblMessage" runat="server" Text="מתבצע התנתקות..."></asp:Literal>
        </div>
    </form>
</body>
</html>