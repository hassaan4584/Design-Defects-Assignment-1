using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Q_2
{
    class Car : CarbonFootprint
    {
        public String Colour { get; set; }

        public String CompanyName { get; set; }

        public int cost { get; set; }


        public void getCarbonFootprint()
        {
            System.Console.WriteLine("Cars Emit some carbon dioxide.\n");
        }

    }
}
