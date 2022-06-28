using Microsoft.AspNetCore.Mvc;
using ShopBaseballBats.Data;
using ShopBaseballBats.Models;
using System.Diagnostics;

namespace ShopBaseballBats.Controllers
{
    public class BaseballBatsController : Controller
    {
        private BaseballBatsRepository _baseballBatsRepository = null;
        public BaseballBatsController()
        {
            _baseballBatsRepository = new BaseballBatsRepository();
        }
        public IActionResult Index()
        {
            var baseballBats = _baseballBatsRepository.GetBaseballBats();
            return View(baseballBats);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var baseballBats = _baseballBatsRepository.GetBaseballBats(id.Value);
           
            return View(baseballBats);

        }
        public IActionResult Privacy()
        {
            return View();
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

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}*/