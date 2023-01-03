<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="BUNKER.Pages.Game" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
        <asp:Panel ID="Panel1" runat="server" BackColor="#66FF99" Width="378px">
            <asp:Label ID="Label1" runat="server" Font-Size="30pt" Text=" "></asp:Label><br />
            <asp:Label ID="Label2" runat="server" Font-Size="30pt" Text="Професія "></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Font-Size="20pt" Height="53px" OnClick="Button1_Click" Text="Лікар" Width="212px" />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="30pt" Text="Вік"></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" Text="20" />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Size="30pt" Text="Хвороба"></asp:Label>
            <br />
            <asp:Button ID="Button3" runat="server" Font-Size="20pt" Text="Д" />
            <br />
            <asp:Label ID="Label5" runat="server" Font-Size="30pt" Text="Фобія"></asp:Label>
            <br />
            <asp:Button ID="Button4" runat="server" Font-Size="20pt" Text="Button" />
            <br />
            <asp:Label ID="Label6" runat="server" Font-Size="28pt" Text="Додаткова інформація"></asp:Label>
            <br />
            <asp:Button ID="Button5" runat="server" Font-Size="20pt" Text="Button" />
            <br />
            <asp:Label ID="Label7" runat="server" Font-Size="30pt" Text="Знання"></asp:Label>
            <br />
            <asp:Button ID="Button6" runat="server" Font-Size="20pt" Text="Button" />
            <br />
        </asp:Panel>
        <br />

    </div>
        

</asp:Content>

