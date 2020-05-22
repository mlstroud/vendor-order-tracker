using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendors = Vendor.GetAllVendors();
      return View(vendors);
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor vendor = new Vendor(name, description);
      return RedirectToAction("Index", "Home");
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
      Vendor vendor = Vendor.FindVendor(id);
      List<Order> orders = vendor.Orders;
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", vendor);
      model.Add("orders", orders);

      return View(model);
    }
  }
}