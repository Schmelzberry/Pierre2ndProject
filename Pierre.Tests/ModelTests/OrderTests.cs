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

      Order testOrder = new Order();
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
  }
}