using System.Security.Cryptography.X509Certificates;

namespace question_8
{
    public class Program
    {
        public string UpdatePrice(string[] details, int id, double amount)
        {
            {
                foreach (var item in details)
                {
                    string[] eachDetail = item.Split(':');
                    int prodId = int.Parse(eachDetail[0]);
                    if (prodId == id)
                    {
                        eachDetail[2] = amount.ToString();
                        return eachDetail[1] + " " + eachDetail[2];
                    }

                }
                return string.Empty;
            }
        }
           static void Main(string[] args)
            {
                Console.WriteLine("Enter the number of products");
                int noOfProducts = int.Parse(Console.ReadLine());
                string[] productDetails = new string[noOfProducts];
                Console.WriteLine("Enter the product details (ID:Name:Price):");
                for (int i = 0; i < noOfProducts; i++)
                {
                    productDetails[i] = Console.ReadLine();
                }
                Console.WriteLine("Enter the product id ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the amount to update ");
                int amount = int.Parse(Console.ReadLine());
                Program program = new Program();
                string result = program.UpdatePrice(productDetails, id, amount);
                if (result != string.Empty)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Invalid Id");
                }

            }
        }
    }

