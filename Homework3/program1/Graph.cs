using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public abstract class Graph
    {
        public double NumberOne { get; set; }
        public double NumberTwo { get; set; }
        public Graph(double a, double b)
        {
            this.NumberOne = a;
            this.NumberTwo = b;
        }
        public abstract double GetResult();
    }
}
