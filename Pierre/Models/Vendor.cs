using System.Collections.Generic;

namespace Pierre.Models 
{
  public class Vendor
  {
    private static List <Vendor> Instances = new List<Vendor>{ };
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders {get; set; }
    public string Description { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      Description = vendorName;
      Instances.Add(this);
      Id = Instances.Count;
      Orders = new List<Order>{ };
    }

    public static void ClearVendors()
    {
      Instances.Clear();
    }
    public static List<Vendor> GetAllVendors()
    {
      return Instances;
    }

    public static Vendor Find(int searchId)
    {
      return Instances[searchId-1];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}