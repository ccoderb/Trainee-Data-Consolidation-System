<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Projectinfo.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 374px" bgcolor="#ccffff">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lCberror" runat="server" ForeColor="Red" 
            style="z-index: 1; left: 299px; top: 230px; position: absolute"></asp:Label>
    
        <asp:DropDownList ID="ddlName" runat="server" Height="20px" 
            style="z-index: 1; left: 444px; top: 35px; position: absolute; bottom: 260px">
        </asp:DropDownList>
        <asp:Label ID="lName" runat="server" 
            style="z-index: 1; left: 361px; top: 36px; position: absolute" Text="Name:"></asp:Label>
        <asp:Label ID="lCategory" runat="server" 
            style="z-index: 1; left: 22px; top: 157px; position: absolute" 
            Text="Project Category"></asp:Label>
        <asp:TextBox ID="tbCategory" runat="server" 
            style="z-index: 1; left: 159px; top: 158px; position: absolute"></asp:TextBox>
    
        <asp:TextBox ID="tbTitle" runat="server" 
            style="z-index: 1; left: 162px; top: 79px; position: absolute"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Project&nbsp; Information</div>
    <asp:Label ID="lTitle" runat="server" 
        style="z-index: 1; left: 24px; top: 81px; position: absolute" 
        Text="Title:"></asp:Label>
    <asp:Label ID="lFrontend" runat="server" 
        style="z-index: 1; left: 23px; top: 102px; position: absolute" 
        Text="Frontend technology:"></asp:Label>
    <asp:TextBox ID="tbFrontend" runat="server" 
        style="z-index: 1; left: 162px; top: 102px; position: absolute"></asp:TextBox>
    <asp:Label ID="lBackend" runat="server" 
        style="z-index: 1; left: 23px; top: 126px; position: absolute" 
        Text="Backend technology:"></asp:Label>
    <asp:TextBox ID="tbBackend" runat="server" 
        style="z-index: 1; left: 160px; top: 129px; position: absolute"></asp:TextBox>
    <asp:Button ID="bSave" runat="server" 
        style="z-index: 1; left: 248px; top: 225px; position: absolute" 
        Text="Save" onclick="bSave_Click" />
    <asp:CheckBox ID="cbConfirm" runat="server" 
        style="z-index: 1; left: 53px; top: 228px; position: absolute" 
        Text="Confirm" />
    </form>
</body>
</html>
