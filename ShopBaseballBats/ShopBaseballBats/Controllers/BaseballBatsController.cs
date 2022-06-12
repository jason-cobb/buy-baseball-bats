using Microsoft.AspNetCore.Mvc;
using ShopBaseballBats.Models;
using System.Diagnostics;

namespace ShopBaseballBats.Controllers
{
    public class BaseballBatsController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.BatBrand = "Louisville Slugger";
            ViewBag.BatLength = 32;
            ViewBag.BatWeight = 22;
            ViewBag.BatPrice = 99;
            ViewBag.Description = "<p> Louisville is home of the slugger.</p>";
            ViewBag.BatModels = new string[]
            {
                "Meta 22",
                "LXT 21",
                "LXT 22",
                "Xeno 22",
                "Xeno 21"
            };

            {
                return View();
            }

        }
    }
}
      /*  
        private readonly ILogger<BaseballBatsController> _logger;

        public BaseballBatsController(ILogger<BaseballBatsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}*/