namespace ques_10
{
   public class Program
    {
        public string FindWhoGotMaximumPoints(int[][] points)
        {
            int Students = points.Length;
            int maxPoints = 0;
            int studentMax = 0;

            for (int i = 0; i < Students; i++)
            {
                int totalPoints = 0;

                for (int j = 0; j < points[i].Length; j++)
                {
                    totalPoints += points[i][j];
                }
                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    studentMax = i + 1;
                }
            }

            return $"Student {studentMax} got maximum points";


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int students = int.Parse(Console.ReadLine());
            int[][] points = new int[students][];
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("Enter the number of competitions attended by student " + (i + 1));
                int competitions = int.Parse(Console.ReadLine());
                points[i] = new int[competitions];
                Console.WriteLine($"Enter the student {i + 1} points:");
                for (int j = 0; j < competitions; j++)
                {
                    points[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Program program = new Program();
            string result = program.FindWhoGotMaximumPoints(points);
            Console.WriteLine(result);

        }
    }
}
