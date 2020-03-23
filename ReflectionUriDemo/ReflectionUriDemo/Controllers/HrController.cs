using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReflectionUriDemo.Controllers
{
    public class HrController : Controller
    {
        // GET: Hr
        public ActionResult Index()
        {
            return View();
        }

        // GET: Hr/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hr/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hr/Create
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

        // GET: Hr/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hr/Edit/5
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

        // GET: Hr/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hr/Delete/5
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
