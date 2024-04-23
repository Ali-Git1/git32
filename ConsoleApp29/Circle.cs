using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class Circle:IShape
    {
        private double radius;

        private const double Value = 5.78;

        public Circle(Double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Value * radius * radius; 
        }

        public double CalculatePerimetr()
        {
            return 2*Value*radius;
        }
    }
}
