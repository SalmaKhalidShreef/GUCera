<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="GUCera.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="fn" runat="server" Text="First Name:"></asp:Label>
        <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="ln" runat="server" Text="Last Name:"></asp:Label>
            <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="pass" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="g" runat="server" Text="Gender:"></asp:Label>
            <asp:RadioButtonList ID="gender" runat="server">
             <asp:ListItem Text="female"/>
            <asp:ListItem Text="male"/>
            </asp:RadioButtonList>
        </p>
        <p>
            <asp:Label ID="em" runat="server" Text="E-mail:"></asp:Label>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="add" runat="server" Text="Address:"></asp:Label>
            <asp:TextBox ID="address" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="student" runat="server" Text="Register as Student" OnClick="student_Click" />
            <asp:Button ID="instructor" runat="server" Text="Register as Instructor" OnClick="instructor_Click" />
        </p>
         
        <p>
            <asp:Button ID="Button1" runat="server" Text="go to login" OnClick="Button1_Click" />
        </p>
         
    </form>
</body>
</html>
