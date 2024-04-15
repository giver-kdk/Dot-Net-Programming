using Microsoft.AspNetCore.Mvc;

namespace _06_ORM_App.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
