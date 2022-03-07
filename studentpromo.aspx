<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentpromo.aspx.cs" Inherits="GUCera.studentpromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Text="Student ID:"></asp:Label>
        <asp:TextBox ID="sid" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Promocode ID:"></asp:Label>
            <asp:TextBox ID="pid" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="issue promocode" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
