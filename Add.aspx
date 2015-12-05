<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 324px" bgcolor="#a2cafb">
    <form id="form1" runat="server">
    <div style="height: 20px">
    
        .<asp:Button ID="bUpload" runat="server" onclick="bUpload_Click" 
            style="z-index: 1; left: 686px; top: 66px; position: absolute" Text="Upload" />
    
        <asp:RegularExpressionValidator ID="revContactno" runat="server" 
            ControlToValidate="tbContactno" ErrorMessage="10 digit number only" 
            style="z-index: 1; left: 251px; top: 282px; position: absolute" 
            ValidationExpression="[0-9]{10}$"></asp:RegularExpressionValidator>
    
        <asp:FileUpload ID="fuPhoto" runat="server" 
            style="z-index: 1; left: 681px; top: 25px; position: absolute" />
    
    </div>
    <asp:Label ID="lName" runat="server" 
        style="z-index: 1; left: 22px; top: 36px; position: absolute; right: 723px" 
        Text="Name:"></asp:Label>
    <asp:TextBox ID="tbName" runat="server" 
        style="z-index: 1; top: 33px; position: absolute; left: 80px"></asp:TextBox>
    <asp:TextBox ID="tbInstitute" runat="server" 
        style="z-index: 1; left: 77px; top: 73px; position: absolute"></asp:TextBox>
    <asp:Label ID="lCourse" runat="server" 
        style="z-index: 1; left: 16px; top: 112px; position: absolute" Text="Course:"></asp:Label>
    <asp:DropDownList ID="ddlCourse" runat="server" 
        style="z-index: 1; left: 78px; top: 109px; position: absolute">
        <asp:ListItem>B.Tech</asp:ListItem>
        <asp:ListItem>MBA</asp:ListItem>
        <asp:ListItem>B.Com.</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="lYear" runat="server" 
        style="z-index: 1; left: 16px; top: 142px; position: absolute" Text="Year:"></asp:Label>
    <asp:DropDownList ID="ddlYear" runat="server" 
        style="z-index: 1; left: 78px; top: 141px; position: absolute">
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem Selected="True">2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="lStartdate" runat="server" 
        style="z-index: 1; left: 17px; top: 177px; position: absolute" 
        Text="StartDate:"></asp:Label>
    <asp:ImageButton ID="ibStartdate" runat="server" 
        ImageUrl="~/Images/ic_launcher_calendar.png" onclick="ibStartdate_Click" 
        
        style="z-index: 1; left: 252px; top: 169px; position: absolute; height: 32px; width: 34px" />
    <asp:TextBox ID="tbStartdate" runat="server" 
        ontextchanged="tbStartdate_TextChanged" 
        style="z-index: 1; left: 91px; top: 177px; position: absolute"></asp:TextBox>
    <asp:Calendar ID="cEnddate" runat="server" 
        onselectionchanged="cEnddate_SelectionChanged" 
        
        
        
        style="z-index: 1; left: 293px; top: 209px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
    <asp:Calendar ID="cStartdate" runat="server" 
        onselectionchanged="cStartdate_SelectionChanged" 
        
        style="z-index: 1; left: 292px; top: 175px; position: absolute; height: 188px; width: 259px">
    </asp:Calendar>
    <asp:Label ID="lEnddate" runat="server" 
        style="z-index: 1; left: 15px; top: 208px; position: absolute" Text="EndDate:"></asp:Label>
    <asp:Label ID="lCberror" runat="server" ForeColor="Red" 
        style="z-index: 1; left: 346px; top: 432px; position: absolute" Visible="False"></asp:Label>
    <asp:Label ID="lAddress" runat="server" 
        style="z-index: 1; left: 15px; top: 314px; position: absolute" Text="Address:"></asp:Label>
    <asp:TextBox ID="tbEnddate" runat="server" ontextchanged="tbEnddate_TextChanged" 
        style="z-index: 1; left: 90px; top: 207px; position: absolute"></asp:TextBox>
    .<p>
    <asp:Label ID="lInstitute" runat="server" 
        style="z-index: 1; left: 15px; top: 75px; position: absolute; bottom: 443px;" 
            Text="Institute:"></asp:Label>
        <asp:Label ID="lCerror" runat="server" ForeColor="Red" 
            style="z-index: 1; left: 171px; top: 228px; position: absolute" Visible="False"></asp:Label>
    </p>
    <asp:Label ID="lDuration" runat="server" 
        style="position: absolute; z-index: 1; left: 16px; top: 248px; bottom: 271px; height: 19px" 
        Text="Duration:"></asp:Label>
    <asp:DropDownList ID="ddlDuration" runat="server" 
        style="z-index: 1; left: 89px; top: 245px; position: absolute">
        <asp:ListItem Value="6">6 Weeks</asp:ListItem>
        <asp:ListItem Value="8">8 Weeks</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="lContactno" runat="server" 
        style="z-index: 1; left: 13px; top: 277px; position: absolute" 
        Text="Contact No:"></asp:Label>
    <asp:TextBox ID="tbAddress" runat="server" 
        
        style="z-index: 1; left: 94px; top: 317px; position: absolute; width: 203px; height: 57px"></asp:TextBox>
    <asp:Label ID="lPhoto" runat="server" 
        style="z-index: 1; left: 641px; top: 27px; position: absolute" Text="Photo:"></asp:Label>
    <p>
        &nbsp;</p>
    <asp:TextBox ID="tbContactno" runat="server" 
        style="z-index: 1; left: 88px; top: 278px; position: absolute"></asp:TextBox>
    <asp:Image ID="iphoto" runat="server" ImageUrl="~/Images/download.jpg" 
        
        style="z-index: 1; left: 653px; top: 130px; position: absolute; width: 224px" />
    <asp:Button ID="bSave" runat="server" 
        style="z-index: 1; left: 294px; top: 427px; position: absolute" 
        Text="Save" onclick="bSave_Click" />
    <asp:CheckBox ID="cbConfirm" runat="server" 
        style="z-index: 1; left: 92px; top: 432px; position: absolute" Text="Confirm" />
    <p>
        <asp:ImageButton ID="ibEnddate" runat="server" 
            ImageUrl="~/Images/ic_launcher_calendar.png" 
            
            
            style="z-index: 1; left: 251px; top: 204px; position: absolute; height: 33px; width: 34px" 
            onclick="ibEnddate_Click" />
        <asp:Label ID="lDiscipline" runat="server" 
            style="z-index: 1; left: 294px; top: 143px; position: absolute" 
            Text="Discipline:"></asp:Label>
        <asp:TextBox ID="tbDiscipline" runat="server" 
            style="z-index: 1; left: 367px; top: 141px; position: absolute"></asp:TextBox>
        <asp:Label ID="lReferenceno" runat="server" 
            style="z-index: 1; left: 15px; top: 398px; position: absolute" 
            Text="Reference No.:"></asp:Label>
        <asp:TextBox ID="tbReferenceno" runat="server" 
            style="z-index: 1; left: 111px; top: 397px; position: absolute"></asp:TextBox>
    </p>
    </form>
</body>
</html>
