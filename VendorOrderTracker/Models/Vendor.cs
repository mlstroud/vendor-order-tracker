using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor>();
    public string Name { get; set; }
    public string Description { get; set; }
    private static int IDCount { get; set; }
    public int Id { get; set; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      IDCount++;
      Id = IDCount;
    }
  }
}