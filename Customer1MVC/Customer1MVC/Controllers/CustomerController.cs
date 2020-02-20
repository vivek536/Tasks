using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Customer1MVC.Models;
namespace Customer1MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer/Index
        public ActionResult Index()
        {
            using (Customer1Entities ce = new Customer1Entities())
            {
                return View(ce.Customers.ToList());
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (Customer1Entities ce = new Customer1Entities())
            {
                return View(ce.Customers.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer c)
        {
            try
            {
                // TODO: Add insert logic here
                using (Customer1Entities ce = new Customer1Entities())
                {
                    ce.Customers.Add(c);
                    ce.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (Customer1Entities ce = new Customer1Entities())
            {
                return View(ce.Customers.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer c)
        {
            try
            {
                // TODO: Add update logic here
                using (Customer1Entities ce = new Customer1Entities())
                {
                    ce.Entry(c).State = EntityState.Modified;
                    ce.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (Customer1Entities ce = new Customer1Entities())
            {
                return View(ce.Customers.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                // TODO: Add delete logic here
                using (Customer1Entities ce = new Customer1Entities())
                {
                    customer = ce.Customers.Where(x => x.Id == id).FirstOrDefault();
                    ce.Customers.Remove(customer);
                    ce.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

}
