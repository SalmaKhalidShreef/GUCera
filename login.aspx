<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GUCera.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        body {
             background-color: #d1f3e7;
         }

        h1,h3 {
            text-align: center;

        }
        .form {
            background: #fff;
            box-shadow: 0 30px 60px 0 rgba(90, 116, 148, 0.4);
            border-radius: 5px;
            max-width: 480px;
            margin-left: auto;
            margin-right: auto;
            padding-top: 5px;
            padding-bottom: 5px;
            left: 0;
            right: 0;
            position: absolute;
            border-top: 5px solid #0e3721;
           /*   z-index: 1; */
           
         }
        .pageTitle{
         font-size: 2em;
         font-weight: bold;
          font-family: sans-serif;
         }
         .box {
           background-color: #ebebeb;
           color: white;
         }
         .box:hover {
         border-bottom: 5px solid #0e3721;
         height: 30px;
         width: 380px;
         transition: ease 0.5s;
          }
         .formEntry {
          display: block;
          margin: 30px auto;
          min-width: 300px;
          padding: 10px;
          border-radius: 2px;
          border: none;
          transition: all 0.5s ease 0s;
          }
         .submit {
           width: 200px;
           color: white;
           background-color: #0e3721;
          font-size: 20px;
          }

         .submit:hover {
         box-shadow: 15px 15px 15px 5px rgba(78, 72, 77, 0.219);
         transform: translateY(-3px);
          width: 300px;
          border-top: 5px solid #0e3750;
          border-radius: 0%;
         }
       
       .buttonHolder{
           text-align:center;}
       .title{
          display: block;
          font-family: sans-serif;
         
          width: 300px;
       }
       h5{
           margin-left:80px;

       }

        
    </style>
    <form id="form1"  class="form" runat="server">
        <h1 class="pageTitle">Welcome to GUCera!</h1>
        <h1 class="pageTitle">
       Login</h1>
        <h5 class="title">Please enter your ID :</h5>
            
         <p>
            <asp:TextBox ID="username" class="box formEntry" runat="server" Width="188px"></asp:TextBox>
        </p>
        <h5 class="title"> Please enter your password: </h5>
           
        <p>
            <asp:TextBox ID="password" class="box formEntry" runat="server" Width="188px"></asp:TextBox>
        </p>
        <div class="buttonHolder" >
            <asp:Button ID="signin1" class="submit" OnClick="Signin1" runat="server" Text="login" /><br />
             <asp:Button ID="reg1" class="submit" OnClick="register" runat="server" Text="register" /><br />
             <asp:Label ID="Label" runat="server" Text=""></asp:Label>
        </div>
        
    </form>
</body>
</html>
