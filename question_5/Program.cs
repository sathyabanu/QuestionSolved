using System.Data.Common;

namespace question_5
{
    public class Program
    {
        static void Main(string[] args)
        {//input from user
            Console.WriteLine("Enter the String");
            string input = Console.ReadLine();
            //separation by using split method
            string[] words = input.Split(':');
            //conditions
            if (words.Length > 15)
            {
                Console.WriteLine("Invalid Length");
            }
            else
            {
                var count = words.GroupBy(u => u.ToUpper()).ToDictionary(k => k.Key, c => c.Count());
                foreach (var items in count)
                {
                    Console.WriteLine($"{items.Key}:{items.Value}");
                }
            }
        }
    }
}






    