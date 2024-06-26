using coreWebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }

        [HttpPost]
       public IActionResult LoginPost(String username, String password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();

        }


        public IActionResult StronglyTypedLogin()
        {
            return View();
        }

        public IActionResult SuccessPost(LoginViewModel login)
        {

            if (login.username != null && login.password != null)
            {
                if (login.username.Equals("admin") && login.password.Equals("khalil"))
                {
                    ViewBag.Message = "you are successfuly logged in";
                        return View();
                }
                else 
                {
                    ViewBag.Message = "your login is failed";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "plaise try to set all the inputs";
                return View();
            }

        }

        public IActionResult UserDetaills() 
        {
            var user = new LoginViewModel() { username = "khalil", password = "121344" };
            return View(user);
        }


        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {
                new LoginViewModel() {username = "khalil", password = "123434"},
                new LoginViewModel() { username = "khalil", password = "123434"},

            };
            return View(users);

        }

        public IActionResult GetAccount()
        {
            return View();
        }

        public IActionResult PostAccount(Account account)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            return RedirectToAction("GetAccount");
        }

    }
}
