<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studenthome.aspx.cs" Inherits="GUCera.studenthome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="mobile" runat="server" Text="add my mobile number" OnClick="mobile_Click" />
        
        <p>
        <asp:Button ID="viewAssign" runat="server" OnClick="viewAssign_click" Text="View Assignments" Width="235px" />
        </p>
        <p>
            <asp:Button ID="submitAssign" runat="server" Text="Sumbit assignment " OnClick="submitAssign_Click" />
        </p>
        <p>
            <asp:Button ID="viewGrades" runat="server" Text="View grades" OnClick="viewGrades_Click" />
        </p>
        <p>
            <asp:Button ID="feedback" runat="server" Text="Add Feedback" Width="276px" OnClick="feedback_Click" />
        </p>
        <p>
            <asp:Button ID="certificates" runat="server" Text="View my certificates" OnClick="certificates_Click" />
        </p>
         <p>
        <asp:Button ID="Button1" runat="server" OnClick="viewProfile" Text=" View profile" />
        </p>
        <p>
        <asp:Button ID="Button2" runat="server"  OnClick="viewCourses" Text="View Available Courses" />
        </p>
        <asp:Button ID="Button3" runat="server" OnClick="addCard" Text="Add credit card" />
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="viewPromocodes" Text="View Promocodes" />
        </p>
    </form>
</body>
</html>
