using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Q_2
{
    class Building : CarbonFootprint
    {
        public String Address { get; set; }

        public bool CommercialArea { get; set; }

        public int TotalRooms { get; set; }



        public void getCarbonFootprint()
        {
            System.Console.WriteLine("Buildings emit a lot of carbon dioxide.\n");
        }
    }
}
