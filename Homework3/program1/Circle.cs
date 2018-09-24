using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Circle : Graph
    {
        public Circle(double c,double d) : base(c,d)
        {

        }
        public override double GetResult()
        {
            return Math.PI * this.NumberOne * this.NumberOne;
        }
    }
}
