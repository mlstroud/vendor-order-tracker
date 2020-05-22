using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
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
  }
}