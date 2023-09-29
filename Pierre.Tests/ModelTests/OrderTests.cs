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
        public void CreateId_OrdersInstantiateWithAnIdAndGetter_Int()
        {
            //arrange
            string title = "Als Cafe";
            string description = "Bagels";
            string date = "Dec 1st";
            Order newOrderWithId = new Order(title, description, date);

            //act
            int result = newOrderWithId.Id;

            //assert

            Assert.AreEqual(newOrderWithId.Id, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectOrder_Order()
        {
            //Arrange
            string title1 = "Als Cafe";
            string description1 = "Bagels";
            string date1 = "Dec 1st";
            string title2 = "Janes Coffee";
            string description2 = "Donuts";
            string date2 = "Nov 21st";
            Order newOrderId0 = new Order(title1, description1, date1);
            Order newOrderId1 = new Order(title2, description2, date2);

            //Act
            Order result = Order.Find(1);
            
            //Assert
            Assert.AreEqual(newOrderId0.Title, result.Title);
        }
    }
}
