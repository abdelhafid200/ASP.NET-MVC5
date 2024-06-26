using coreWebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication1.Controllers
{
    public class DemoController : Controller
    {

        public static List<Customer> customers = new List<Customer>()
        {
            new Customer() {Id = 1, Name = "AB", Amount = 2123},
            new Customer() {Id = 2, Name = "ABC", Amount = 2123},
            new Customer() {Id = 3, Name = "ABD", Amount = 2123},
            new Customer() {Id = 4, Name = "ABT", Amount = 2123},
        };
        

        public IActionResult Index()
        {
            ViewBag.Message = "Customers Management";
            ViewBag.CustomerCounts = customers.Count();
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Message"] = "Customers Management";
            ViewData["CustomerCounts"] = customers.Count();
            ViewData["CustomerList"] = customers;
            return View();
        }


        public IActionResult Methode1()
        {
            TempData["Message"] = "Customers Management";
            TempData["CustomerCounts"] = customers.Count();
            TempData["CustomerList"] = customers;
            return View();
        }

        public IActionResult Login()
        {
            HttpContext.Session.SetString("username", "Khalil");
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            ViewBag.Username = HttpContext.Session.GetString("username"); 
            return View(); 
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Username");
            return RedirectToAction("Index");
        }
    }
}
