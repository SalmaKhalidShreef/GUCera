<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="notyet.aspx.cs" Inherits="GUCera.notyet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Insert an id of a course you want to accept"></asp:Label>
        <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="accept course" OnClick="Button1_Click" />
        <div>
        </div>
    </form>
</body>
</html>
