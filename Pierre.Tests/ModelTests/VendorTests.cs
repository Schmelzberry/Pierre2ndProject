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
        [TestMethod]
        public void GetAllVendors_ReturnsAllVendorObjects_VendorList()
        {  // arrange
          string vendorName01 = "Als Breakfast";
          string vendorName02 = "Suzie's Doozies";
          Vendor newVendor1 = new Vendor(vendorName01);
          Vendor newVendor2 = new Vendor(vendorName02);
          List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
          // act
          List<Vendor> result = Vendor.GetAllVendors();
          // assert
          CollectionAssert.AreEqual(newList, result);
        }
         [TestMethod]
        public void FindVendors_ReturnsProperVendor_Vendor()
        {  // arrange
          string vendorName01 = "Als Breakfast";
          string vendorName02 = "Suzie's Doozies";
          Vendor newVendor1 = new Vendor(vendorName01);
          Vendor newVendor2 = new Vendor(vendorName02);
          // act
          Vendor result = Vendor.Find(2);
          // assert
          Assert.AreEqual(newVendor2, result);
        }

    }
}
