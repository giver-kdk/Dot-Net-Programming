using _06_ORM_App.Models;
using _06_ORM_App.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _06_ORM_App.Controllers
{
    public class ProductController : Controller
    {
        // ****** Dependency Injection of ProductRepo ******
        ProductRepo _repo = null;
        public ProductController(ProductRepo repo)
        {
            _repo = repo;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            // ******  ******
            return View(_repo.GetSingleRecord(id));
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product prod)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _repo.AddRecord(prod);
                    return Content("Record has been inserted");
                }
                else
                {
                    return View(prod);
                }
            }
            catch(Exception ex)
            {
                return Content("Something went wrong when inserting record: " + ex.Message);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product prod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.UpdateRecord(prod);
                    return Content("Record has been updated");
                }
                else
                {
                    return View(prod);
                }
            }
            catch (Exception ex)
            {
                return Content("Something went wrong when updating record: " + ex.Message);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Product prod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.DeleteRecord(prod);
                    return Content("Record has been Deleted");
                }
                else
                {
                    return View(prod);
                }
            }
            catch (Exception ex)
            {
                return Content("Something went wrong when deleting record: " + ex.Message);
            }
        }
    }
}
