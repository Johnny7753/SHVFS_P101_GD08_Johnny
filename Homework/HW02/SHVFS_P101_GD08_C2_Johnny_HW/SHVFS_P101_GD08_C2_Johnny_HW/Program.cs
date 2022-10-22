namespace GD08_C2_Johnny_HW
{
    public class program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine($"Type Fahrenheit degree I can transform it to centigrade.");
                float huashiduf = float.Parse(Console.ReadLine());
                Console.Clear();
                var sheshidu = (huashiduf - 32) / 1.8;
                Console.WriteLine($"{huashiduf} degree fahrenheit = {sheshidu} degree centigrade.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}