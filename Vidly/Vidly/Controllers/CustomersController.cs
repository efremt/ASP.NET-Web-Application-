using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> listCustomer()
        {
            List<string> s = new List<string>()
            {
                "efrem","Teferawork","Beyene"
            };

            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Efrem"
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Hanan"
            };
            List<Customer> customers = new List<Customer>()
            {
                customer1,
                customer2
            };

            return customers;
        }
        // GET: Customers
        public ActionResult DisplayCustomers(int? id)
        {
            List<Customer> customers = new List<Customer>();

            customers= listCustomer();
            

            if (id == null) {
                return View(customers);
            }
            else
            {
                foreach(Customer cust in customers)
                {
                    if(cust.Id==id)
                    {
                         return RedirectToAction("DisplayCustomer", "Customers", new { Id = id});
                    }
                }
                return HttpNotFound();
            }
        }
        public ActionResult DisplayCustomer(int Id)
        {
            List<Customer> customers = new List<Customer>();

            customers = listCustomer();

            foreach (Customer cust in customers)
            {
                if (cust.Id == Id)
                {
                    return View(cust);
                }
            }
            return HttpNotFound();

        }
    }
}
