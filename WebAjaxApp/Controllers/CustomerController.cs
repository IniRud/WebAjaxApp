using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAjaxApp.Models;

namespace WebAjaxApp.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();
        public CustomerController()
        {
            customers.Add(new CustomerModel { Id = 0, Name = "Ini", Age = 35});
            customers.Add(new CustomerModel { Id = 1, Name = "Itoro", Age = 31 });
            customers.Add(new CustomerModel { Id = 2, Name = "Junior", Age = 28 });
            customers.Add(new CustomerModel { Id = 3, Name = "Patric", Age = 25 });
            customers.Add(new CustomerModel { Id = 4, Name = "Dominic", Age = 15 });
            customers.Add(new CustomerModel { Id = 5, Name = "Rita", Age = 25 });
        }
        public IActionResult Index()
        {

            return View(customers);
        }
    }
}
