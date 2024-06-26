using coreWebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication1.Controllers
{
    public class CustomerController : Controller
    {

        public static List<Customer> customers = new List<Customer>()
        {
            new Customer(){Id = 1, Name = "KHALIL", Amount=12000},
            new Customer(){Id = 2, Name = "ABDO", Amount=12000},
            new Customer(){Id = 3, Name = "DDDD", Amount=12000},
            new Customer(){Id = 4, Name = "CCCC", Amount=12000}

        };
        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomersCounts = customers.Count;
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        [Route("/sample/Message")]
        public IActionResult Message()
        { 
            return View();
        }
    }
}
 