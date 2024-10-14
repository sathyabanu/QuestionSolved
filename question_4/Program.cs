namespace question_4
{
  public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample Input 1:");
            Console.WriteLine("Enter the Word");
            string str=Console.ReadLine();
            string newstr ="";
            for(int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newstr += char.ToUpper(str[i]);
                }
                else
                {
                    newstr += char.ToLower(str[i]);
                }
            }
            Console.WriteLine(newstr);
        }
    }
}
