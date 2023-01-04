<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BUNKER.Pages.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Font-Size="30pt" Text="Введи своє ім'я"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="39px" Width="240px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Height="47px" OnClick="Button1_Click" Text="Вхід " Width="240px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </div>

</asp:Content>
