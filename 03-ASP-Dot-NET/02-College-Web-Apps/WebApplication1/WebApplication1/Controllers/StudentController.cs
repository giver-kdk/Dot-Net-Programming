using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to Student Page";
            return View();
        }
		public IActionResult Details(Student s)
        {
            // Sample student data (replace with logic to retrieve data from database etc.)
            if (s.Name != "")
            {
                return View(s);
            }
            else
            {
                var student = new Student()
                {
                    Id = 1,
                    Name = "Full Name",
                    Age = 21,
                    Email = "example@example.com"
                };
                return View(student);
            }
        }
        public IActionResult AddRecordForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRecordForm(Student s)
        {
            // Model Binding converts string form input (HTTP-POST) to 'Student s' object in this action method.
            // During that process, the data needs to fulfill the type and validation attribute of the model.
            // 'ModelState.IsValid' checks if conversion occurred by satisfying validation rules of model or not.
            if (ModelState.IsValid)
            {
                return View("Details", s);
            }
            else
            {
                Console.WriteLine("Model Binding Error!");
                return View(s);
            }
        }
    }
}