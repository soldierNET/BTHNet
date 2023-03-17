<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quanLyTaiKhoan.aspx.cs" Inherits="BaiThucHanh6.quanLyTaiKhoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="QuanLyTaiKhoan.css" />
    <title>Quản lý tài khoản</title>
</head>
<body>
    <h1>Quản lý tài khoản</h1>
    <form id="form" runat="server">
        <label for="txtUsername">Tên đăng nhập</label>
        <input type="text" name="" id="txtUsername" runat="server"/>
        <label for="">Mật khẩu</label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <label for="txtLastName">Họ và tên đệm</label>
        <input type="text" name="" id="txtLastName" runat="server"/>
        <label for="txtFirstName">Tên</label>
        <input type="text" name="" id="txtFirstName" runat="server"/>
        <label for="txtEmail">Email</label>
        <input type="text" name="" id="txtEmail" runat="server"/>
        <label for="">Giới tính</label>
        <div class="input-group">
            <label for="radMale"><input type="radio" name="gender" id="radMale" runat="server"/>Nam</label>
            <label for="radFemale"><input type="radio" name="gender" id="radFemale" runat="server"/>Nữ</label>
        </div>
        <label for="txtAddress">Địa chỉ</label>
        <input type="text" name="" id="txtAddress" runat="server"/>
        <div class="input-group">
            <button type="submit" runat="server">Lưu</button>
            <button type="submit" runat="server">Xoá</button>
            <button type="reset" runat="server">Xoá trống form</button>
        </div>
    </form>
</body>
</html>