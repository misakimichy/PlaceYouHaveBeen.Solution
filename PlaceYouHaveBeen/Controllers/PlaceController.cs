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
                return View();
            }
    }
}