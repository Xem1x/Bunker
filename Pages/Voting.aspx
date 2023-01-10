<%@ Page Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="Voting.aspx.cs" Inherits="BUNKER.Pages.Voting" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<a id="menu-link"> Меню</a>
    <div id='menu' class="menu slide-in-left">
        <nav>
    <div class="jumbotron">
    <asp:Label ID="Label1" runat="server" Text="Проголосувало "></asp:Label><asp:Label ID="Label2" runat="server" Text=""></asp:Label><asp:Label ID="Label3" runat="server" Text=" гравців"></asp:Label><br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
    
    <br />
                </div> 
        </nav>
    </div> 

    <script>
        var menuLink = document.getElementById('menu-link');
        menuLink.addEventListener('click', openMenu, false);

        function openMenu(e) {
            e.preventDefault();
            let menu = document.getElementById('menu');
            menu.style.left = 0;
        }
    </script>
</asp:Content>