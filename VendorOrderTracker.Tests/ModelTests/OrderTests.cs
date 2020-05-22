using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", "test", "test");

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesUniqueIdForInstances_Int()
    {
      Order newOrder1 = new Order("test", "test", "test", "test");
      Order newOrder2 = new Order("test", "test", "test", "test");
      Order newOrder3 = new Order("test", "test", "test", "test");

      int result = newOrder3.Id;

      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void OrderConstructor_AddsOrderToInstances_OrderList()
    {
      Order newOrder1 = new Order("test", "test", "test", "test");
      Order newOrder2 = new Order("test", "test", "test", "test");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAllOrders();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "Donut Order #1";
      Order newOrder = new Order(title, "test", "test", "test");

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string description = "100 Danish and 50 Baguettes";
      Order newOrder = new Order("test", description, "test", "test");

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }
  }
}