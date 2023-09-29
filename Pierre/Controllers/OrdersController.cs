using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;

namespace Pierre.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {

      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string title, string description, string date)
    {
      Order myOrder = new Order(title, description, date);
      return RedirectToAction("Index");
    }


  }
}
