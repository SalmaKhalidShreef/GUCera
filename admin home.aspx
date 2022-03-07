<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin home.aspx.cs" Inherits="GUCera.admin_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="mobile" runat="server" Text="add my mobile number" OnClick="mobile_Click" />
        </div>
        <p>
            <asp:Button ID="allcourse" runat="server" Text="show all courses" OnClick="allcourse_Click" />
        </p>
        <p>
            <asp:Button ID="notyet" runat="server" Text="show not yet accepted courses and accept" OnClick="notyet_Click" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="create promocode" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="issue promocode to student" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>
