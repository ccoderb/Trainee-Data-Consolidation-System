<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Grid.aspx.cs" Inherits="Grid" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 265px; margin-bottom: 0px">
    
        Get data about trainee :
        <asp:Button ID="bHome" runat="server" onclick="bHome_Click" 
            style="z-index: 1; left: 509px; top: 36px; position: absolute; height: 24px; width: 68px" 
            Text="Home" />
    
        <asp:GridView ID="gvTable" runat="server" 
            style="z-index: 1; left: 39px; top: 136px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
    
        <asp:DropDownList ID="ddlName" runat="server" 
            style="z-index: 1; left: 181px; top: 33px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="lName" runat="server" 
            style="z-index: 1; left: 91px; top: 36px; position: absolute" Text="Name:"></asp:Label>
        <asp:Button ID="bShow" runat="server" onclick="bShow_Click" 
            style="z-index: 1; left: 92px; top: 91px; position: absolute" Text="Show" />
    
    </div>
    </form>
</body>
</html>
