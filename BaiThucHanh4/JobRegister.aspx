<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobRegister.aspx.cs" Inherits="BaiThucHanh4.JobRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="GuestBook.css" />
    <title>Đăng ký thông tin việc làm</title>
</head>

<body>
    <div class="container">
        <h1>Đăng ký thông tin việc làm</h1>
        <form id="form1" runat="server">
            <fieldset>
                <legend>Thông tin cá nhân</legend>
                <div class="input-group">
                    <label for="txtHoTen">Họ và tên</label>
                    <input type="text" id="txtHoTen" runat="server" />
                    <asp:RequiredFieldValidator ID="vHoTen" runat="server" ErrorMessage="Nhập họ tên" ControlToValidate="txtHoTen"></asp:RequiredFieldValidator>
                </div>
                <div class="input-group">
                    <label for="txtNgaySinh">Ngày tháng năm sinh</label>
                    <input type="date" id="txtNgaySinh" runat="server" />
                    <asp:RequiredFieldValidator ID="vNgaySinh" runat="server" ErrorMessage="Nhập ngày tháng năm sinh" ControlToValidate="txtNgaySinh"></asp:RequiredFieldValidator>
                </div>
                <div class="input-group">
                    <label for="txtGioiTinh">Giới tính</label>
                    <select id="txtGioiTinh" runat="server">
                        <option value="Nam">Nam</option>
                        <option value="Nữ">Nữ</option>
                    </select>
                    <asp:RequiredFieldValidator ControlToValidate="txtGioiTinh" runat="server"></asp:RequiredFieldValidator>
                </div>
                <div class="input-group">
                    <label for="txtHonNhan">Tình trạng hôn nhân</label>
                    <select id="txtHonNhan" runat="server">
                        <option value="Độc thân">Độc thân</option>
                        <option value="Đã kết hôn">Đã kết hôn</option>
                    </select>
                </div>
            </fieldset>
            <fieldset>
                <legend>Thông tin liên lạc</legend>
                <div class="input-group">
                    <label for="txtDiaChi">Địa chỉ</label>
                    <input type="text" id="txtDiaChi" runat="server" />
                    <asp:RequiredFieldValidator ID="vDiaChi" runat="server" ErrorMessage="Nhập địa chỉ" ControlToValidate="txtDiaChi"></asp:RequiredFieldValidator>
                </div>
                <div class="input-group">
                    <label for="txtTinh">Tỉnh/Thành phố</label>
                    <input type="text" id="txtTinh" runat="server" />
                    <asp:RequiredFieldValidator ID="vTinh" runat="server" ErrorMessage="Nhập tỉnh/thành phố" ControlToValidate="txtTinh"></asp:RequiredFieldValidator>
                </div>
                <div class="input-group">
                    <label for="txtSdt">Số điện thoại</label>
                    <input type="text" id="txtSdt" runat="server" />
                </div>
                <div class="input-group">
                    <label for="txtEmail">Email</label>
                    <input type="email" id="txtEmail" runat="server" />
                    <asp:RegularExpressionValidator ID="vEmail" runat="server" ErrorMessage="Nhập đúng định dạng email" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </div>
            </fieldset>
            <fieldset>
                <legend>Kinh nghiệm làm việc</legend>
                <div class="input-group">
                    <label for="txtSoNam">Số năm kinh nghiệm</label>
                    <input type="number" id="txtSoNam" runat="server" />
                </div>
                <div class="input-group">
                    <label for="txtKinhNghiem">Kinh nghiệm làm việc</label>
                    <textarea id="txtKinhNghiem" runat="server"></textarea>
                </div>
            </fieldset>
            <fieldset>
                <legend>Mong muốn của bản thân</legend>
                <div class="input-group">
                    <label for="txtViecLam">Việc làm mong muốn</label>
                    <input type="text" id="txtViecLam" runat="server" />
                </div>
                <div class="input-group">
                    <label for="txtLuong">Mức lương thỏa thuận</label>
                    <span class="input-group"><input type="number" id="txtLuong" runat="server" />VND</span>
                    <asp:RequiredFieldValidator ID="vLuong" runat="server" ErrorMessage="Nhập mức lương" ControlToValidate="txtLuong"></asp:RequiredFieldValidator>
                </div>
            </fieldset>
            <asp:ValidationSummary ID="txtTomTatLoi" runat="server" />
                    <asp:button runat="server" PostBackUrl="~/RegisteringComplete.aspx" Text="Gửi hồ sơ"></asp:button>
                    <button type="reset" form="form1">Xóa form</button>
        </form>
    </div>
</body>

</html>
