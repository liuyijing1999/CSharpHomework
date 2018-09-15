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
            string num = "";
            int n = 0;
            Console.Write("Please input an int:");
            num = Console.ReadLine();
            n = Int32.Parse(num);
            int i;
            int j;
            for(i=1;i<=n;i++)
            {
                for(j=2;j<=i;j++)
                {
                    if (i % j == 0)
                    {
                        if (i == j)
                        {
                            Console.WriteLine(i + "是素数");
                        }
                        else
                            break;
                    }
                }
            }
        }
    }
}
