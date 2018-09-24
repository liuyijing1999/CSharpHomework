using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Triangle : Graph
    {
        public Triangle(double a, double b) : base(a, b)
        {

        }
        public override double GetResult()
        {
            return this.NumberOne * this.NumberTwo * 0.5;
        }
    }
}
