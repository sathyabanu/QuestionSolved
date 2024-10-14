using System.Runtime;

namespace ques1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample Input:");
            Console.WriteLine("Enter an integer value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the float value");
            float b=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the double value");
            double c=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the long value");
            long d=long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the string");
            string e = Console.ReadLine();
            Console.WriteLine("Sample Output");
            Console.WriteLine("int:"+a);
            Console.WriteLine("float:"+b);
            Console.WriteLine("double:"+c);
            Console.WriteLine("long:"+d);
            Console.WriteLine("string:"+e);
            
        }
    }
}
