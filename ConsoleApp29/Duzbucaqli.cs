using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Duzbucaqli : IShape
    {
        private double uzunluq;
        private double en;

        public Duzbucaqli(Double uzunluq,Double en)
        {
            this.uzunluq = uzunluq;
            this.en = en;   
        }
        public double CalculateArea()
        {
            return uzunluq * en;
        }

        public double CalculatePerimetr()
        {
            return 2*(uzunluq + en);
        }
    }
}
