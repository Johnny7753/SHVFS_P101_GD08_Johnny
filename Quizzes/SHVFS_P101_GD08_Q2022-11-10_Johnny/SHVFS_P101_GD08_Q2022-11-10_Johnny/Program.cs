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
            string[] classname = {"Johnny","Cloud","April","Oprah","Naomi","latte zia","Hardy","Yuki","Ar1es","Jerry","Naven","Mate","Bandy","Daderol" };
            Console.WriteLine($"Welcome! Please enter your name!");
            name=Console.ReadLine();
            Console.Clear();
            Random random = new Random();
            int secret = random.Next(0,13);
            secretword = classname[secret];
            Console.WriteLine(secretword);
            for (i = 1; ;i++)
            {
                Console.WriteLine($"Welcome {name}! Let's guess what the secret name is!\nPlease enter name of Johnny,Cloud,April,Oprah,Naomi,latte zia,Hardy,Yuki,Ar1es,Jerry,Naven,Mate,Bandy,Daderol!");
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