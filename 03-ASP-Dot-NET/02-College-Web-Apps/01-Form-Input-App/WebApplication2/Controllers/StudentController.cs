using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Student/Submit
        [HttpPost]
        public IActionResult Submit(Student userInfo)
        {
            return RedirectToAction("Detail", userInfo);
        }

        // GET: /Student/Detail
        public IActionResult Detail(Student userInfo)
        {
            return View(userInfo);
        }
    }
}
