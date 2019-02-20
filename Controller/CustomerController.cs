using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videly.Models;
using Videly.ViewModel;

namespace Videly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult CustomerDetails(int id)
        {


            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);

           
        }

        public ActionResult ListOfCustomers()
        {
            var customer = _context.Customers.ToList();

              var viewModel = new RandomViewModel { Customer = customer};
             return View(viewModel);
                   }
    }
}
