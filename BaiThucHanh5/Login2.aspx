<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="BaiThucHanh5.Login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="Login.css" />
</head>
<body>
    <form class="flex container" id="loginForm" runat="server">
        <div class="input-group">
            <label for="txtUsername">Tên người dùng</label>
            <input type="text" id="txtUsername" runat="server"/>
            <asp:RequiredFieldValidator ID="vUsername" runat="server" ErrorMessage="Nhập tên đăng nhập" ControlToValidate="txtUsername" CssClass="invalid"></asp:RequiredFieldValidator>
        </div>
        <div class="input-group">
            <label for="txtPassword">Mật khẩu</label>
            <asp:TextBox type="password" id="txtPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="vPassword" runat="server" ErrorMessage="Nhập mật khẩu" ControlToValidate="txtPassword" CssClass="invalid"></asp:RequiredFieldValidator>
        </div>
        <div>
            <input type="checkbox" id="chkSave" runat="server" />
            <label for="chkSave">Nhớ tài khoản</label>
        </div>
        <div id="info" runat="server"></div>
        <input id="btnSubmit" class="btn" type="submit" value="Đăng nhập" runat="server" onserverclick="btnSubmit_ServerClick"/>
    </form>
</body>
</html>
