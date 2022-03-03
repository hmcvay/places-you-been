using Microsoft.AspNetCore.Mvc;
using PlacesYouBeen.Models;
using System.Collections.Generic;

namespace PlaceYouBeen.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index(){
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces); //whatever you pass into view IS model
    }

    [HttpGet("/places/new")]
    public ActionResult New() {
      return View();
    }
    [HttpPost("/places")]
    public ActionResult Create(string cityName) {
      Place newPlace = new Place(cityName);
      return RedirectToAction("Index");
    }
  }
}