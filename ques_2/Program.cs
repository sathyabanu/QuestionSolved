namespace ques_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            Console.WriteLine("Enter the movie name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the ticketid");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seat number");
            string seatno=Console.ReadLine();
            // Create a Movie object
           //Movie m= new Movie();

            // Call the method to return movie details
            Movie res = movie.ReturnMovieDetails(name,id,seatno);

            Console.WriteLine("sample output:");
            Console.WriteLine("Movie name:"+name);
            Console.WriteLine("Ticket id:"+id);
            Console.WriteLine("Seat Number:" +seatno);
        }
    }
}
