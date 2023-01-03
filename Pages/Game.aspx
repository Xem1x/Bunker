<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="BUNKER.Pages.Game" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
        <asp:Panel ID="Panel1" runat="server" BackColor="#66FF99" Width="378px">
            <asp:Label ID="Label1" runat="server" Font-Size="30pt" Text=" "></asp:Label><br />     
            <div>
                <a id ="Job" >
                    <asp:Label ID="Label2" runat="server" Font-Size="30pt" Text="Професія "></asp:Label><br /> 
                    <div> Лікар </div>
                </a>
            </div>
            <br />
            <div>
                <a id ="Age" >
                    <asp:Label ID="Label3" runat="server" Font-Size="30pt" Text="Вік "></asp:Label><br /> 
                    <div> 20 </div>
                </a>
            </div>
            <br />

             <div>
                <a id ="health" >
                    <asp:Label ID="Label4" runat="server" Font-Size="30pt" Text="Хвороба"></asp:Label><br /> 
                    <div> Хво </div>
                </a>
            </div>
            <br />
             <div>
                <a id ="Phoby" >
                    <asp:Label ID="Label5" runat="server" Font-Size="30pt" Text="Фобія"></asp:Label><br /> 
                    <div> Фоб </div>
                </a>
            </div>
            <br />
             <div>
                <a id ="info" >
                    <asp:Label ID="Label6" runat="server" Font-Size="30pt" Text="Додаткова інформація"></asp:Label><br /> 
                    <div> Додаткова інфо </div>
                </a>
            </div>
            <br />
             <div>
                <a id ="knowlage" >
                    <asp:Label ID="Label8" runat="server" Font-Size="30pt" Text="Знання"></asp:Label><br /> 
                    <div> know </div>
                </a>
            </div>
            <br />
        </asp:Panel>
        <br />

    </div>
        

</asp:Content>

