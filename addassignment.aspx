<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addassignment.aspx.cs" Inherits="GUCera.addassignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 244px">
            CourseID<br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            Assignment#<br />
            <asp:TextBox ID="assignum" runat="server"></asp:TextBox>
            <br />
            Assignment Type<br />
            <asp:TextBox ID="assignt" runat="server"></asp:TextBox>
            <br />
            Full Grade<br />
            <asp:TextBox ID="fullg" runat="server"></asp:TextBox>
            <br />
            Weight<br />
            <asp:TextBox ID="assignw" runat="server"></asp:TextBox>
            <br />
            Deadline<br />
            <asp:TextBox ID="deadl" runat="server"></asp:TextBox>
            <br />
            Content<br />
            <asp:TextBox ID="assigncontent" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="defineassign" runat="server" Text="Define Assignment" OnClick="Add_assign"/>
            <p>
            <asp:Label ID="Label" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
