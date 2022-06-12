using Microsoft.AspNetCore.Mvc;
using ShopBaseballBats.Models;
using System.Diagnostics;

namespace ShopBaseballBats.Controllers
{
    public class BaseballBatsController : Controller
    {
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
}