using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 5, 8, 10, 3, 7, 2, 9, 4, 6 };
            int max = a[0];
            int min = a[0];
            int sum = 0;
            int i;
            for(i=0;i<a.Length;i++)
            {
                if (a[i] > max)
                    max = a[i];
                if (a[i] < min)
                    min = a[i];
                sum = sum + a[i];
            }
            Console.WriteLine("最大值是" + max);
            Console.WriteLine("最小值是" + min);
            Console.WriteLine("平均值是" + sum/a.Length);
            Console.WriteLine("所有元素的和是" + sum);
        }
    }
}
