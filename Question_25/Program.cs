using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Question_25
{
    public class InvalidFlavourException : Exception
    {
        public InvalidFlavourException(string message) : base(message) { }
    }
    public class Cake
    {
        public string Flavour { get; set; }
        public int QuantityInKg { get; set; }
        public double PricePerKg { get; set; }
        public bool CakeOrder()
        {
            if (Flavour == "Chocolate" || Flavour == "Red Valvet" || Flavour == "Vanilla")
            {

                if (QuantityInKg > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Quantity must be greater than Zero");
                }
            }
            else
            {

                throw new InvalidFlavourException("flovour not available .Please select the available flavour");
            }
        }
        public double CalculatePrice()
        {
            double discountedPrice = 0;
            if (Flavour == "Vanilla")
            {
                discountedPrice = 3;
            }
            else if (Flavour == "Chocolate")
            {
                discountedPrice = 5;
            }
            else if (Flavour == "Red Velvet")
            {
                discountedPrice = 10;
            }
            double discountprice = (QuantityInKg * PricePerKg) - (QuantityInKg * PricePerKg * discountedPrice / 100);
            return discountprice;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the flavour");
                string Flavour = Console.ReadLine();
                Console.WriteLine("Enter the quantity in kg");
                int QuantityInKg = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the price per kg");
                double PricePerKg = double.Parse(Console.ReadLine());
                Cake cake = new Cake();
                {
                    cake.Flavour = Flavour;
                    cake.QuantityInKg = QuantityInKg;
                    cake.PricePerKg = PricePerKg;
                }
                if (cake.CakeOrder())
                { 
                    double dis = cake.CalculatePrice();
                    Console.WriteLine("Cake order was successful");
                    Console.WriteLine("Price after discount is" + dis);
                }
            }
            catch (InvalidFlavourException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
