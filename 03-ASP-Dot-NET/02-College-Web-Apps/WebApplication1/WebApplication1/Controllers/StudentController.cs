using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Student;

namespace Student.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            // Sample student data (replace with logic to retrieve data from database etc.)
            var student = new Student()
            {
                Id = 1,
                Name = "John Doe",
                Age = 21,
                Email = "john.doe@example.com"
            };
            return View(student);
        }
        
        public IActionResult Details(Student s)
        {
            return View();
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
            if(ModelState.IsValid)
            {
                return View("Details", s);
            }
            else return View(s);
        }
    }
