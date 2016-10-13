using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColumnSum;
using System.Collections.Generic;
using ExpectedObjects;
using System.Linq;

namespace ColumnSumTest
{
    [TestClass]
    public class OrdersTest
    {
        [TestMethod]
        public void Orders_Of_3_Row_Sum_By_Cost_Should_Be_6_15_24_21()
        {
            var orders = new Orders().Get();
            List<int> expected = new List<int> { 6, 15, 24, 21 };
            List<int> actual = orders.GetSum(x => x.Cost, 3).ToList();

            CollectionAssert.AreEqual(expected, actual);
            //expected.ToExpectedObject().ShouldEqual(actual);
            //Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Orders_Of_4_Row_Sum_By_Revenue_Should_Be_50_66_60()
        {
            var orders = new Orders().Get();
            List<int> expected = new List<int> { 50, 66, 60 };
            List<int> actual = orders.GetSum(x => x.Revenue, 4).ToList();

            CollectionAssert.AreEqual(expected, actual);
            //expected.ToExpectedObject().ShouldEqual(actual);
            //Assert.AreEqual(expected, actual);
        }

    }


    public class Orders
    {

        public IEnumerable<Order> Get()
        {
            List<Order> orderList = new List<Order>() {
                new Order() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21, Other = 1 },
                new Order() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22, Other = 1 },
                new Order() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23, Other = 1 },
                new Order() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24, Other = "" },
                new Order() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25, Other = 1},
                new Order() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26, Other = "test" },
                new Order() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27, Other = 1 },
                new Order() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28, Other = 1 },
                new Order() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29, Other = 0 },
                new Order() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30, Other = 1 },
                new Order() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31, Other = 1 }
        };


            return orderList;
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
        public object Other { get; set; }
    }
}
