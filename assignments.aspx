<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignments.aspx.cs" Inherits="GUCera.assignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:Label ID="Label1" runat="server" Text="Enter Course ID :"></asp:Label>


            <asp:TextBox ID="cid" runat="server"></asp:TextBox>


            <asp:Button ID="viewAssign" runat="server" Text="View Assignment" OnClick="viewAssign_Click" />
        </div>
        <p>
             <asp:Label ID="Label2" runat="server" Text="Enrolled Courses :"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
