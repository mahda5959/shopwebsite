using Microsoft.AspNetCore.Mvc;

namespace ShopWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult Forget()
        {
            return View();
        }
    }

}
