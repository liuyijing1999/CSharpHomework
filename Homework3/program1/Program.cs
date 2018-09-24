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
            Console.WriteLine("请输入图形，如：Square Circle Triangle Rectangle");
            string strOper = Console.ReadLine();
            Graph s = null;
            switch (strOper)
            {
                case "Triangle":
                    Console.WriteLine("请输入底的长度");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("请输入高的长度");
                    double b = Convert.ToDouble(Console.ReadLine());
                    s = new Triangle(a, b);
                    break;
                case "Circle":
                    Console.WriteLine("请输入半径");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double d = 0;
                    s = new Circle(c, d);
                    break;
                case "Square":
                    Console.WriteLine("请输入边长");
                    double e = Convert.ToDouble(Console.ReadLine());
                    double f = 0;
                    s = new Square(e, f);
                    break;
                case "Rectangle":
                    Console.WriteLine("请输入长");
                    double g = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("请输入宽");
                    double h = Convert.ToDouble(Console.ReadLine());
                    s = new Rectangle(g, h);
                    break;
                default:
                    Console.WriteLine("Input error");
                    break;
            }
            double i = s.GetResult();
            Console.WriteLine("面积为"+i);
        }
    }
}
