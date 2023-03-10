<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BaiThucHanh5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Xin chào <span id="txtGreetUsername" runat="server"></span></h1>
    <form id="form1" runat="server">
    <button id="btnLogout" runat="server" onserverclick="btnLogout_ServerClick">Đăng xuất</button>
    </form>
</body>
</html>
