<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addcourse.aspx.cs" Inherits="GUCera.addcourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Credit Hours<br />
        <asp:TextBox ID="credithours" runat="server"></asp:TextBox>
        <br />
        Course Name<br />
        <asp:TextBox ID="cname" runat="server"></asp:TextBox>
        <br />
        Price<br />
        <asp:TextBox ID="price" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="addc" runat="server" Text="Add Course" OnClick="add_Course" />
        <br />
        <br />
        <br />
        <asp:Label ID="crsID" runat="server" Text="CourseID"></asp:Label>
        <br />
        <asp:TextBox ID="crssid" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Coursedes" runat="server" Text="Course Description"></asp:Label>
        <br />
        <asp:TextBox ID="crsdes" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="crsdesc" runat="server" Text="Update Course Description" OnClick="upd_desc" />
        <br />
        <br />
        <br />
        <asp:Label ID="crusID" runat="server" Text="CourseID"></asp:Label>
        <br />
        <asp:TextBox ID="couuID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="crscon" runat="server" Text="Course Content"></asp:Label>
        <br />
        <asp:TextBox ID="coucon" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="courcon" runat="server" OnClick="upd_con" Text="Update Course Content" />
        <p>
            <asp:Label ID="Label" runat="server" Text=""></asp:Label>
        </p>
    </form>
    
</body>
</html>
