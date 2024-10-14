using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace question_19
{
   public class Book
    {
        private string title {  get; set; }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string author { get; set; }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }private int numPages {  get; set; }
        public int NumPages
        {
            get { return numPages; }
            set { numPages = value; }
        }
        private DateTime dueDate { get; set; }
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        private DateTime returnedDate { get; set; }
        public DateTime ReturnDate
        {
            get { return returnedDate; }
            set { returnedDate = value; }
        }
        
        // parameterized constructors
        public Book (string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }
        public double AveragePagesReadPerDay(double daysToRead)
        {
            double AveragePagesReadPerDay = numPages / daysToRead;
            return AveragePagesReadPerDay;
        }
        public double CalculateLateFee(double dailyLateFeeRate)
        {
            int NumberOfDaysLate = (returnedDate - dueDate).Days;
            double CalculateLateFee = (NumberOfDaysLate * dailyLateFeeRate);
            return CalculateLateFee ;
        }
    }
}
