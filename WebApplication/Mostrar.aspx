<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mostrar.aspx.cs" Inherits="WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelID" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            <asp:Label ID="LabelActividad" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;
        </p>
        <asp:ListBox ID="ListBox1" runat="server" Height="233px" Width="217px"></asp:ListBox>
    </form>
</body>
</html>
