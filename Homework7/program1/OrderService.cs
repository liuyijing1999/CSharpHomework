﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class OrderService
    {
        public Order order1;
        public Order order2;
        public Order order3;
        public Order order4;
        public List<Order> list = new List<Order>();

        public void Add(Order order)
        {
            try
            {              
                if (list.Contains(order))
                {
                    throw new Exception($"order-{order} is already existed!");
                }
                list.Add(order);
                for (int i = 0; i < list.Count; i = i + 1)
                {
                    Console.WriteLine(list[i].Number + " " + list[i].Name + " " + list[i].Client + " " + list[i].Price);
                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("本次添加操作结束");
        }
        public void Delete(Order order)
        {           
            list.Remove(order);
            if (list.Contains(order) == false)
            {
                Console.WriteLine("未找到此订单");
            }
            Console.WriteLine("本次删除操作结束");
        }
        public void Change(Order order, Order newOrder)
        {
            try
            {
                //Console.WriteLine("请输入要修改的订单号:");
                //string number = Console.ReadLine();
                //int j = list.Count;
                //int i;
                //for (i = 0; i < list.Count; i++)
                //{
                //    if (list[i].Number.Equals(number))
                //    {
                //        Console.WriteLine(list[i].Number + " " + list[i].Name + " " + list[i].Client + " " + list[i].Price);
                //        j = j - 1;
                //    }
                //}
                //if (j == list.Count)
                //{
                //    throw new Exception($"未找到此订单");
                //}
                //Console.WriteLine("请输入新的商品名称:");
                //string name = Console.ReadLine();
                //Console.WriteLine("请输入新的客户:");
                //string client = Console.ReadLine();
                //Console.WriteLine("请输入新的价格:");
                //double price = Convert.ToDouble(Console.ReadLine());
                //list[i - 1].Name = name;
                //list[i - 1].Client = client;
                //list[i - 1].Price = price;
                //Console.WriteLine(list[i - 1].Number + " " + list[i - 1].Name + " " + list[i - 1].Client + " " + list[i - 1].Price);
                Delete(order);
                Add(newOrder);
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("本次修改操作结束");
        }
        public void Inquiry(int method, string information)
        {
            if (method == 1)
            {
                var m = from order in list where order.Number == information select order;
                foreach (var order in m)
                {
                    Console.WriteLine(order.Number + " " + order.Name + " " + order.Client + " " + order.Price);
                    order1 = order;
                }
                if (m.Count() == 0)
                    Console.WriteLine("无查询结果");
            }
            else if (method == 2)
            {
                var m = from order in list where order.Name == information select order;
                foreach (var order in m)
                {
                    Console.WriteLine(order.Number + " " + order.Name + " " + order.Client + " " + order.Price);
                    order2 = order;
                }
                if (m.Count() == 0)
                    Console.WriteLine("无查询结果");
            }
            else if (method == 3)
            {
                var m = from order in list where order.Client == information select order;
                foreach (var order in m)
                {
                    Console.WriteLine(order.Number + " " + order.Name + " " + order.Client + " " + order.Price);
                    order3 = order;
                }
                if (m.Count() == 0)
                    Console.WriteLine("无查询结果");
            }
            else if (method == 4)
            {
                var m = from order in list where order.Price == Convert.ToDouble(information) select order;
                foreach (var order in m)
                {
                    Console.WriteLine(order.Number + " " + order.Name + " " + order.Client + " " + order.Price);
                    order4 = order;
                }
                if (m.Count() == 0)
                    Console.WriteLine("无查询结果");
            }
        }
        public void Print()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Number + " " + list[i].Name + " " + list[i].Client + " " + list[i].Price);
            }
            Console.WriteLine("订单金额大于1万的订单有:");
            var m = from order in list where order.Price > 10000 select order;
            foreach (var order in m)
            {
                Console.WriteLine(order);
            }
            if (m.Count() == 0)
                Console.WriteLine("没有订单金额大于1万的订单");
        }
    }
}
