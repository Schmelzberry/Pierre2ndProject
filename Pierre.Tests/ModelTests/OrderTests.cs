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

      [TestMethod]
    public void CalculatePrice_CalculatesPriceForBagels_Int()
    {
      //arrange
      Order testOrder = new Order("Als Cafe", "bagels", "Dec 1st");
      //act
      testOrder.CalculatePrice();
      int result = 10;
      string resultMessage = "Bagels coming right up!";
      //assert
      Assert.AreEqual(result, testOrder.CalculatePrice());
      Assert.AreEqual(resultMessage, testOrder.DisplayMessage);
      
    }

     [TestMethod]
    public void CalculatePrice_CalculatesPriceForDonuts_Int()
    {
      //arrange
      Order testOrder = new Order("Als Cafe", "donuts", "Dec 1st");
      //act
      testOrder.CalculatePrice();
      int result = 15;
      string resultMessage = "Donuts? You must be nuts!";
      //assert
      Assert.AreEqual(result, testOrder.CalculatePrice());
      Assert.AreEqual(resultMessage, testOrder.DisplayMessage);
      
    }

       [TestMethod]
    public void CalculatePrice_CalculatesPriceForInvalidEntry_Int()
    {
      //arrange
      Order testOrder = new Order("Als Cafe", "croissants", "Dec 1st");
      
      //act
      testOrder.CalculatePrice();
      int resultPrice = 0;
      string resultMessage = "We don't have any of those, try again if you'd like to order!";
      //assert
      Assert.AreEqual(resultPrice, testOrder.CalculatePrice());
      Assert.AreEqual(resultMessage, testOrder.DisplayMessage);
      
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetter_Int()
    {
      //arrange
      Order newOrder = new Order("Als Cafe", "bagels", "Dec 1st");

      //act
      int result = newOrder.Id;

      //assert

      Assert.AreEqual(1, result);
      
    }


  }
}