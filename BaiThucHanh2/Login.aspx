<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BaiThucHanh2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="Login.css" />
</head>
<body>
    <form class="flex container" id="loginForm" runat="server">
        <div class="input-group">
            <label for="txtEmail">Email</label>
            <input type="email" id="txtEmail" runat="server"/>
        </div>
        <div class="input-group">
            <label for="txtPassword">Password</label>
            <input type="password" id="txtPassword" runat="server"/>
        </div>
        <input id="btnSubmit" class="btn" type="submit" value="Sign in now!" runat="server" onserverclick="btnSubmit_ServerClick"/>
        <div id="divInfo" runat="server"></div>
    </form>
</body>
</html>
