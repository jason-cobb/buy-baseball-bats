using Microsoft.AspNetCore.Mvc;
using ShopBaseballBats.Data;
using ShopBaseballBats.Models;
using System.Diagnostics;

namespace ShopBaseballBats.Controllers
{
    //[Route("api/[controller]")]
    public class BaseballBatsController : Controller
    {

        // private readonly IBaseballBatsRepository _baseballBatsRepository = null;
        public BaseballBatsController()
        {
        }
    }
}
       // [HttpGet]
      /*  public async Task<IActionResult> Index()
        {
            try
            {
                var baseballBats = await _baseballBatsRepository.GetBaseballBatsAsync();
                return View(baseballBats);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,"Database Failure");
            }
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