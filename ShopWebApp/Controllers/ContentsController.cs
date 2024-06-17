using Microsoft.AspNetCore.Mvc;

namespace ShopWebApp.Controllers
{
    public class ContentsController : Controller
    {
        public IActionResult Article()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Course()
        {
            return View();
        }
       
        public IActionResult Panel()
        {
            return View();
        }
        

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Teach()
        {
            return View();
        }
    }
}
