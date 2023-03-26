<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChinhSuaTaiKhoan.aspx.cs" Inherits="BaiThucHanh9.ChinhSuaTaiKhoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="QuanLyTaiKhoan.css" />
    <title>Chỉnh sửa tài khoản</title>
</head>
<body>
    <form id="form" runat="server">
        <h1>Quản lý tài khoản</h1>
        <div class="form-container">
            <label for="txtUsername">Tên đăng nhập</label>
            <input type="text" id="txtUsername" runat="server" readonly="true" />
            <label for="txtPassword">Mật khẩu</label>
            <asp:TextBox type="password" ID="txtPassword" runat="server"></asp:TextBox>
            <label for="txtLastName">Họ và tên đệm</label>
            <input type="text" name="" id="txtLastName" runat="server" />
            <label for="txtFirstName">Tên</label>
            <input type="text" name="" id="txtFirstName" runat="server" />
            <label for="txtEmail">Email</label>
            <input type="text" name="" id="txtEmail" runat="server" />
            <label for="">Giới tính</label>
            <div class="input-group">
                <label for="radMale">
                    <input type="radio" name="gender" id="radMale" runat="server" value="male"/>Nam</label>
                <label for="radFemale">
                    <input type="radio" name="gender" id="radFemale" runat="server" value="female"/>Nữ</label>
            </div>
            <label for="txtAddress">Địa chỉ</label>
            <input type="text" name="" id="txtAddress" runat="server" />
            <div class="input-group">
                <button type="submit" runat="server" id="btnSave" onserverclick="btnSave_ServerClick">Lưu</button>
                <button type="submit" runat="server" id="btnExit" onserverclick="btnExit_ServerClick">Thoát</button>
            </div>
            <div class="input-group">
                <p id="txtMessage" runat="server"></p>
            </div>
        </div>
    </form>
</body>
</html>
