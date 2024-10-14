using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ques_2
{
   public  class Movie
    {
        public static string name { get; set; }
        public int ticketId { get; set; }
        public string seatNumber {  get; set; }
        public Movie ReturnMovieDetails(string name, int ticketId, string seatNumber)
        {
            Movie movie = new Movie();
           
            Movie.name = name;
            movie.ticketId = ticketId;
            movie.seatNumber = seatNumber;
            return movie;
           

        }
    }
}
