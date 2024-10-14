namespace question_19
{
   public class Program
    {
        public static object AveragePagesReadPerDay { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the title");
            string title=Console.ReadLine();
            Console.WriteLine("Enter the author");
            string author=Console.ReadLine();
            Console.WriteLine("Enter the number of pages");
            int numberOfPages=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the due date");
            DateTime dueDate=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the return date");
            DateTime returnedDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the days to read");
            double daysToRead=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the daily late feeRate");
            double dailyLateFeeRate=double.Parse(Console.ReadLine());
            Console.WriteLine();
            //create an object
            Book book = new Book(title, author, numberOfPages, dueDate, returnedDate);
            //call the methods
            double averagePages = book.AveragePagesReadPerDay(daysToRead);
            double lateFee = book.CalculateLateFee(dailyLateFeeRate);
            Console.WriteLine($"Average Pages Read Per Day {averagePages}");
            Console.WriteLine($"LateFee {lateFee}");

        }
    }
}
