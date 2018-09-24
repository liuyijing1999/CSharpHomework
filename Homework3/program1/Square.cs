using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Square :Graph
    {
        public Square(double e, double f) : base(e, f)
        {

        }
        public override double GetResult()
        {
            return this.NumberOne * this.NumberOne;
        }
    }
}
