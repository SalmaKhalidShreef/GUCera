<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewmyfeedback.aspx.cs" Inherits="GUCera.viewmyfeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="cidd" runat="server" Text="Please Enter CourseID"></asp:Label>
            <br />
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="viewf" runat="server" Text="View My Feedback" OnClick="view_myfeed" />
        </div>
    </form>
</body>
</html>
