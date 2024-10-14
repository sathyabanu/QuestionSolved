namespace question_17
{
    public class Program
    {
        static void Main(string[] args)
        {//input from users
            Car car = new Car();
            Console.WriteLine("Enter the owner name");
            string ownerName=Console.ReadLine();
            Console.WriteLine("Enter the car body style:");
            string bodyStyle=Console.ReadLine();
            Console.WriteLine("Enter the price:");
            //price is internal so we take objectreference
            car.price =double.Parse( Console.ReadLine());
            //call the validatebodystyle method
            if (!car.ValidateBodyStyle(bodyStyle))
            {
                Console.WriteLine("Invalid Car Type");
                return;
            }
            //set the validate bodystyle
            car.BodyStyle = bodyStyle;
            //call calculateprice and setownername
            double Price = car.CalculatePrice();
            car.SetOwnerName(ownerName);
            Console.WriteLine($"The owner {ownerName} sells the{bodyStyle} type car for ${Price}");

            
            
        }
    }
}
