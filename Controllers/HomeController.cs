using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Models;

namespace RestaurantAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var model = new Restaurant { Id = 1 , Name="Pizza"};

            return View(model);
            
        }
    }
}