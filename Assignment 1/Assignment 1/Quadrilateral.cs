using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{

  public abstract  class Quadrilateral
    {
        public int x1 { get; set; }

        public int x2 { get; set; }

        public int y1 { get; set; }

        public int y2 { get; set; }

        public abstract void CalculateArea();
    
    }
}
