<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorhome.aspx.cs" Inherits="GUCera.instructorhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="mobile" runat="server" Text="add my mobile number" OnClick="mobile_Click" />
            <br />
        <asp:Button ID="addc" runat="server" Text="add course" OnClick="course_Click" />
            <br />
            <asp:Button ID="defineass" runat="server" Text="define assignment" OnClick="assign_Click" />
            <br />
            <asp:Button ID="viewass" runat="server" Text="View submitted Assignments" OnClick="assign_View"/>
            <br />
            <asp:Button ID="gradeass" runat="server" Text="Grade submitted Assignments" OnClick="assign_Grade" />
            <br />
            <asp:Button ID="viewf" runat="server" Text="View My Feedback" OnClick="view_feed" />
            <br />
            <asp:Button ID="issuec" runat="server" Text="Issue Certificate" OnClick="issue_cer" />
            <br />
        </div>
    </form>
</body>
</html>
