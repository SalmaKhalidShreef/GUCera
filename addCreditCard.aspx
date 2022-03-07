<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCreditCard.aspx.cs" Inherits="GUCera.addCreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <br />
        <br />
        Enter Card Number<br />
        <asp:TextBox ID="number" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Card Holder Name<br />
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <p>
            Enter Expiry Date</p>
        <asp:TextBox ID="date" runat="server"></asp:TextBox>
        <br />
        Enter CVV<br />
        <asp:TextBox ID="cvv" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" onClick="addCard" Text="add credit card" />
        </p>
        <asp:Label ID="Label" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
