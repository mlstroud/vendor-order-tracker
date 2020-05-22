using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order>();
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Date { get; set; }
    private static int IDCount { get; set; }
    public int Id { get; set; }

    public Order(string title, string description, string price, string date)
    {
      IDCount++;
      Id = IDCount;
    }
  }
}