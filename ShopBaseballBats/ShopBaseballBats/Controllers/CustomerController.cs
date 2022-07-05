using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopBaseballBats.Data;
using ShopBaseballBats.Models;
using System.Collections.Generic;


namespace ShopBaseballBats.Controllers
{
    public class CustomerController : Controller
    {
        private readonly BaseballBatContext _context;
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

        public IActionResult Index()
        {
            var model = _context.Customers.ToList();
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
    }


}
