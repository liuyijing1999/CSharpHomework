using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class OrderDetails
    {
        ////private double price;
        ////public OrderDetails(string number, string name, string client, double value)
        ////{
        ////    Number = number;
        ////    Name = name;
        ////    Client = client;
        ////    Price = value;
        ////}
        //public string Number { get; set; }
        //public string Name { get; set; }
        //public string Client { get; set; }
        //public double Price
        //{
        //    get { return price; }
        //    set
        //    {
        //        if (value < 0)
        //            throw new ArgumentOutOfRangeException("value must >= 0!");
        //        price = value;
        //    }
        //}
        ////public OrderDetails(string number, string name, string client, double value)
        ////{
        ////    this.Id = id;
        ////    this.Goods = goods;
        ////    this.Quantity = quantity;
        ////}

        ////public uint Id { get; set; }

        ////public Goods Goods { get; set; }

        ////public uint Quantity { get; set; }

        ////public override bool Equals(object obj)
        ////{
        ////    var detail = obj as OrderDetails;
        ////    return detail != null &&
        ////        Goods.Id == detail.Goods.Id &&
        ////        Quantity == detail.Quantity;
        ////}

        ////public override int GetHashCode()
        ////{
        ////    var hashCode = 1522631281;
        ////    hashCode = hashCode * -1521134295 + Goods.Name.GetHashCode();
        ////    hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
        ////    return hashCode;
        ////}

        ////public override string ToString()
        ////{
        ////    string result = "";
        ////    result += $"orderDetailId:{Id}:  ";
        ////    result += Goods + $", quantity:{Quantity}";
        ////    return result;
        ////}
        ////public override string ToString()
        ////{
        ////    return $"Number:{Number}, Name:{Name}, Client:{Client},Price:{Price}";
        ////}
    }
}
