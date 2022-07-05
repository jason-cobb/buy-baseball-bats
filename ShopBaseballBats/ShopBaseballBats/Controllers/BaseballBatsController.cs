using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopBaseballBats.Data;
using ShopBaseballBats.Models;
using System.Diagnostics;

namespace ShopBaseballBats.Controllers
{
    public class BaseballBatsController : Controller
    {
        private readonly BaseballBatContext _context;
        public BaseballBatsController(BaseballBatContext context)
        {
            _context = context;
        }
        /*
        public IActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        */
        public IActionResult Index()
        {
            var model = _context.BaseballBats.ToList();
            return View(model);
        }
        /*possible use to use for saving data using bool is active elsewhere
          public IActionResult GetActive()
        {
            var model = _context.Customers.Where(e => IsActive).ToList();
            return View(model);
        }
        */
        //to get a specific customer vs a collection


        /*
        
        public IActionResult Details(string name)
        {
            var model = _context.Customers.FirstOrDefault(e => e.FullName == name);
            return View(model);
        }

        public IActionResult Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            var original = _context.Customers.FirstOrDefault(e => e.FirstName == name);
            if (original != null)
            {
                _context.Customers.Remove(original);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        */
    }


























    /*
    private BaseballBatsRepository _baseballBatsRepository = null;
    public BaseballBatsController()
    {
        _baseballBatsRepository = new BaseballBatsRepository();
    }
    public ActionResult Index()
    {
        var baseballBats = _baseballBatsRepository.GetBaseballBats();
        return View(baseballBats);
    }
    public ActionResult Detail(int? id)
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
    */
}






















/*using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ShopBaseballBats.Data;
using ShopBaseballBats.Models;
using System.Diagnostics;

namespace ShopBaseballBats.Controllers
{
    //[Route("api/[controller]")]
    public class BaseballBatsController : Controller


        private readonly BaseballBatContext _context; //BaseballBatsRepository _baseballBatsRepository = null;
    public BaseballBatsController(BaseballBatContext context)
    {
        _context = context;
        // _baseballBatsRepository = new BaseballBatsRepository();
    }
    public IActionResult Create()
    {
        var baseballBats = _baseballBatsRepository.GetBaseballBats();
        return View(baseballBats);
    }

    public ActionResult Index()
    {
        var baseballBats = _baseballBatsRepository.GetBaseballBats();
        return View(baseballBats);
    }
    public ActionResult Detail(int? id)
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