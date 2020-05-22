using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string name = "test";
      string description = "test";
      Vendor newVendor = new Vendor(name, description);

      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_CreatesUniqueIdForInstances_Int()
    {
      Vendor newVendor1 = new Vendor("test", "test");
      Vendor newVendor2 = new Vendor("test", "test");
      Vendor newVendor3 = new Vendor("test", "test");

      int result = newVendor2.Id;

      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void VendorConstructor_AddsVendorToInstances_VendorList()
    {
      Vendor newVendor1 = new Vendor("test", "test");
      Vendor newVendor2 = new Vendor("test", "test");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAllVendors();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string name = "Pierre's Bakery";
      string description = "test";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsVendorDescription_String()
    {
      string name = "test";
      string description = "Local bread and pastry shop.";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }
  }
}