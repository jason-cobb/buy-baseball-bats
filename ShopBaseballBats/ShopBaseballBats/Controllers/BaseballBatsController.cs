using Microsoft.AspNetCore.Mvc;
using ShopBaseballBats.Models;
using System.Diagnostics;

namespace ShopBaseballBats.Controllers
{
    public class BaseballBatsController : Controller
    {
        public ActionResult Detail()
        {
            var baseballBats = new BaseballBats()
            {
                BatBrand = "Louisville Slugger",
                DescriptionHtml = "<p>Swing for the fences.</p>",
                BatModels = new BatModel[]
                    {
                       
                        new BatModel() {Name = "Meta", Length = 33, Weight = 22},
                         new BatModel() {Name = "Meta", Length = 32, Weight = 22},
                         new BatModel() {Name = "LXT", Length = 33, Weight = 22},
                        new BatModel() {Name = "LXT", Length = 32, Weight = 22},
                        new BatModel() {Name = "Xeno", Length = 33, Weight = 22},
                         new BatModel() {Name = "Xeno", Length = 32, Weight = 22},

                    }
            };
           
            return View(baseballBats);

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