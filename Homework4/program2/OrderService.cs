using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderService
    {
        public static void Add(List<string> mylist,string number,string name,string client)
        {
            string[] temArr = { number, name,client };
            mylist.AddRange(temArr);                
        }
        public static void Delete(List<string> mylist,string number)
        {
            try
            {
                Test.Delete(mylist, number);
                int i = 0;

                for (i = 0; i < mylist.Count - 2; i = i + 3)
                {
                    if (mylist[i] == number)
                        mylist.RemoveRange(i, 3);
                }
            }
            catch (MyException e)
            {
                Console.WriteLine("删除失败,不存在该订单号,出错种类" + e.getId());
            }
            Console.WriteLine("本次删除操作结束");
        }
        public static void Change(List<string> mylist, string number,string name,string client)
        {
            try
            {
                Test.Delete(mylist, number);
                int i = 0;
                for (i = 0; i < mylist.Count - 2; i = i + 3)
                {
                    if (mylist[i] == number)
                    {
                        mylist[i + 1] = name;
                        mylist[i + 2] = client;
                    }
                }
            }
            catch (MyException e)
            {
                Console.WriteLine("修改失败,不存在该订单号,出错种类" + e.getId());
            }
            Console.WriteLine("本次修改操作结束");
        }
        public static void Inquiry(List<string> mylist, int method,string information)
        {
            for (int i = 0; i < mylist.Count - 2; i = i + 3)
            {
                if (mylist[i+method-1] == information)
                {
                    Console.WriteLine(mylist[i] + " " + mylist[i + 1] + " " + mylist[i + 2]);
                }
            }
            int j = 0;
            while(j < mylist.Count - 2&& mylist[j + method - 1] != information)
            {               
                j = j + 3;           
            }
            if(j== mylist.Count)
                Console.WriteLine("无搜查结果");
        }
    }
}
