<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="certificates.aspx.cs" Inherits="GUCera.certificates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter course id  :"></asp:Label>
            <asp:TextBox ID="course" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="view" OnClick="Button1_Click" style="width: 47px" />
        <p>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
