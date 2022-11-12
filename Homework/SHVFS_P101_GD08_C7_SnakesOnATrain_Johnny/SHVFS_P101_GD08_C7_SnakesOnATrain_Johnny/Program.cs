using System.Numerics;

namespace SHVFS_P101_GD08_C7_SnakesOnATrain
{
    public class Program
    {
        private static player player1 = new player()
        {
            Direction = position.Right,
            InputDirections = new Dictionary<ConsoleKey, position>()
            {
                {
                    ConsoleKey.W, position.UP
                },
                {
                    ConsoleKey.S, position.Down
                },
                {
                    ConsoleKey.A, position.Left
                },
                {
                    ConsoleKey.D, position.Right
                },
            }
        };
        private static player player2 = new player()
        {
            Direction = position.Right,
            InputDirections = new Dictionary<ConsoleKey, position>()
            {
                {
                    ConsoleKey.UpArrow, position.UP
                },
                {
                    ConsoleKey.DownArrow, position.Down
                },
                {
                    ConsoleKey.LeftArrow, position.Left
                },
                {
                    ConsoleKey.RightArrow, position.Right
                },
            }
        };
        public static void Main(string[] args)
        {
            var title = "Snakes On A Train";
            Console.CursorLeft = Console.BufferWidth / 2 - title.Length / 2;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.Yellow;
            var player1control = "Player 1's controls:\n" +
                               "\n" +
                               "W - Up\n" +
                               "A - Left\n" +
                               "S - Down\n" +
                               "D - Right";
            Console.WriteLine(player1control);
            var player2control = "Player 2's controls:";
            var cursorLeft = Console.BufferWidth - player2control.Length;
            Console.CursorTop = 1;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorLeft=cursorLeft;
            Console.WriteLine("Player 2's controls:\n");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Up Arrow - Up");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Left Arrow - Left");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Down Arrow - Down");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Right Arrow - Right");
            Console.ReadKey();
            Console.Clear();
            SetupPlayArea();

        }
        public struct position
        {
            public int x;
            public int y;
            public position(int X,int Y)
            {
                x = X;
                y = Y;
            }
            public static readonly position UP=new position(0,1);
            public static readonly position Down = new position(0, -1);
            public static readonly position Left = new position(-1, 0);
            public static readonly position Right = new position(1, 0);
        }
        public class player
        {
            public position Position;
            public position Direction;
            public Dictionary<ConsoleKey, position> InputDirections;
        }
        private static void SetupPlayArea()
        {
            Console.WindowHeight = 30;
            Console.BufferHeight = 30;
            Console.WindowWidth = 100;
            Console.BufferWidth = 100;
            usedGridPositions = new bool[Console.WindowWidth, Console.WindowHeight];
            player1.Direction = position.Right;
            player1.Position.x = 0;
            player1.Position.y = Console.WindowHeight/2;
            player2.Direction = position.Left;
            player2.Position.x = Console.WindowWidth-1;
            player2.Position.y = Console.WindowHeight / 2;

        }
    }
}