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
            string[] list = { "订单号", "商品名称", "客户", "1", "a", "A" , "2", "b", "B" };
            List<string> mylist = new List<string>(list);    
            while (true)
            {
                Console.WriteLine("操作(输入序号)：1添加订单 2删除订单 3修改订单 4查询订单 0打印并退出");
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("请输入订单号:");
                        string number1 = Console.ReadLine();
                        Console.WriteLine("请输入商品名称:");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("请输入客户:");
                        string client1 = Console.ReadLine();
                        OrderService.Add(mylist, number1, name1, client1);
                        continue;
                    case 2:
                        Console.WriteLine("请输入要删除的订单号:");
                        string number2 = Console.ReadLine();
                        OrderService.Delete(mylist, number2);                       
                        continue;
                    case 3:
                        Console.WriteLine("请输入要修改的订单号:");
                        string number3 = Console.ReadLine();
                        Console.WriteLine("请输入新的商品名称:");
                        string name3 = Console.ReadLine();
                        Console.WriteLine("请输入新的客户:");
                        string client3 = Console.ReadLine();
                        OrderService.Change(mylist, number3,name3,client3);
                        continue;
                    case 4:
                        Console.WriteLine("按订单号查询输入1，按商品名称查询输入2，按客户查询输入3:");
                        int method = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("请输入要查询的信息:");
                        string information = Console.ReadLine();
                        OrderService.Inquiry(mylist,method, information);
                        continue;
                    case 0:
                        for (int i = 0; i < mylist.Count - 2; i = i + 3)
                        {
                            Console.WriteLine(mylist[i] + " " + mylist[i + 1] + " " + mylist[i + 2]);
                        }
                        Console.WriteLine("退出");
                        break;
                }
                break;
            }
        }
    }
}
