using Microsoft.AspNetCore.Mvc;
using ShopBaseballBats.Data;
using ShopBaseballBats.Models;

namespace ShopBaseballBats.Controllers
{
    public class CustomerController : Controller
    {
        private readonly BaseballBatContext db = new BaseballBatContext();
        //GET: Customer

        public ActionResult Index()
        {
            var customers = from e in db.Customers
                            orderby e.CustomerId
                            select e;
            return View(customers);
           // var model = _context.Customers.ToList();
            //return View(model);
        }
        //GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        //GET: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //GET Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = db.Customers.Single(m => m.CustomerId == id);
            return View(customer);
        }

        //POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var customer = db.Customers.Single(m => m.CustomerId == id);
                if (TryUpdateModel(customer))
                {
                    //ToDo: - database code
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(customer);
            }
            catch
            {
                return View();
            }
        }

        private bool TryUpdateModel(Customer customer)
        {
            throw new NotImplementedException();
        }

        /*





        public CustomerController ( BaseballBatContext context )
        {
            _context = context;
        }
        public IActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        
        /*possible use to use for saving data using bool is active elsewhere
          public IActionResult GetActive()
        {
            var model = _context.Customers.Where(e => IsActive).ToList();
            return View(model);
        }
        */
        //to get a specific customer vs a collection

        public IActionResult Index()
        {
            ViewData["Title"]= "Customers";
            var model = _context.Customers.ToList();
            return View(model);
        }




        /*
        public IActionResult Details(string name)
        {
            var model = _context.Customers.FirstOrDefault(e=> e.FullName == name);
            return View(model);
        }

        public  IActionResult Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            var original = _context.Customers.FirstOrDefault(e => e.FirstName == name);
            if(original != null)
            {
                _context.Customers.Remove(original);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        */
    }


}
