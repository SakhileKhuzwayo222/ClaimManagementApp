using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClaimManagementApp.Controllers
{
    public class LecturerController : Controller
    {
        // GET: Lecturer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Lecturer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lecturer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lecturer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lecturer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lecturer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lecturer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lecturer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
