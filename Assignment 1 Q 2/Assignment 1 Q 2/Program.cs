using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            Building building = new Building();
            Car car = new Car();

            List<CarbonFootprint> list = new List<CarbonFootprint>();
            list.Add(bicycle);
            list.Add(building);
            list.Add(car);

            for (int i = 0; i < list.Count; i++)
                list.ElementAt(i).getCarbonFootprint();

            System.Console.WriteLine("Press any key to continue ...");
            System.Console.ReadKey();
        }
    }
}
