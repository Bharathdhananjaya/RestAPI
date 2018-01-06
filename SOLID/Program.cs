using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator cal = new AreaCalculator();
            cal.GetArea();

            SOLIDLSP.AreaCalculator cal1 = new SOLIDLSP.AreaCalculator();
            cal1.GetArea();
        }
    }
}
