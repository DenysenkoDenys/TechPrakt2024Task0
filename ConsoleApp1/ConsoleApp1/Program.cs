using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            Console.Write("Введіть число 1 :");

            if (!double.TryParse(Console.ReadLine(), out double first))
            {
                Console.WriteLine("Введіть коректне число:");
            }
            Console.Write("Введіть число 2 :");

            if (!double.TryParse(Console.ReadLine(), out double second))
            {
                Console.WriteLine("Введіть коректне число:");
            }
            Console.WriteLine($" Cума = {first + second}");
        }
    }
}