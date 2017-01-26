using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer {Name = "John Lennon", Id = 1},
                new Customer {Name = "Marry Williams", Id = 2}
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };


            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer {Name = "John Lennon", Id = 1},
                new Customer {Name = "Marry Williams", Id = 2}
            };

            var customer = customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}