using ReflectionUriDemo.CustomModel;
using ReflectionUriDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReflectionUriDemo.Controllers
{
    [UserAuthenticationFilter]
    public class NAController : Controller
    {
        static Controller_Reflection_DBEntities3 databaseEntitties = new Controller_Reflection_DBEntities3();
        // GET: NA
        public ActionResult Index()
        {
            var sessionOfUser =(tb_Users) Session["User"];
            return View(databaseEntitties.tb_Users.Where(user=>user.UserId==sessionOfUser.UserId).ToList());
        }

        // GET: NA/Details/5
        public ActionResult Details(int id)
        {
            var username = databaseEntitties.tb_Users.Where(user => user.UserId == id).Select(user => user.UserName).FirstOrDefault();
            var userRoles = databaseEntitties.tb_UserMappedRoles.Where(user => user.userId == id).ToList();
            List<string> controllerList = new List<string>();
            foreach (var userRole in userRoles)
            {
                var controllers = databaseEntitties.tb_ControllerMappedRoles.Where(controller => controller.roleId == userRole.roleId).ToList();
                foreach (var controller in controllers)
                {
                    var actionResults = databaseEntitties.tb_Controller.Where(action => action.ControllerId == controller.ControllerId).Select(action => action.ControllerUrl).FirstOrDefault();
                    controllerList.Add(actionResults);
                }
            }
            UserControllers userController = new UserControllers();
            userController.UserName = username;
            userController.Controllers = controllerList;
            ViewData["userController"] = userController;
            return View();
        }

        // GET: NA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NA/Create
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

        // GET: NA/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NA/Edit/5
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

        // GET: NA/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NA/Delete/5
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
