using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Places.Models;

namespace  Places.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}