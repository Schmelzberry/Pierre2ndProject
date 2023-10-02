using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Pierre.Models;

namespace Pierre.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAllVendors();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName)
        {
          Vendor newVendor = new Vendor(vendorName);

          return RedirectToAction("Index");
        }
        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
          Dictionary<string, object> vendorModel = new Dictionary<string,object>();
          Vendor selectedVendor = Vendor.Find(id);
          List<Order> vendorOrders = selectedVendor.Orders;
          vendorModel.Add("vendor", selectedVendor);
          vendorModel.Add("orders", vendorOrders);
          return View(vendorModel);
        }
        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId,string title, string description, string date)
        {
          Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(vendorId);
            Order myOrder = new Order(title, description, date);
            selectedVendor.AddOrder(myOrder);
            List<Order> vendorOrders = selectedVendor.Orders;
            model.Add("orders", vendorOrders);
            model.Add("vendor", selectedVendor);
            return View("Show", model);
          
        }
    }
}
