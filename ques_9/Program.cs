namespace ques_9
{
   public class Program
    {
        public int[] FindStudentsRank(int[,] stdMarks)
        {
            int students = stdMarks.GetLength(0);
            int subject = stdMarks.GetLength(1);
            // storing the values
            int[] total = new int[students];
            int[] ranks = new int[students];
            for (int i = 0; i < students; i++)
            {
                int sum = 0;
                for (int j = 0; j < subject; j++)
                {

                    sum += stdMarks[i, j];
                }
                total[i] = sum;
            }
            for (int i = 0; i < students; i++)
            {
                int rank = 1;
                for (int j = 0; j < students; j++)
                {
                    if (total[j] > total[i])
                    {
                        rank++;
                    }
                }
                ranks[i] = rank;
            }
            return ranks;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students ");
            int noOfstudents = int.Parse(Console.ReadLine());
            int[,] stdMarks = new int[noOfstudents, 5];

            for (int i = 0; i < noOfstudents; i++)
            {
                Console.WriteLine($"Enter marks for Student {i + 1}:");
                for (int j = 0; j < 5; j++)
                {
                    stdMarks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Program program = new Program();
            int[] ranks = program.FindStudentsRank(stdMarks);

            for (int i = 0; i < noOfstudents; i++)
            {
                Console.WriteLine($"Rank of student {i + 1} is {ranks[i]}");
            }


        }
    }
}
