<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lId" runat="server" 
    style="z-index: 1; left: 209px; top: 171px; position: absolute; height: 19px;" 
    Text="Enter ID:"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server" 
    style="z-index: 1; left: 323px; top: 155px; position: relative" 
        ontextchanged="TextBox1_TextChanged"></asp:TextBox>
<asp:Label ID="lPassword" runat="server" 
    style="z-index: 1; left: 207px; top: 209px; position: absolute" 
    Text="Enter Password :"></asp:Label>
<asp:TextBox ID="tbPassword" runat="server" 
    ontextchanged="TextBox2_TextChanged" 
    style="z-index: 1; left: 334px; top: 210px; position: absolute" 
    TextMode="Password"></asp:TextBox>
<asp:Button ID="bLogin" runat="server" 
    style="z-index: 1; left: 364px; top: 261px; position: absolute" Text="Login" />
</asp:Content>

