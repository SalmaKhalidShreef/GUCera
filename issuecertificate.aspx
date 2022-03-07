<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="issuecertificate.aspx.cs" Inherits="GUCera.issuecertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="cid" runat="server" Text="CourseID"></asp:Label>
            <br />
            <asp:TextBox ID="couID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="sid" runat="server" Text="StudentID"></asp:Label>
            <br />
            <asp:TextBox ID="stuID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="issd" runat="server" Text="IssueDate"></asp:Label>
            <br />
            <asp:TextBox ID="issdate" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="issc" runat="server" Text="Issue Certificate" OnClick="issue_c"/>
        </div>
    </form>
</body>
</html>
