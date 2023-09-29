using Microsoft.AspNetCore.Mvc;
using Pierre.Models;

namespace Pierre.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/order")]
    public ActionResult Create(string title, string description, string date)
    {
      Order myOrder = new Order(title, description, date);
      myOrder.Description = description;
      return View("Index");
    }


  }
}
