using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[99];
            int i;
            Console.WriteLine("素数有:");
            for (i=0;i<99;i++)
            {
                a[i] = i + 2;
                int j;
                for(j=2;j<a[i];j++)
                {
                    if (a[i] % j == 0)
                    {
                        a[i] = 0;
                    }
                }
                if (a[i] != 0)
                    Console.Write(a[i]+" ");
            }
        }
    }
}
