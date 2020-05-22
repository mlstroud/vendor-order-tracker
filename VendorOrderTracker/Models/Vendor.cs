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
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
      IDCount = 0;
    }

    public static List<Vendor> GetAllVendors()
    {
      return _instances;
    }

    public static Vendor FindVendor(int id)
    {
      foreach (Vendor vendor in _instances)
      {
        if (vendor.Id == id)
        {
          return vendor;
        }
      }

      return null;
    }
  }
}