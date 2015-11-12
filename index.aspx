<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="barcode.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TX Barcode WebForms Sample</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="Barcode1" runat="server" BorderStyle="Solid" BorderWidth="1" /><br />
        <asp:Label ID="lblBarcodeText" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="btnRefresh" runat="server" Text="Refresh" />
    </div>
    </form>
</body>
</html>
