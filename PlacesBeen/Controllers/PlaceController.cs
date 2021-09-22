using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;

namespace PlacesBeen.Controllers
{
  public class PlaceController : Controller
  {

    [HttpGet("/place")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/place/new")]
    public ActionResult New()
    {
      return View();
    }

    // [HttpGet("/place/new2")]

    // public ActionResult New2()
    // {
    //   return View();
    // }

    [HttpPost("/place")]
    public ActionResult Create(string cityName, string stayTime)
    {
      Place myPlace = new Place(cityName, stayTime);
      return RedirectToAction("Index");
    }

    // [HttpPost("/place")]
    // public ActionResult Create2(string cityName, string stayTime)
    // {
    //   Place myPlace = new Place(cityName, stayTime);
    //   return RedirectToAction("Index");
    // }

    [HttpPost("/place/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

  }
}