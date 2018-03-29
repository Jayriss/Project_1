using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static PlayerChar player = new PlayerChar(10, 5, 10, 2, 0, 0);
    static EnemyChar enemy = new EnemyChar(10, 5, 10, 2, 4, 4);
    GameBoard board = new GameBoard(player.positionX, player.positionY, player, enemy.positionX, enemy.positionY, enemy);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bool gameRun = true;
            //while (gameRun)
            //{
            //    if ((enemy.positionX == player.positionX || enemy.positionX == player.positionX - 1 || enemy.positionX == player.positionX + 1) && (enemy.positionY == player.positionY || enemy.positionY == player.positionY - 1 || enemy.positionY == player.positionY + 1))
            //    {
            //        player.canAttack = true;
            //    }

            //}
        }


        
    }

    protected void playerMoveUp(object sender, EventArgs e)
    {
        player.moveTokenUp();
        
    }
    protected void playerMoveDown(object sender, EventArgs e)
    {
        player.moveTokenDown();
    }
    protected void playerMoveRight( object sender, EventArgs e)
    {
        player.moveTokenRight();
    }
    protected void playerMoveLeft(object sender, EventArgs e)
    {
        player.moveTokenLeft();
    }
    protected void playerAttack(object sender, EventArgs e)
    {
        player.tokenAttack(enemy);
    }
}