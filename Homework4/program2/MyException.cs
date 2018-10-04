using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class MyException : ApplicationException
    {
        private int idnumber;
        public MyException(string message,int id) : base(message)
        {
            this.idnumber = id;
        }
        public int getId()
        {
            return idnumber;
        }
    }
    public class Test
    {
        public static void Delete(List<string> mylist, string number)
        {
            if (mylist.Contains(number) == false)
            {
                throw new MyException("不存在该订单号", 1);
            }
        }
    }
}