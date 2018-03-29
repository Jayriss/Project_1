using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Token
/// </summary>
public class Token
{
    public int health;
    public int attack;
    public int defense;
    public static int movement = 4;
    public int movementLeft = movement;
    public int positionX;
    public int positionY;
    public bool canAttack = false;

    public void moveTokenUp()
    {
        if (movementLeft < 0)
        {
            positionY++;
            movementLeft--;
        }
    }
    public void moveTokenDown()
    {
        if (movementLeft < 0)
        {
            positionY--;
            movementLeft--;
        }
    }
    public void moveTokenRight()
    {
        if (movementLeft < 0)
        {
            positionX++;
            movementLeft--;
        }
    }
    public void moveTokenLeft()
    {
        if (movementLeft < 0)
        {
            positionX--;
            movementLeft--;
        }
    }
    public int tokenAttack(Token enemy)
    {
        Random roll = new Random();
        int dice = roll.Next(1, 21);
        int attackValue = dice + attack;
        if (attackValue > enemy.defense && canAttack)
        {
            enemy.health--;
        }
        return attackValue;

    }


}
public class PlayerChar : Token
{

    public PlayerChar(int health, int attack, int defense, int movement, int positionX, int positionY)
    {
        this.health = health;
        this.attack = attack;
        this.defense = defense;
        this.positionX = positionX;
        this.positionY = positionY;
    }
}

public class EnemyChar : Token
{
    public EnemyChar(int health, int attack, int defense, int movement, int positionX, int positionY)
    {
        this.health = health;
        this.attack = attack;
        this.defense = defense;
        this.positionX = positionX;
        this.positionY = positionY;
    }
}

public class GameBoard
{
    Token[,] boardArray = new Token[5, 5];
    int playerPosX;
    int playerPosY;
    int enemyPosX;
    int enemyPosY;

    public GameBoard(int px, int py, Token pt, int ex, int ey, Token et)
    {
        this.playerPosX = px;
        this.playerPosY = py;
        boardArray[playerPosX, playerPosY] = pt;
        this.enemyPosX = ex;
        this.enemyPosY = ey;
        boardArray[enemyPosX, enemyPosY] = et;
    }


    //ClientScript.RegisterStartupScript(); m
}

public static class Javascript
{
    static string scriptTag = "<script type=\"\" language=\"\">{0}</script>";
    public static void ConsoleLog(string message)
    {
        string function = "console.log('{0}');";
        string log = string.Format(GenerateCodeFromFunction(function), message);
        HttpContext.Current.Response.Write(log);
    }

    public static void Alert(string message)
    {
        string function = "alert('{0}');";
        string log = string.Format(GenerateCodeFromFunction(function), message);
        HttpContext.Current.Response.Write(log);
    }

    static string GenerateCodeFromFunction(string function)
    {
        return string.Format(scriptTag, function);
    }
}
