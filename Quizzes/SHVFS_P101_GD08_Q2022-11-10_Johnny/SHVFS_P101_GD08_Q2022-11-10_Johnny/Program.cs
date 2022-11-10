namespace SHVFS_P101_GD08_Q2_Johnny
{
    public class program
    {
        public static void Main(string[] args)
        {
            string name;
            string secretword;
            string guessword;
            int i;
            Console.WriteLine($"Welcome! Please enter your name!");
            name=Console.ReadLine();
            Console.Clear();
            Random random = new Random();
            int secret = random.Next(97, 123);
            secretword=Convert.ToChar(secret).ToString();
            for (i = 1; ;i++)
            {
                Console.WriteLine($"Welcome {name}! Let's guess what the secret word is!\nPlease enter a word!");
                guessword = Console.ReadLine();
                if (guessword==secretword) break;
                if (guessword != secretword)
                {
                    Console.WriteLine("You,are worng! Please enter another word!");
                    Console.ReadLine();
                }
                Console.Clear();
            }
            Console.WriteLine($"You are right!You have guessed {i} times");
        }
    }
}