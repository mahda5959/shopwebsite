using Microsoft.AspNetCore.Mvc;

namespace ShopWebApp.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
