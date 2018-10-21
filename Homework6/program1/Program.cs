using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
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
            OrderService orderService = new OrderService();
            List<Order> list = new List<Order>();
            Order order1 = new Order("1", "1", "1", 1);
            Order order2 = new Order("2", "2", "2", 2);
            Order order3 = new Order("3", "3", "3", 3);
            Order order4 = new Order("4", "4", "4", 4);
            list.Add(order1);
            list.Add(order2);
            list.Add(order4);
            OrderService.Export(list);
            OrderService.Import("s.xml");
            while (true)
            {               
                Console.WriteLine("操作(输入序号)：1添加订单 2删除订单 3修改订单 4查询订单 5打印并查找订单金额大于1万的订单 0退出");
                int operation = Convert.ToInt32(Console.ReadLine());             
                switch (operation)
                {
                    case 1:
                        orderService.Add(order2);
                        orderService.Add(order4);
                        continue;
                    case 2:
                        orderService.Delete(order2);
                        continue;
                    case 3:
                        orderService.Change(order2,order3);
                        continue;
                    case 4:
                        Console.WriteLine("按订单号查询输入1，按商品名称查询输入2，按客户查询输入3:");
                        int method = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("请输入要查询的信息:");
                        string information = Console.ReadLine();
                        orderService.Inquiry(method, information); 
                        continue;
                    case 5:
                        orderService.Print();
                        continue;
                    case 0:
                        break;
                }
                break;
            }
        }
    }
}
