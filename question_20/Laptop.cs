using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace question_20
{
    public class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int Batteryvolt { get; set; }


        public double LaptopPriceCalculation()
        {
            //double Laptop Price = Processor Cost + (RamSize * Ram Price) +(HardDiskSize * Hard Disk Price)+(GraphicCard * Graphic Card Price) +(Display Size* Display Price) +(BatteryVolt * BatteryVolt Price);
            int ProcessorCost = 0;

            if (Processor == "i3")
            {
                ProcessorCost = 2500;
            }
            else if (Processor == "i5")
            {
                ProcessorCost = 5000;
            }
            else if (Processor == "i7")
            {
                ProcessorCost = 6500;
            }
            else
            {
                Console.WriteLine("invalid Processor");
            }
            return ProcessorCost + (RamSize * 200) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (DisplaySize * 250) + (Batteryvolt * 20);
        }
    }
}
