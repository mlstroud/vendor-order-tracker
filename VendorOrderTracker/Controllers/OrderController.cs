using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{id}/orders")]
    public ActionResult Index(int id)
    {
      Vendor vendor = Vendor.FindVendor(id);
      List<Order> orders = vendor.Orders;
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", vendor);
      model.Add("orders", orders);
      return View(model);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(int id, string title, string description, string price, string date)
    {
      Order order = new Order(title, description, price, date);
      Vendor vendor = Vendor.FindVendor(id);
      vendor.AddOrder(order);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor vendor = Vendor.FindVendor(id);
      return View(vendor);
    }
  }
}