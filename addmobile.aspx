<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addmobile.aspx.cs" Inherits="GUCera.addmobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="mobileno" runat="server"></asp:TextBox><asp:Button ID="add" runat="server" Text="add mobile number" OnClick="add_Click" />
        </div>
    </form>
</body>
</html>
