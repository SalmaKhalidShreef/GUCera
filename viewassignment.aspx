<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewassignment.aspx.cs" Inherits="GUCera.viewassignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter CourseID<br />
            <asp:TextBox ID="crsid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="viewsubmitted" runat="server" Text="View Assignments" OnClick="View_submitted"/>
        </div>
    </form>
</body>
</html>
