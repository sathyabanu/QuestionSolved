using System.Reflection.Metadata.Ecma335;

namespace Question_23
{
    public abstract class Employee
    {
        public string id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        //validate the id
        public bool ValidateEmployeeId()
        {
            //[A-Za-z]{2}(.*)[0-9]{2}
            if (id.Length == 5 && id.StartsWith("EM") && int.TryParse(id.Substring(2),out int _))
            {
                return true;
            }
            return false;
        }
        public abstract Employee SalaryCalculation();

    }
    public class Permanent : Employee
    {
        public double BasicPay { get; set; }
        //salary calculations
        public override Employee SalaryCalculation()
        {
            Salary = BasicPay + (0.50 * BasicPay) + (0.30 * BasicPay);
            return this;

        }
        public class Temporary : Employee
        {
            public int HrsWorked { get; set; }
            public int HrlyWages { get; set; }
            
            public override Employee SalaryCalculation()
            {
                Salary = HrsWorked * HrlyWages;
                return this;
            }
            public class Program
            {
                static void Main(string[] args)
                {

                    Console.WriteLine("1.Permanent");
                    Console.WriteLine("2.Temporary");
                    Console.WriteLine("Choose the employee type");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        Permanent permanent = new Permanent();
                        Console.WriteLine("Enter the employee id");
                        permanent.id = Console.ReadLine();
                        if (permanent.ValidateEmployeeId())
                        {
                            Console.WriteLine("Enter the Name");
                            permanent.Name = Console.ReadLine();
                            Console.WriteLine("Enter the basic pay");
                            permanent.BasicPay = double.Parse(Console.ReadLine());
                            var result = permanent.SalaryCalculation();
                            Console.WriteLine($"Employee id:{permanent.id},Name:{permanent.Name},Salary:{result.Salary}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid id");
                        }
                    }
                    else if (option == 2)
                    {
                        Temporary temporary = new Temporary();
                        Console.WriteLine("Enter the employee id");
                        temporary.id = Console.ReadLine();
                        if (temporary.ValidateEmployeeId())
                        {
                            Console.WriteLine("Enter the Name");
                            temporary.Name = Console.ReadLine();
                            Console.WriteLine("Enter hours worked");
                            temporary.HrsWorked = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter hourly wages");
                            temporary.HrlyWages = int.Parse(Console.ReadLine());
                            var result = temporary.SalaryCalculation();
                            Console.WriteLine($"Employee id:{temporary.id},Name:{temporary.Name},Salary:{result.Salary}");
                        }
                        else
                        {
                            {
                                Console.WriteLine("Invalid id");
                            }
                        }
                    }
                }
            }
        }
    }
}

