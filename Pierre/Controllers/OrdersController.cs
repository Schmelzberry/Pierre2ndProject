using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;

namespace Pierre.Controllers
{
    public class OrdersController : Controller
    {
        // [HttpGet("/orders")]
        // public ActionResult Index()
        // {

        //   List<Order> allOrders = Order.GetAllOrders();
        //   return View(allOrders);
        // }

        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
          Vendor vendor = Vendor.Find(vendorId);
            return View(vendor);
        }

        
        [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Order foundOrder = Order.Find(orderId);
            Vendor vendor = Vendor.Find(vendorId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("order", foundOrder);
            model.Add("vendor", vendor);
            return View(model);
        }
    }
}
