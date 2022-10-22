namespace SHVFS_P101_GD08_C3_Johnny
{
    public class program
    {
        public static void Main(string[] args)
        {
            //var firstNumber = 20;
            //var secondNumber = 30;
            //var evaluation=firstNumber > secondNumber;
            //bool altevaluation=firstNumber < secondNumber;
            //var daxiao = 1 > 4;
            //Console.WriteLine($"{evaluation} {Convert.ToInt32(evaluation)}");
            //Console.WriteLine($"{altevaluation} {Convert.ToInt32(altevaluation)}");
            //Console.WriteLine($"{daxiao} {Convert.ToInt32(daxiao)}");



            //int numberToGuess = 232;
            //int guess=0;
            //while (guess != numberToGuess)
            //{
            //Console.WriteLine("What number am I thinking of?");
            //guess=Convert.ToInt32(Console.ReadLine());
            //    if (guess < numberToGuess)
            //    {
            //        Console.WriteLine("too low");
            //    }
            //    if (guess > numberToGuess)
            //    {
            //        Console.WriteLine("too high");
            //    }
            //    if (guess == numberToGuess)
            //    {
            //        Console.WriteLine("Corret");
            //    }
            //}
            //Console.ReadLine();
            var rand = new Random();//生成随机数rand
            var randomBoolA = Convert.ToBoolean(rand.Next(2));//rand.Next(2)生成小于2大于等于0的整数
            var randomBoolB = Convert.ToBoolean(rand.Next(2));
            var randomBoolC = Convert.ToBoolean(rand.Next(2));
            Console.WriteLine($"A is {randomBoolA},B is {randomBoolB},C is {randomBoolC}");
            Console.WriteLine($"A is {Convert.ToInt32(randomBoolA)},B is {Convert.ToInt32(randomBoolB)},C is {Convert.ToInt32(randomBoolC)}");
            //Console.WriteLine("A is {0},B is {1},C is {2}",randomBoolA,randomBoolB,randomBoolC);
            //Console.WriteLine($"A is {randomBoolA},B is {randomBoolB},C is {randomBoolC}");
            //Console.WriteLine("A is "+randomBoolA+ " B is " +randomBoolB+"C is"+randomBoolC);
            //三种形式都一样
            Console.WriteLine($"{false && true || true}");//C#中与门（&&）优先级比或门（||）高 先计算与门（&&）再计算或门（||）  ! ---> & ---> ^ ---> | ---> && ---> ||
        }
    }
}