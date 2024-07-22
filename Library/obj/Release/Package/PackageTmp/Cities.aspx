<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cities.aspx.cs" Inherits="Library.Cities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptCity" runat="server">
                <ItemTemplate>
                    <%#Eval("שם_ישוב") %>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
