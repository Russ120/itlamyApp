using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using itlamyApp.Web.Models;

namespace itlamyApp.Web.Controllers
{
    public class InstructorController : Controller
    {
        // GET: InstructorController
        public ActionResult Index()
        {
            List<InstructorModel> instructor = new List<InstructorModel>()
            {
                new InstructorModel()
                {
                    Id = 1,
                    HireDate = System.DateTime.Now,
                    FirstName = "Melquisedec",
                    LastName = "Mateo"
                },
                new InstructorModel()
                {
                    Id = 2,
                    HireDate = System.DateTime.Now,
                    FirstName = "Ricardo",
                    LastName = "Acosta"

                },
                new InstructorModel()
                {
                    Id = 3,
                    HireDate = System.DateTime.Now,
                    FirstName = "Juan",
                    LastName = "Restituyo"

                }
            };
            return View(instructor);
        }

        // GET: InstructorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InstructorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InstructorController/Create
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

        // GET: InstructorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InstructorController/Edit/5
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

        // GET: InstructorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InstructorController/Delete/5
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
