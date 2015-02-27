using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Q_2
{
    class Bicycle : CarbonFootprint
    {
        public String Type { get; set; }

        public void getCarbonFootprint()
        {
            System.Console.WriteLine("Bicycles don\'t emit carbon dioxide.\n");
        }
    }
}
