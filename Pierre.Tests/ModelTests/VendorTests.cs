using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
      public void Dispose()
      {
        Vendor.ClearVendors();
      }
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("test vendor");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetNameVendor_ReturnsVendorName_String()
        {
            //Arrange
            string vendorName = "Test Vendor";
            Vendor newVendor = new Vendor(vendorName);

            //Act
            string result = newVendor.Name;

            //Assert
            Assert.AreEqual(vendorName, result);
        }

        [TestMethod]
        public void GetVendorId_ReturnsVendorId_Int()
        {
            //Arrange
            string vendorName = "Test Vendor";
            Vendor newVendor = new Vendor(vendorName);

            //Act
            int result = newVendor.Id;

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
