<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Guestbook.aspx.cs" Inherits="BaiThucHanh3.Guestbook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="GuestBook.css" />
    <title>Guest book</title>
</head>
<body>
    <div class="container">
        <h1>Guest Book</h1>
        <form id="guestBook" runat="server">
            <div class="input-group">
                <label for="txtTieuDe">Tiêu đề</label>
                <input type="text" id="txtTieuDe" runat="server" />
                <asp:RequiredFieldValidator ID="tieuDeValidator" runat="server" ErrorMessage="Vui lòng nhập tiêu đề" ControlToValidate="txtTieuDe"></asp:RequiredFieldValidator>
            </div>
            <div class="input-group">
                <label for="txtHoTen">Họ tên</label>
                <input type="text" id="txtHoTen" runat="server" />
                <asp:RequiredFieldValidator ID="hoTenValidator" runat="server" ErrorMessage="Vui lòng nhập họ tên" ControlToValidate="txtHoTen"></asp:RequiredFieldValidator>
            </div>
            <div class="input-group">
                <label for="txtEmail">Email</label>
                <input type="email" id="txtEmail" runat="server" />
                <asp:RegularExpressionValidator ID="emailValidator" runat="server" ErrorMessage="Vui lòng nhập đúng định dạng email" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>
            <div class="input-group">
                <label for="txtNoiDung">Nội dung</label>
                <textarea id="txtNoiDung" runat="server"></textarea>
                <asp:RequiredFieldValidator ID="noiDungValidator" runat="server" ErrorMessage="Vui lòng nhập nội dung" ControlToValidate="txtNoiDung"></asp:RequiredFieldValidator>
            </div>
            <div class="input-group">
                <p style="visibility: hidden;">.</p>
                <div>
                    <button type="submit" runat="server" onserverclick="BtnGui_Click">Gửi nội dung</button></div>
            </div>
        </form>
    </div>
    <div class="container">
        <h1>Danh sách comment <span id="commentCount" runat="server"></span></h1>
        <div class="comment-container">
        <asp:Repeater ID="commentRepeater" runat="server">
            <ItemTemplate>
                
                    <div class="comment">
                        <div class="avatar-container">
                            <div class="avatar"></div>
                        </div>
                        <div class="comment-content">
                            <h4 class="name"><%# Eval("name")%></h4>
                            <p class="email"><%# Eval("email")%> - <%# Eval("date")%></p>
                            <p class="title"><%# Eval("title")%></p>
                            <p class="content"><%# Eval("comment")%></p>
                        </div>
                    </div>
            </ItemTemplate>
        </asp:Repeater>
      </div>
    </div>
</body>
</html>
