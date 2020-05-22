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
      List<Order> orders;
      Vendor vendor = Vendor.FindVendor(id);
      if (vendor.Orders != null)
      {
        orders = vendor.Orders;
      }
      else
      {
        orders = new List<Order>();
      }
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", vendor);
      model.Add("orders", orders);
      return View(model);
    }

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor vendor = Vendor.FindVendor(id);
      return View(vendor);
    }
  }
}