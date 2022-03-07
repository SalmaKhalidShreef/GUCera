<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gradeassignment.aspx.cs" Inherits="GUCera.gradeassignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="stid" runat="server" Text="StudentID"></asp:Label>
            <br />
            <asp:TextBox ID="studentID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="coid" runat="server" Text="CourseID"></asp:Label>
            <br />
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="assignum" runat="server" Text="Assignment Number"></asp:Label>
            <br />
            <asp:TextBox ID="assignn" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Asst" runat="server" Text="Assignment Type"></asp:Label>
            <br />
            <asp:TextBox ID="asstype" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="gr" runat="server" Text="Grade"></asp:Label>
            <br />
            <asp:TextBox ID="assgrade" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="gradeass" runat="server" Text="Grade Assignment" OnClick="grade_ass" />
        </div>
    </form>
</body>
</html>
