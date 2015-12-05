<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Changepw.aspx.cs" Inherits="Changepw" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Label ID="lNew" runat="server" Text="New Password:"></asp:Label>
    <asp:TextBox ID="tbNew" runat="server" 
        style="z-index: 1; left: 135px; top: 34px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="tbOld" runat="server" 
        style="z-index: 1; left: 132px; top: 76px; position: absolute"></asp:TextBox>
    <asp:Label ID="lOld" runat="server" 
        style="z-index: 1; left: 13px; top: 77px; position: absolute; right: 1228px" 
        Text="Old Password:"></asp:Label>
    <asp:Label ID="Label1" runat="server" 
        style="z-index: 1; left: 17px; top: 121px; position: absolute" 
        Text="Verify New Password:"></asp:Label>
    <asp:TextBox ID="tbVerify" runat="server" 
        style="z-index: 1; top: 121px; position: absolute; left: 163px"></asp:TextBox>
    <asp:Button ID="bSubmit" runat="server" 
        style="z-index: 1; left: 107px; top: 168px; position: absolute" Text="Submit" />
    </form>
</body>
</html>
