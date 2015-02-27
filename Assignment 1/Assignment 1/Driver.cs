using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Driver
    {
        static void Main(string[] args)
        {
            Quadrilateral q = new Square();
            q.CalculateArea();

            q = new Rectangle();
            q.CalculateArea();

            q = new Parallelogram();
            q.CalculateArea();

            q = new Trapezoid();
            q.CalculateArea();


            System.Console.WriteLine("Press any key to continue ...");
            System.Console.ReadKey();

        }
    }
}
