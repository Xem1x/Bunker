<%@ Page Title="Game Page" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="BUNKER.Pages.Game" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content-wrapper">
        <div class="player-slider">
            <div class="player-card-wrapper">
                <div class="player-card-inner">
                    <h3 class="player-name" id ="player_name">Valera's hater<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </h3>
                    <a id ="Job" >
                    <div class="param-name">Професія</div>
                    <div class="param-value">Лікар</div>
                    </a>
                    <a id ="Bio" >
                    <div class="param-name">Біо характеристики</div>
                    <div class="param-value revealed">Жінка, 29 р.</div>
                    </a>
                    <a id ="Heath" >
                    <div class="param-name">Хвороба</div>
                    <div class="param-value">Дислексія</div>
                    </a>
                    <a id ="Phoby" >
                    <div class="param-name">Фобія</div>
                    <div class="param-value">Мегалофобія</div>
                    </a>
                    <a id ="Hoby" >
                    <div class="param-name">Хобі</div>
                    <div class="param-value">Музика</div>
                    </a>
                    <a id ="Dop_info" >
                    <div class="param-name">Доп. інформація</div>
                    <div class="param-value">Має великий хуй</div>
                    </a>
                    <a id ="knowlage" >
                    <div class="param-name">Знання</div>
                    <div class="param-value">Знає в кого маленький хуй</div>
                    </a>
                </div>
                <div class="action-card use-card">
                    <div class="card-name">Картка дії</div>
                    <div class="card-description">Якась хуйня залупна, яку ніхто не буде читати, бо всі їбали рот автора і його намагання створити нормальну гру. Життя несправедливе, піду плакать.</div>
                </div>
                <div class="condition-card use-card">
                    <div class="card-name">Картка умови</div>
                    <div class="card-description">Якась хуйня залупна, яку ніхто не буде читати, бо всі їбали рот автора і його намагання створити нормальну гру. Життя несправедливе, піду плакать.</div>
                </div>
            </div>
            <div class="player-card-wrapper">
                               <div class="player-card-inner">
                    <h3 class="player-name" id ="player_name2">Valera's hater<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                   </h3>
                    <a id ="Job2" >
                    <div class="param-name">Професія</div>
                    <div class="param-value">Лікар</div>
                    </a>
                    <a id ="Bio2" >
                    <div class="param-name">Біо характеристики</div>
                    <div class="param-value revealed">Жінка, 29 р.</div>
                    </a>
                    <a id ="Heath2" >
                    <div class="param-name">Хвороба</div>
                    <div class="param-value">Дислексія</div>
                    </a>
                    <a id ="Phoby2" >
                    <div class="param-name">Фобія</div>
                    <div class="param-value">Мегалофобія</div>
                    </a>
                    <a id ="Hoby2" >
                    <div class="param-name">Хобі</div>
                    <div class="param-value">Музика</div>
                    </a>
                    <a id ="Dop_info2" >
                    <div class="param-name">Доп. інформація</div>
                    <div class="param-value">Має великий хуй</div>
                    </a>
                    <a id ="knowlage2" >
                    <div class="param-name">Знання</div>
                    <div class="param-value">Знає в кого маленький хуй</div>
                    </a>
                </div>
            </div>
            <div class="player-card-wrapper">
                               <div class="player-card-inner">
                    <h3 class="player-name" id ="player_name3">Valera's hater</h3>
                    <a id ="Job3" >
                    <div class="param-name">Професія</div>
                    <div class="param-value">Лікар</div>
                    </a>
                    <a id ="Bio3" >
                    <div class="param-name">Біо характеристики</div>
                    <div class="param-value revealed">Жінка, 29 р.</div>
                    </a>
                    <a id ="Heath3" >
                    <div class="param-name">Хвороба</div>
                    <div class="param-value">Дислексія</div>
                    </a>
                    <a id ="Phoby3" >
                    <div class="param-name">Фобія</div>
                    <div class="param-value">Мегалофобія</div>
                    </a>
                    <a id ="Hoby3" >
                    <div class="param-name">Хобі</div>
                    <div class="param-value">Музика</div>
                    </a>
                    <a id ="Dop_info3" >
                    <div class="param-name">Доп. інформація</div>
                    <div class="param-value">Має великий хуй</div>
                    </a>
                    <a id ="knowlage3" >
                    <div class="param-name">Знання</div>
                    <div class="param-value">Знає в кого маленький хуй</div>
                    </a>
                </div>
            </div>
        </div>
    </div>
    <!--Script references. -->
    <!--Reference the jQuery library. -->
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <!--Reference the SignalR library. -->
    <script src="../Scripts/jquery.signalR-2.2.2.min.js"></script>
    <!--Reference the autogenerated SignalR hub script. -->
    <script src="signalr/hubs"></script>
    <script type="text/javascript" src="//cdn.jsdelivr.net/npm/slick-carousel@1.8.1/slick/slick.min.js"></script>

    <script src="../wwwroot/js/script.js"></script>
    <!--Add script to update the page and send messages.-->
<%--    <script type="text/javascript"> $(function () {
        $(document).ready(function () {
            $(".player-slider").append("<p id=*/<% = Session["Name"] %>/*>test</p>")
        })
        // Declare a proxy to reference the hub.
        var game = $.connection.servHub;
        // Create a function that the hub can call to broadcast messages.
        game.client.broadcastMessage = function (name, message) {

        };
        $('#displayname').val('*/<% = Session["Name"] %>/*');
            // Start the connection.
            $.connection.hub.start().done(function () {
                $('#sendmessage').click(function () {
                    // Call the Send method on the hub.
                    game.server.send();

                });
            });
        });
    </script>--%>

</asp:Content>

