using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ques_16
{
    public class Program
    {


        public static Candy CalculateDiscountedPrice(Candy candy)
        {
            candy.TotalPrice = candy.Quantity * candy.PricePerPrice;
            double DiscountPrice = 0;
            if (candy.Flavour == "Strawberry")
            {
                DiscountPrice = 15;
            }
            else if (candy.Flavour == "Lemon")
            {
                DiscountPrice = 10;
            }
            else if (candy.Flavour == "Mint")
            {
                DiscountPrice = 5;
            }
            candy.DiscountPrice = candy.TotalPrice - (candy.TotalPrice * DiscountPrice / 100);
            return candy;
        }


            public static void Main(string[] args)
            {
                Console.WriteLine("Enter the flavour");
                string flavour = Console.ReadLine();
                Console.WriteLine("enter the quantity");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the price per piece");
                int price = int.Parse(Console.ReadLine());

                Candy candy = new Candy();
                candy.Quantity = quantity;
                candy.PricePerPrice = price;
                candy.Flavour = flavour;
            

                if (candy.ValidateCandyFlavour())
                {
                candy = CalculateDiscountedPrice(candy);

                Console.WriteLine("Flavour : " + candy.Flavour);
                    Console.WriteLine("Quantity : " + candy.Quantity);
                    Console.WriteLine("Price Per Piece : " + candy.PricePerPrice);
                    Console.WriteLine("Total Price : " + candy.TotalPrice);
                    Console.WriteLine("Discount Price : " + candy.DiscountPrice);
                }
                else
                {
                    Console.WriteLine("invalid flavour");
                }

            }
        }
    }

