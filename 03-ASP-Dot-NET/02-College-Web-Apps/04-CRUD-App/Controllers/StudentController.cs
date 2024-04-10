using _04_CRUD_App.Controllers.Repository;
using _04_CRUD_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _04_CRUD_App.Controllers
{
    public class StudentController : Controller
    {
        public StudentRepo _studentRepo = new StudentRepo();
        // Dependency Injection
        //public StudentController(StudentRepo studentRepo) // Inject StudentRepo in constructor
        //{
        //    _studentRepo = studentRepo;
        //}
        // GET: StudentController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display()
        {
            List<Student>? stds = _studentRepo.GetAllRecord();
            return View(stds);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}


