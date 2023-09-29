using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;

// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// MSTest method name convention

namespace Pierre.Tests
{
  [TestClass]
  public class PierreTests
  {
    
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {

      Order testOrder = new Order("Als Cafe", "bagels", "Dec 1st");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrderWithProperties_Order()
    {

      Order testOrder = new Order("Als Cafe", "bagels", "Dec 1st");
      Assert.AreEqual("Als Cafe", testOrder.Title);
      Assert.AreEqual("bagels", testOrder.Description);
      Assert.AreEqual("Dec 1st", testOrder.Date);
    }



  }
}