using System.Reflection.Metadata.Ecma335;

namespace Question_24
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal amount;
        public decimal Deposit(decimal amount)
        {

            try
            {
                //return Balance + amount;
                if (amount > 0)
                {
                    Console.WriteLine(Balance + amount);

                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Deposit amount must be positive ");

            }
            return Balance + amount;

        }
        public decimal Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Withdraw amount must be positive");
                }
                else if (amount > Balance)
                {
                    Console.WriteLine("Insufficient funds");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Balance - amount;

        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.WriteLine("1.Deposit");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("Enter the choice");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Account number");
            string AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter the balance");
            decimal Balance = decimal.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Enter the amount to be deposit");
                decimal amount = decimal.Parse(Console.ReadLine());
                if (amount <= 0)
                {
                    account.Deposit(amount);
                    Console.WriteLine($"Balance amount{Balance + amount}");
                }
                else
                {
                    Console.WriteLine($"Balance amount{Balance + amount}");
                }
            }
            if (option == 2)
            {
                Console.WriteLine("Enter amount to be Withdraw");
                decimal amount = decimal.Parse(Console.ReadLine());
                if (amount <= 0)
                {
                    account.Withdraw(amount);
                    Console.WriteLine($"Balance amount{Balance - amount}");
                }
                else if (amount > Balance)
                {
                    account.Withdraw(amount);
                    Console.WriteLine($"Balance amount{Balance}");
                }
                else
                {
                    Console.WriteLine($"Balance amount{Balance - amount}");
                }
            }
        }
    }
}
