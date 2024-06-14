using Microsoft.AspNetCore.Mvc;

namespace ShopWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
