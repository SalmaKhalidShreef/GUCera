<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignmentSubmission.aspx.cs" Inherits="GUCera.assignmentSubmission" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Course ID :"></asp:Label>
            <asp:TextBox ID="courseId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter assignment number : "></asp:Label>
            <asp:TextBox ID="no" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Choose sssignment type : "></asp:Label>
            <asp:RadioButtonList ID="type" runat="server" style="height: 80px">
                 <asp:ListItem Text="Quiz"/>
                 <asp:ListItem Text="Project"/>
                 <asp:ListItem Text="Exam"/>
            </asp:RadioButtonList>
            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
