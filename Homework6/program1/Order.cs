using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    [Serializable]
    public class Order
    {
        public Order(string number, string name, string client, double value)
        {
            Number = number;
            Name = name;
            Client = client;
            Price = value;
        }
        public Order() { }
        public double price;
        public string Number { get; set; }
        public string Name { get; set; }
        public string Client { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must >= 0!");
                price = value;
            }
        }
    }
}
