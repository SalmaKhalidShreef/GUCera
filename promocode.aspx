<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="promocode.aspx.cs" Inherits="GUCera.promocode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Code:"></asp:Label>
            <asp:TextBox ID="code" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="expirydate:"></asp:Label>
            <asp:TextBox ID="expirydate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="discount:"></asp:Label>
            <asp:TextBox ID="discount" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="create promocode" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
