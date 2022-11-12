
using System.Reflection.Metadata.Ecma335;

class Quizz
{
    public struct Position
    {
        public int x;
        public int y;
        public int z;
        public Position(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
    }


    public class GameObject
    {
        public string Name;
        public Position pos;
        public GameObject(string name, Position position)
        {
            Name = name;
            pos = position;
        }
        public bool compare(GameObject game)
        {
            if (pos.x == game.pos.x && pos.y == game.pos.y && pos.z == game.pos.z)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        
    }
    public static void Main(string[] args)
    {
        var gameArray= new GameObject[5];
        var game1 = new GameObject("1", new Position(0, 0, 0));
        var game2 = new GameObject("2", new Position(1, 1, 1));
        var game3 = new GameObject("3", new Position(2, 2, 2));
        var game4 = new GameObject("4", new Position(2, 2, 2));
        var game5 = new GameObject("5", new Position(1, 1, 1));
        gameArray[0] = game1;
        gameArray[1] = game2;
        gameArray[2] = game3;
        gameArray[3] = game4;
        gameArray[4] = game5;
        for(int i = 0; i < 4; i++)
        {
            for(int j = i+1; j <5; j++)
            {
                if (gameArray[i].compare(gameArray[j]))
                {
                    Console.WriteLine($"{gameArray[i].Name} is same as {gameArray[j].Name}");
                }
            }
        }
    }
}