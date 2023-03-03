<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FacebookLogin.aspx.cs" Inherits="BaiThucHanh2.FacebookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="FacebookLogin.css" />
    <title>Login to Facebook</title>
</head>
<body>
    <form class="flex-container" id="form" runat="server">
        <div class="header">
            <div class="logo-holder">
                <div class="logo"></div>
            </div>
            <div class="login-form" id="formLogin">
                <div class="input-group">
                    <label for="txtEmail">Email hoặc điện thoại</label>
                    <input type="text" id="txtEmail" runat="server"/>
                    <div style="visibility: hidden;">.</div>
                </div>
                <div class="input-group">
                    <label for="txtPassword">Mật khẩu</label>
                    <input type="password" id="txtPassword" runat="server"/>
                    <a href="#">Bạn gặp sự cố?</a>
                </div>
                <input class="btn-login" id="btnLogin" runat="server" type="submit" value="Đăng nhập"/>
            </div>
        </div>
        <div class="main-container">
            <div class="welcome-panel">
                <h2 class="welcome-text">Facebook giúp bạn kết nối và chia sẻ với mọi người trong cuộc sống của bạn.
                </h2>
                <div class="welcome-img-container">
                    <div class="welcome-img"></div>
                </div>
            </div>
            <div class="signup-container">
                <h1 class="title">Đăng ký</h1>
                <p class="sub-title">Miễn phí và sẽ luôn như vậy.</p>
                <div class="signup-form">
                    <div class="input-group">
                        <input type="text" id="txtHo" placeholder="Họ" runat="server"/>
                        <input type="text" id="txtTen" placeholder="Tên" runat="server"/>
                    </div>
                    <input type="text" id="txtSignupEmail" placeholder="Số di động hoặc email" runat="server"/>
                    <input type="text" id="txtSignupEmail2" placeholder="Nhập lại số di động hoặc email" runat="server"/>
                    <input type="password" id="txtSignupPassword" placeholder="Mật khẩu mới" runat="server"/>
                    <label for="txtDob">Ngày sinh</label>
                    <div class="input-group">
                        <input type="date" name="" id="txtDob" runat="server"/>
                        <a href="#">Tại sao tôi cần cung cấp ngày sinh của mình?</a>
                    </div>
                    <div class="input-group">
                        <input type="radio" name="txtGender" id="Female" runat="server"/>
                        <label for="Female">Nữ</label>
                        <input type="radio" name="txtGender" id="Male" runat="server"/>
                        <label for="Male">Nam</label> 
                    </div>
                    <p class="policy">Bằng cách nhấp vào Đăng ký, bạn đồng ý với <a href="#">Các điều khoản</a> của chúng
                        tôi và rằng
                        bạn đã đọc <a href="#">Chính sách dữ liệu</a> của chúng tôi, bao gồm <a href="#">Sử dụng
                            cookie</a>.</p>
                    <input class="btn-signup" id="btnSignup" runat="server" type="submit" value="Đăng ký"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
