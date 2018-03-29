<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Board Game</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
            <div>
                <h1>My board game</h1>
            </div>
            <div id="gamespace">
                <asp:ImageButton ID="moveUp" runat="server" OnClick="playerMoveUp" ImageUrl="Content/MoveUp.jpg" />
                <asp:ImageButton ID="moveDown" runat="server" OnClick="playerMoveDown" ImageUrl="Content/MoveDown.jpg" />
                <asp:ImageButton ID="moveLeft" runat="server" OnClick="playerMoveLeft" ImageUrl="Content/MoveLeft.jpg" />
                <asp:ImageButton ID="moveRight" runat="server" OnClick="playerMoveRight" ImageUrl="Content/MoveRight.jpg" />
                <img id="gameBoard" src="Content/Grass_square.jpg" />
                <asp:Button ID="newGameButton" runat="server" Text="Start new game?" />
                <asp:Label ID="score" runat="server" Text=""></asp:Label>
                <asp:Label ID="movementLeft" runat="server" Text=""></asp:Label>
                <asp:Label ID="playerHealth" runat="server" Text=""></asp:Label>
                <asp:Label ID="enemyHealth" runat="server" Text=""></asp:Label>
                <asp:Label ID="attackLog" runat="server" Text=""></asp:Label>
                <asp:Image ID="playerToken" runat="server" ImageUrl="Content/PlayerToken.png" />
                <asp:Image ID="enemyToken" runat="server" ImageUrl="Content/EnemyToken.png" />
                <asp:ImageButton ID="attackButton" runat="server" OnClick="playerAttack" ImageUrl="Content/AttackIcon.jpg" />
            </div>
        <script language="javascript">

        </script>
            <%--<asp:Button ID="waitButton" runat="server" Text="Wait" OnClick="playerWait"/>--%>
    </form>
</body>
</html>
