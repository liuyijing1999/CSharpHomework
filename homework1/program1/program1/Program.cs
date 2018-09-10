using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            Console.Write("a = ");
            a = Console.ReadLine();
            int m = 0;
            m = Int32.Parse(a);
            string b = "";
            Console.Write("b = ");
            b = Console.ReadLine();
            int n = 0;
            n = Int32.Parse(b);
            Console.WriteLine("a * b = " + (m * n));
        }
    }
}
