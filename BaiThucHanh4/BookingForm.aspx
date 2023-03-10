<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookingForm.aspx.cs" Inherits="BaiThucHanh4.BookingForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="GuestBook.css"/>
    <title>Đăng ký phòng</title>
</head>

<body>
    <div class="container">
        <h1>Đăng ký phòng</h1>
        <form id="form1" runat="server">
            <div class="input-group">
                <label for="txtHoTen">Họ tên</label>
                <input type="text" id="txtHoTen" runat="server"/>
                <asp:RequiredFieldValidator ID="vHoTen" runat="server" ErrorMessage="Nhập họ tên" ControlToValidate="txtHoTen"></asp:RequiredFieldValidator>
            </div>
            <div class="input-group">
                <label for="txtCoQuan">Cơ quan</label>
                <input type="text" id="txtCoQuan" runat="server"/>
                <asp:RequiredFieldValidator ID="vCoQuan" runat="server" ErrorMessage="Nhập cơ quan" ControlToValidate="txtCoQuan"></asp:RequiredFieldValidator>
            </div>
            <div class="input-group">
                <label for="txtEmail">Email</label>
                <input type="email" id="txtEmail" runat="server"/>
                <asp:RegularExpressionValidator ID="vEmail" runat="server" ErrorMessage="Nhập đúng định dạng email" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>
            <div class="input-group">
                <label for="txtMatKhau">Mật khẩu</label>
                <input type="password" id="txtMatKhau" runat="server"/>
                <asp:RequiredFieldValidator ID="vMatKhau" runat="server" ErrorMessage="Nhập mật khẩu" ControlToValidate="txtMatKhau"></asp:RequiredFieldValidator>
            </div>
            <div class="input-group">
                <label for="txtNLMatKhau">Nhập lại mật khẩu</label>
                <input type="password" id="txtNLMatKhau" runat="server"/>
                <asp:CompareValidator ID="vNLMatKhau" runat="server" ErrorMessage="Mật khẩu không khớp" ControlToCompare="txtMatKhau" ControlToValidate="txtNLMatKhau"></asp:CompareValidator>
            </div>
            <div class="input-group">
                <label for="txtCheckin">Ngày check-in</label>
                <input type="date" id="txtCheckin" runat="server"/>
                <asp:CompareValidator ID="vCheckin" runat="server" ErrorMessage="Nhập ngày check-in" Type="Date" Operator="DataTypeCheck" ControlToValidate="txtCheckin"></asp:CompareValidator>
            </div>
            <div class="input-group">
                <label for="txtSoNgay">Số ngày ở</label>
                <input type="number" id="txtSoNgay" runat="server"/>
                <asp:CompareValidator ID="vSoNgay" runat="server" ErrorMessage="Nhập số ngày" ControlToValidate="txtSoNgay" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
            </div>
            <div class="input-group">
                <label for="selectLoaiPhong">Loại phòng</label>
                <select id="selectLoaiPhong" runat="server">
                    <option value="Phòng đơn">Phòng đơn</option>
                    <option value="Phòng đôi">Phòng đôi</option>
                    <option value="Phòng VIP đơn">Phòng VIP đơn</option>
                    <option value="Phòng VIP đôi">Phòng VIP đôi</option>
                </select>
            </div>
                <button type="submit" runat="server" onserverclick="btnDangKy_Click">Đăng ký</button>
                <asp:ValidationSummary ID="txtTomTatLoi" runat="server" />
            <div id="txtThongBao" runat="server">
            </div>
        </form>
    </div>
</body>

</html>