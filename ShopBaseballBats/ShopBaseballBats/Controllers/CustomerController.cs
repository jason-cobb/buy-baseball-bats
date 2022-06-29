using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ShopBaseballBats.Models;

namespace ShopBaseballBats.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerDbContext _context;
        public CustomerController(CustomerDbContext context)
        {
            _context=context;
        }
        public IActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Index ()
        {
            var model = _context.Customers.ToList();
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
            var original = _context.Customers.FirstOrDefault(e => e.FullName == name);
            if(original != null)
            {
                _context.Customers.Remove(original);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        /*
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }

}
