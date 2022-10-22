//+=自加-=自减*=自乘/=自除%=  ++ -- 
// A+=1 等价于 A=A+1
namespace SHVFS_P101_GD08_C4_Johnny
{
    public class program
    {
        public static void Main(string[] args)
        {
            /*var arithmeticOperatorMultiply = 10;
             arithmeticOperatorMultiply ++;
             Console.WriteLine(arithmeticOperatorMultiply);
             Console.ReadLine();*/
            /* for(var i = 0; i < 10; i++)
             {
                 Console.WriteLine("this is THE FIRST LINE in our FOR LOOP!");
                 Console.WriteLine($"The value of i is {i}");
             }
             Console.WriteLine("LOOP END");
             Console.ReadLine();*/
            /*var input = "";
              while (input != "Quit")
              {
                  Console.Clear();
                  // \ Can be used as an escape character, here let's use use the literal""
                  Console.WriteLine($"Enter \"Quit\" to win the game!");
                  input=Console.ReadLine();
              }
              Console.WriteLine("You win");
              Console.ReadLine();*/
            /*int i;
            Console.WriteLine("Enter 1 for options\n" +
                              "      2 to quit\n" +
                              "      3 to start game");
            do
            {
                Console.WriteLine("Please make a selection!");
                i = Convert.ToInt32(Console.ReadLine());

            } while (i < 1 || i > 3);
            Console.WriteLine("Excellent Choice!");
            Console.ReadLine();*/
            /*for (var i = 0; i<7; i++)
            {
                for(var j = 0; j < 10; j++)
                {
                    Console.WriteLine($"i is {i}, and j is {j}");
                }
            }
            Console.ReadLine();*/
            //Arrays
            //Arrays start at index ZERO
            //Arrays hold STUFF/THINGS ,and we set it to a size of FIVE (it can hold FIVE things!)
            //This array holds ints!
            /*var scores = new int[5];//也可以这么写: int[]scores = new int{54,3,2,6,58};
            scores[0] = 54;
            scores[1] = 3;
            scores[2] = 2;
            scores[3] = 6;
            scores[4] = 58;
            for (var i = 0; i < 5; i++) // 这里的5最好不要这样用，很容易错。最好使用： for(var i=0 ; i < scores.Length; i++)  XXX.Length :XXX的长度
            {
                Console.WriteLine($"the length of scpres is: {scores.Length} | The index is : {i} | The value is: {scores[i]}");
            }
            Console.WriteLine();*/
            //Q1 欢迎用户，输入一个数表示人数，依次输入年龄，计算总值，计算平均数
            //Q2 猜数游戏            三个选项的菜单 1进Q1 2进Q2 3退出
            var rand = new Random();
            var randomnum = rand.Next(1000);
            for (var i = 0; i != 3;)
            {
            Backpoint: Console.Clear();
                Console.WriteLine("Hello! Enter 1 to Age Calculator\n"+
                                  "             2 to Guess Number Game\n"+
                                  "             3 to Quit");
                i = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (i == 1)
                {
                    int numofpeople;
                    Console.WriteLine("Welcome to Age Calculator! Enter a number representing the number of people!");
                    numofpeople = Convert.ToInt32(Console.ReadLine());
                    int age;var totalage=0;float averageage;
                    for (var t = 0; t < numofpeople; t++)
                    {
                        Console.WriteLine($"Enter the NO.{t + 1} people's age\nIf you enter wrong number enter -1 to back to the menu.");
                        age = Convert.ToInt32(Console.ReadLine());
                        if (age == -1)
                        {
                            goto Backpoint;
                        }
                        totalage += age;
                    }
                    averageage=(float)totalage/(float)numofpeople;
                    Console.WriteLine($"Total age is :{totalage}, average age is: {averageage}\nEnter anything to back to the menu");
                    Console.ReadLine();
                }
                if (i == 2)
                {
                    Console.WriteLine("Welcome to Guess Number Game!!!\nThere is a number between 0-1000 Guess what the number is!\nEnter -1 to back to the menu");
                    var guessnum = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                        while(guessnum != randomnum)
                        {
                            if (guessnum == -1) break;
                            if (guessnum > randomnum)
                            {
                                Console.WriteLine("It's too high! Try it again！！！");
                                guessnum = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                            }
                            if(guessnum < randomnum)
                            {
                                Console.WriteLine("It's too low! Try it again！！！");
                                guessnum = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                            }
                            if (guessnum == randomnum)
                            {
                                Console.WriteLine("You are right! Congration！！！");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                }
                Console.Clear();
            }
        }
    }
}
