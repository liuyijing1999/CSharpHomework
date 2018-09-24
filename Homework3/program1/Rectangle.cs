using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Rectangle : Graph
    {
        public Rectangle(double g, double h) : base(g, h)
        {

        }
        public override double GetResult()
        {
            return this.NumberOne * this.NumberTwo;
        }
    }
}
