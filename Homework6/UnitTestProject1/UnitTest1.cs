using Microsoft.VisualStudio.TestTools.UnitTesting;
using program1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            OrderService orderService = new OrderService();
            Order order1= new Order("a", "a", "a", 1);
            orderService.Add(order1);
            Assert.IsTrue(orderService.list.Contains(order1) == true);
        }
        [TestMethod]
        public void TestDelete()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("1", "1", "1", 1);
            orderService.Delete(order1);
            Assert.IsTrue(orderService.list.Contains(order1) == false);
        }
        [TestMethod]
        public void TestChange()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("2", "2", "2", 2);
            Order order2 = new Order("b", "b", "b", 1);
            orderService.Change(order1,order2);
            Assert.IsTrue(orderService.list.Contains(order1) == false&& orderService.list.Contains(order2) == true);
        }
        [TestMethod]
        public void TestInquiry()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("4", "4", "4", 4);
            orderService.Add(order1);
            orderService.Inquiry(1, "4");
            orderService.Inquiry(2, "4");
            orderService.Inquiry(3, "4");
            orderService.Inquiry(4, "4");
            Assert.AreEqual(order1, orderService.order1);
            Assert.AreEqual(order1, orderService.order2);
            Assert.AreEqual(order1,orderService.order3);
            Assert.AreEqual(order1,orderService.order4);
        }
    }
}
