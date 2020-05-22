using Microsoft.AspNetCore.Mvc;

namespace VendorOrderTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{id}/orders")]
    public ActionResult Index()
    {
      return View();
    }
  }
}