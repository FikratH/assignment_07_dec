using System.Linq;

namespace assignment_07_dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a sentence:");
            string? str = Console.ReadLine();
            Console.WriteLine("Please, enter a string to check if it a sentence contains it: ");
            string? str2 = Console.ReadLine();
            Console.WriteLine(str?.CustomContains(str2)); 
        }
    }
}