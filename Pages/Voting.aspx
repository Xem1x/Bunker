<%@ Page Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="Voting.aspx.cs" Inherits="BUNKER.Pages.Voting" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
    <asp:Label ID="Label1" runat="server" Text="Проголосувало "></asp:Label><asp:Label ID="Label2" runat="server" Text=""></asp:Label><asp:Label ID="Label3" runat="server" Text=" гравців"></asp:Label><br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
    
    <br />
    <%--<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />--%>
        <a ID="Q1" runat="server" onclick ="q1_Click" href ="#" visible="True">Button</a>
        </div>
</asp:Content>