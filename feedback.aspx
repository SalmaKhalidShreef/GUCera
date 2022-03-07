<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="feedback.aspx.cs" Inherits="GUCera.feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Choose Course you want to add feedback to : "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Write your comment here : "></asp:Label>
            <asp:TextBox ID="comment" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="add" runat="server" Text="Add" OnClick="add_Click" />
        </p>
    </form>
</body>
</html>
