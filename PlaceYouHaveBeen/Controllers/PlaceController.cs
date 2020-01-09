using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Models;

namespace Places.Controllers
{
    public class placeController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allItems = Place.GetAll();
            return View(allItems);
        }

        [HttpGet("places/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Create(string city, string country)
        {
            Place myPlace = new Place(city, country);
            return RedirectToAction("Index");
        }
    }
}