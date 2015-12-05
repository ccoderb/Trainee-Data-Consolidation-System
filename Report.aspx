<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#ccffcc">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lFilename" runat="server" Style="z-index: 1; left: 14px; top: 49px;
            position: absolute" Visible="true"></asp:Label>
        

        <asp:Label ID="lName" runat="server" Text="Name:"></asp:Label>
        &nbsp;
        <asp:DropDownList ID="ddlName" runat="server" Style="z-index: 1; left: 76px; top: 16px;
            position: absolute">
        </asp:DropDownList>
    </div>
    <asp:Button ID="bShow" runat="server" Style="z-index: 1; left: 74px; top: 90px; position: absolute"
        Text="Show Report" OnClick="bShow_Click" />
    </form>
</body>
</html>
