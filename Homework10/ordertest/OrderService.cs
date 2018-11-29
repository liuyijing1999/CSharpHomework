using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace ordertest
{
    /// <summary>
    /// OrderService:provide ordering service,
    /// like add order, remove order, query order and so on
    /// 实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
    /// </summary>
    public class OrderService
    {

        private Dictionary<string, Order> orderDict;
        /// <summary>
        /// OrderService constructor
        /// </summary>
        public OrderService()
        {
            orderDict = new Dictionary<string, Order>();
        }

        /// <summary>
        /// add new order
        /// </summary>
        /// <param name="order">the order will be added</param>
        public void AddOrder(Order order)
        {
            //if (orderDict.ContainsKey(order.Id))
            //    throw new Exception($"Order is already existed!");
            //if (Verification(order))
            //    orderDict[order.Id] = order;

            using (var db = new OrderDB())
            {
                db.Order.Add(order);
                //db.Order.Attach(order);
                //db.Entry(order).State = EntityState.Added;
                db.SaveChanges();
            }
        }
        //public bool Verification(Order order)
        //{
        //    string a = order.Id.ToString();
        //    string b = order.Customer.Phone.ToString();
        //    if (a == null)
        //    {
        //        throw new Exception($"订单号不能为空");
        //        return false;
        //    }
        //    string pattern1 = "[0-9]{4}-[0-9]{2}-[0-9]{2}-[0-9]{3}";
        //    if (Regex.IsMatch(a, pattern1) == false)
        //    {
        //        throw new Exception($"订单号格式不正确");
        //        return false;
        //    }
        //    string pattern2 = "[0-9]{10}";
        //    if (Regex.IsMatch(b, pattern2) == false)
        //    {
        //        throw new Exception($"手机号格式不正确");
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        /// <summary>
        /// cancel order
        /// </summary>
        /// <param name="orderId">id of the order which will be canceled</param> 
        public void RemoveOrder(string orderId)
        {
            //orderDict.Remove(orderId);

            using (var db = new OrderDB())
            {
                var order = db.Order.Include("details").SingleOrDefault(o => o.Id == orderId);
                db.OrderItem.RemoveRange(order.details);
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }

        public void Update(Order order)
        {
            using (var db = new OrderDB())
            {
                db.Order.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                order.details.ForEach(
                    item => db.Entry(item).State = EntityState.Modified);
                db.SaveChanges();
            }
        }

        public Order GetOrder(String Id)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("details").
                  SingleOrDefault(o => o.Id == Id);
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("details").ToList<Order>();
            }
        }

        public List<Order> QueryByCustormer(String custormer)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("details")
                  .Where(o => o.Customer.Equals(custormer)).ToList<Order>();
            }
        }

        public List<Order> QueryByGoods(String product)
        {
            using (var db = new OrderDB())
            {
                var query = db.Order.Include("details")
                  .Where(o => o.details.Where(
                    item => item.Name.Equals(product)).Count() > 0);
                return query.ToList<Order>();
            }
        }

        /// <summary>
        /// query all orders
        /// </summary>
        /// <returns>List<Order>:all the orders</returns> 

        public List<Order> QueryAllOrders()
        {
            return orderDict.Values.ToList();
        }

        /// <summary>
        /// query by orderId
        /// </summary>
        /// <param name="orderId">id of the order to find</param>
        /// <returns>List<Order></returns> 


        public Order GetById(string orderId)
        {
            if (orderDict.ContainsKey(orderId))
            {
                return orderDict[orderId];
            }
            return null;
        }

        /// <summary>
        /// query by goodsName
        /// </summary>
        /// <param name="goodsName">the name of goods in order's orderDetail</param>
        /// <returns></returns> 
        /// 

        public List<Order> QueryByGoodsName(string goodsName)
        {
            var query = orderDict.Values.Where(order =>
                    order.Details.Where(d => d.Goods.Name == goodsName)
                    .Count() > 0
                );
            return query.ToList();

        }

        /// <summary>
        /// query by customerName
        /// </summary>
        /// <param name="customerName">customer name</param>
        /// <returns></returns> 
        /// 

        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orderDict.Values
                .Where(order => order.Customer.Name == customerName);
            return query.ToList();
        }

        public List<Order> QueryByPrice(double price)
        {
            var query = orderDict.Values
                .Where(order => order.Amount > price);
            return query.ToList();
        }


        /// <summary>
        /// edit order's customer
        /// </summary>
        /// <param name="orderId"> id of the order whoes customer will be update</param>
        /// <param name="newCustomer">the new customer of the order which will be update</param> 
        /// 

        public void UpdateCustomer(string orderId, Customer newCustomer)
        {
            if (orderDict.ContainsKey(orderId))
            {
                orderDict[orderId].Customer = newCustomer;
            }
            else
            {
                throw new Exception($"order-{orderId} is not existed!");
            }
        }

        /// <summary>
        /// Store the order object to file orders.xml
        /// </summary>
        /// 

        //public string Export()
        //{
        //    DateTime time = System.DateTime.Now;
        //    string fileName = "orders_" + time.Year + "_" + time.Month
        //        + "_" + time.Day + "_" + time.Hour + "_" + time.Minute
        //        + "_" + time.Second + ".xml";
        //    Export(fileName);
        //    return fileName;
        //}

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, orderDict.Values.ToList());
            }
        }

        /// <summary>
        /// import the orders object from xml file in path
        /// return the order imported to service obj
        /// </summary>
        /// 

        public List<Order> Import(string path)
        {
            if (Path.GetExtension(path) != ".xml")
                throw new ArgumentException("It isn't a xml file!");
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            List<Order> result = new List<Order>();

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order =>
                {
                    if (!orderDict.Keys.Contains(order.Id))
                    {
                        orderDict[order.Id] = order;
                        result.Add(order);
                    }
                });
            }
            return result;
        }

        /*other edit function with write in the future.*/
    }
}
