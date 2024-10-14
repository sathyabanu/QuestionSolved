namespace question_20
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Desktop");
            Console.WriteLine("2.Laptop");
            Console.WriteLine("Enter the option");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Desktop desktop = new Desktop();
                Console.WriteLine("Enter the Processor");
                desktop.Processor = Console.ReadLine();
                Console.WriteLine("Enter the ramSize");
                desktop.RamSize =int.Parse( Console.ReadLine());
                Console.WriteLine("Enter the HardDiskSize");
                desktop.HardDiskSize =int.Parse( Console.ReadLine());
                Console.WriteLine("Enter the Graphical card size");
                desktop.GraphicCard=int.Parse( Console.ReadLine());
                Console.WriteLine("Enter the monitor Size");
                desktop.MonitorSize=int.Parse( Console.ReadLine());
                Console.WriteLine("Enter the powersupply volt");
                desktop.PowerSupplyVolt=int.Parse( Console.ReadLine());
                Console.WriteLine();
                double DesktopPrice=desktop.DesktopPriceCalculation();
                Console.WriteLine($"Desktop price is{DesktopPrice}");

            }
            else if (option == 2)
            {
                Laptop laptop = new Laptop();
                Console.WriteLine("Enter the Processor");
                laptop.Processor = Console.ReadLine();
                Console.WriteLine("Enter the ramSize");
                laptop.RamSize = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the HardDiskSize");
                laptop.HardDiskSize = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Graphical card size");
                laptop.GraphicCard = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the display Size");
                laptop.DisplaySize= int.Parse( Console.ReadLine());
                Console.WriteLine("Enter the batteryvolt");
                laptop.Batteryvolt=int.Parse( Console.ReadLine());
                double LaptopPrice = laptop.LaptopPriceCalculation();
                Console.WriteLine($"Laptop Price is {LaptopPrice}");

            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }
    }
}
