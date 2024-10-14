using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace question_7
{
    public class Program
    {
        private static string sentence;

        private static int number;

        //exponential
        public static StringBuilder FindExponential(int number)
        {
            StringBuilder sb = new StringBuilder("Exponential is");
            double exp = Math.Exp(Math.Log10(number));
            sb.Append(exp.ToString("E"));
            return sb;

        }
        //replace
        public static StringBuilder ReplaceWord(string sentence, string word1, string word2)
        {
            StringBuilder sb = new StringBuilder(sentence);
            sb.Replace(word1, word2);
            return sb;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1.Find Exponential");
            Console.WriteLine("2.Replace word");
            Console.WriteLine("Choose option");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());
                StringBuilder result = FindExponential(number);
                Console.WriteLine("Exponential is" + result);
            }
            else if (option == 2)
            {
                Console.WriteLine("enter the input");
                string sentence = Console.ReadLine();
                Console.WriteLine("replace word");
                string word1 = Console.ReadLine();
                Console.WriteLine("new word");
                string word2 = Console.ReadLine();
                StringBuilder res = ReplaceWord(sentence, word1, word2);
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("invalid option");
            }

        }
        }
    }

