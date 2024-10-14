namespace ques_12
{
    public class Program
    {
        public void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (char.ToLower(chars[i]) == char.ToLower(chars[j]))
                    {
                        chars[j] = specialChar;
                        break;
                    }
                }
            }
            Console.WriteLine("The new Array is");
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size ");
            int size = int.Parse(Console.ReadLine());
            char[] chars = new char[size];
            Console.WriteLine($"Enter {size} Elements");
            for (int i = 0; i < size; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the special character ");
            char specialchar = char.Parse(Console.ReadLine());
            Program program = new Program();
            program.ReplaceDuplicateWithSpecialChar(ref chars, specialchar);
        }
    
    }
}

