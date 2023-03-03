<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileViewer.aspx.cs" Inherits="BaiThucHanh3.FileViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="FileViewer.css" />
    <title>File Viewer</title>
</head>
<body>
    <div>
        <header>
            <button>Upload tập tin</button>
            <button>Xem các tập tin được upload</button>
        </header>
        <form>
            <input type="file" runat="server" id="inputFile"/>
            <button type="submit">Gửi tập tin</button>
        </form>
    </div>
</body>
</html>
