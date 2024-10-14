using System.Collections;

namespace question_26
{
   public class Program
    {
        public static ArrayList Attendance = new ArrayList()
        {
            "John","Peter","Jacob","Archie","Sophie","Veronica","Elizabeth","Charles"
        };
        public bool RemoveStudent(string name)
        {
            if (Attendance.Contains(name))
            {
                Attendance.Remove(name);
                return true;
            }
            return false;
        }
        public void SortTheAttendance()
        {
            Attendance.Sort();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            while (true)
            {
                Console.WriteLine("1.Remove Student");
                Console.WriteLine("2.Sort attendance");
                Console.WriteLine("Enter the choice");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter the Student name");
                    string name = Console.ReadLine();
                    //remove student
                    if (program.RemoveStudent(name))
                    {
                        Console.WriteLine("Removed successfully");
                    }
                    else
                    {
                        Console.WriteLine("Remove Failed");
                    }
                }
                else if (option == 2)
                {
                    //sorting in descending order
                    program.SortTheAttendance();
                    foreach (string name in Attendance)
                    {
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
    
}
