using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques_16
{
  public class Candy
    {
        public string Flavour {  get; set; }
        
        public int Quantity {  get; set; }
        public int PricePerPrice {  get; set; }
        public double TotalPrice {  get; set; }
        public double DiscountPrice {  get; set; }
        public bool ValidateCandyFlavour()
        {
            if (Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
   
   
}
