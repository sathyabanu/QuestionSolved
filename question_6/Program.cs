using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace question_6
{
    public class Program
    {
        public static StringBuilder WordInserting(StringBuilder word1, char ch, string word2)
        {
            int position = word1.ToString().IndexOf(ch);
            if (position != -1)
            {
                word1.Insert(position, word2);
            }
            return word1;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word1");
            StringBuilder word1 = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Enter the character to search");
            char ch = Console.ReadLine()[0];
            Console.WriteLine("Enter the word2");
            string word2 = Console.ReadLine();


            StringBuilder result = WordInserting(word1, ch, word2);
            Console.WriteLine(result);






            //public static StringBuilder word(StringBuilder word1, char ch, string word2)
            //{
            //    int position = word1.ToString().IndexOf(ch);
            //    if (position != -1)
            //    {
            //        word1.Insert(position, word2);
            //    }
            //    return word1;
            //}
            //public static void Main(string[] args) {
            //    Console.WriteLine("word1");
            //    StringBuilder word1= new StringBuilder(Console.ReadLine());
            //    Console.WriteLine("char");
            //    char ch = Console.ReadLine()[0];
            //    Console.WriteLine("word2");
            //    string word2= Console.ReadLine();
            //    StringBuilder res = word(word1, ch, word2);
            //    Console.WriteLine(res);


        }

    }
}
