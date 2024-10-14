using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace question_17
{
   public class Owner
    {
        protected string ownerName {  get; set; }
        
    }
    public class Car : Owner
    {
        internal double price { get; set; }
        private string bodyStyle { get; set; }
        
        public string BodyStyle
        {
            get { return bodyStyle; }
            set { bodyStyle = value; }
        }
    
    public bool ValidateBodyStyle(string bodyStyle)
    {
        if (bodyStyle == "SUV" || bodyStyle == "Sedan")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
          public double CalculatePrice()
        {
            if (bodyStyle == "SUV")
            {
            return price - (price * 0.10);
            }
            else if (bodyStyle == "Sedan")
            {
                return price - (price * 0.25); 
            }
            else
            {
                return 0;
            }
        
        
        }
        //set owmername
        public void SetOwnerName(string name)
        {
            ownerName = name;

        }
        
    }
}
