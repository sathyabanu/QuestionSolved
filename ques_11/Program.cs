using System.Security.Cryptography.X509Certificates;

namespace ques_11
{
   public class Program
    {
        public object CalculateDiscountedPrice(object totalCost)
        {
            double discount = 0;
            double cost = Convert.ToDouble((int)totalCost);
            if (cost >= 100 && cost <= 500)
            {
                discount = (cost * 5) / 100;
            }
            else if (cost >= 500 && cost <= 1000)
            {
                discount = (cost * 15) / 100;
            }
            else if (cost >= 1000)
            {
                discount = (cost * 30) / 100;
            }
            double finalCost = cost - discount;
            return (object)finalCost;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total cost ");
            int price = int.Parse(Console.ReadLine());
            object totalCost = (object)price;
            Program program = new Program();
            object result = program.CalculateDiscountedPrice(price);
            double discountedPrice = (double)result;
            Console.WriteLine(discountedPrice);


        }
    }
}
