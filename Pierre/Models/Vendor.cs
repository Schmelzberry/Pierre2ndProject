using System.Collections.Generic;

namespace Pierre.Models 
{
  public class Vendor
  {
    private static List <Vendor> Instances = new List<Vendor>{ };
    public string Name { get; set; }
    public int Id { get; }
    List<Order> Order {get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      Instances.Add(this);
      Id = Instances.Count;
      Order = new List<Order>{ };
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
  }
}