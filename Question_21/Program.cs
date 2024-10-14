namespace Question_21
{
    public class Product
    {
        public decimal CalculateTotalPrice(decimal price, int quantity)
        {
            decimal TotalPrice = price * quantity;
            return TotalPrice;
        }
        public decimal CalculateTotalPrice(decimal price, int quantity, int discountPercentage)
        {
            decimal TotalPriceWithDiscount = (price * quantity) - (price * quantity * discountPercentage / 100);
            return TotalPriceWithDiscount;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Price Without discount ");
            Console.WriteLine("2.Price with discount");
            Console.WriteLine("Enter the choice");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Enter the Price");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter the quantity");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product();
                decimal totalPrice =( price * quantity);
                Console.WriteLine($"Total price without discount{totalPrice}");
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter the Price");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter the quantity");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the discount percentage");
                int discountPercentage = int.Parse(Console.ReadLine());
                Product product = new Product();
                decimal TotalPriceWithDiscount = product.CalculateTotalPrice( price, quantity,discountPercentage);
                //decimal totalPricediscount = (price * quantity) - (price * quantity * discountPercentage / 100);
                Console.WriteLine($"Total Price with discount{TotalPriceWithDiscount}");
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }
    }
}

