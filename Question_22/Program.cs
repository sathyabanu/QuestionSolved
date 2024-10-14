using System.Net.Cache;

namespace Question_22
{
    public class Car
    {
        public  string Make { get; set; }
        public  string Model { get; set; }
        public  int year { get; set; }
        public virtual double CalculateCost(double basePrice, int curretYear)
        {
            return basePrice;
        }
    }
    public class SportsCar : Car
    {
        public override double CalculateCost(double basePrice, int currentYear)
        {
            double FixedTaxRate = 0.10;
            double Age = currentYear - year;
            double TotalTax = basePrice * FixedTaxRate * Age;
            return basePrice+TotalTax;
        }
    }
    public class SUV : Car
    {
        public override double CalculateCost(double basePrice, int currentYear)
        {
            double FixedTaxRate=0.05;
            double Age = currentYear - year;
            double TotalTax = basePrice * FixedTaxRate * Age;
            return basePrice + TotalTax;
        
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sports car");
            Console.WriteLine("2.SUV car");
            Console.WriteLine("None of the above");
            Console.WriteLine("choose the option");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Enter the Make");
                string Make = Console.ReadLine();
                Console.WriteLine("Enter the Model");
                string Model = Console.ReadLine();
                Console.WriteLine("Enter the year the car was made");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the basic Price");
                double baseprice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the current year");
                int currentYear = int.Parse(Console.ReadLine());
                //calling
                SportsCar sportsCar = new SportsCar();
                double cost = sportsCar.CalculateCost(baseprice, currentYear);
                Console.WriteLine($"Sports Car cost is{cost}");
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter the Make");
                string Make = Console.ReadLine();
                Console.WriteLine("Enter the Model");
                string Model = Console.ReadLine();
                Console.WriteLine("Enter the year the car was made");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the basic Price");
                double baseprice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the current year");
                int currentYear = int.Parse(Console.ReadLine());
                //calling
                SUV suv = new SUV();
                double cost = suv.CalculateCost(baseprice, currentYear);
                Console.WriteLine($"SUV car cost is{cost}");
            }
            else if (option == 3)
            {
                Console.WriteLine("Enter the Make");
                string Make = Console.ReadLine();
                Console.WriteLine("Enter the Model");
                string Model = Console.ReadLine();
                Console.WriteLine("Enter the year the car was made");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the basic Price");
                double baseprice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the current year");
                int currentYear = int.Parse(Console.ReadLine());
                Console.WriteLine($"the cost is{baseprice}");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
