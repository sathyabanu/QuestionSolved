using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace question_20
{
   public class Desktop:Computer
    {
      public int MonitorSize {  get; set; }
      public int PowerSupplyVolt {  get; set; }
        public double DesktopPriceCalculation()
        {
            //double DesktopPrice = ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + (GraphicCard * GraphicCardPrice) + (MonitorSize * MonitorPrice) + (PowerSupplyVolt * PowerSupplyVoltPrice);
            int ProcessorCost = 0;
            if (Processor == "i3")
            {
                ProcessorCost = 1500;
            }
            else if (Processor == "i5")
            {
                ProcessorCost = 3000;
            }
            else if (Processor == "i7")
            {
                ProcessorCost = 4500;
            }
            else
            {
                Console.WriteLine("Invalid Processor");
            }
            return ProcessorCost + (RamSize * 200) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (MonitorSize * 250) + (PowerSupplyVolt * 20);
        }

        
       
        }
        }
    

