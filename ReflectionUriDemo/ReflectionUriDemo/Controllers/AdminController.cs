using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReflectionUriDemo.Models;
using ReflectionUriDemo.CustomModel;

namespace ReflectionUriDemo.Controllers
{
    [UserAuthenticationFilter]
    public class AdminController : Controller
    {
       static  Controller_Reflection_DBEntities3 databaseEntitties = new Controller_Reflection_DBEntities3();
        // GET: Admin
        public ActionResult Index()
        {
            return View(databaseEntitties.tb_Users.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            var username = databaseEntitties.tb_Users.Where(user => user.UserId == id).Select(user => user.UserName).FirstOrDefault();
            var userRoles = databaseEntitties.tb_UserMappedRoles.Where(user => user.userId == id).ToList();
            List<string> controllerList = new List<string>();
            foreach(var userRole in userRoles)
            {
                var controllers = databaseEntitties.tb_ControllerMappedRoles.Where(controller => controller.roleId == userRole.roleId).ToList();
                foreach(var controller in controllers)
                {
                    var actionResults = databaseEntitties.tb_Controller.Where(action => action.ControllerId == controller.ControllerId).Select(action => action.ControllerUrl).FirstOrDefault();
                    controllerList.Add(actionResults);
                }
            }
            UserControllers userController = new UserControllers();
            userController.UserName = username;
            userController.Controllers = controllerList;
            ViewData["userController"] = userController;
            return View(userController);
        }
        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var username = collection["UserName"].ToString();
                var password = collection["Passwod"].ToString();
                tb_Users user = new tb_Users();
                user.UserName = username;
                user.Passwod = password;
                databaseEntitties.tb_Users.Add(user);
                databaseEntitties.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            var  userRoles = databaseEntitties.tb_UserMappedRoles.Where(user => user.userId == id).Select(user => user.roleId).ToList();
            var roles= databaseEntitties.tb_Roles.Where(role => (userRoles.Contains(role.RoleID))).ToList();
            ViewData["roles"] = roles;
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                int roleId = Convert.ToInt32(collection["Roles"]);
                tb_UserMappedRoles userMappedRoles = new tb_UserMappedRoles();
                userMappedRoles.userId = id;
                userMappedRoles.roleId = roleId;
                databaseEntitties.tb_UserMappedRoles.Remove(userMappedRoles);
                databaseEntitties.SaveChanges();
                // TODO: Add delete logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult AddRole(int id)
        {
            var rolePresent = databaseEntitties.tb_UserMappedRoles.Where(user => user.userId == id).Select(user => user.roleId).ToList();
            var roles = databaseEntitties.tb_Roles.Where(role => !(rolePresent.Contains (role.RoleID ))).OrderBy(role=>role.RoleID).ToList();
            ViewData["Roles"] = roles;
            return View();
        }
        [HttpPost]
        public ActionResult AddRole(int id, FormCollection collection)
        {
            try
            {
                int roleId = Convert.ToInt32(collection["Roles"]);

                if (roleId != 0)
                {
                    tb_UserMappedRoles userMappedRoles = new tb_UserMappedRoles();
                    userMappedRoles.roleId = roleId;
                    userMappedRoles.userId = id;
                    databaseEntitties.tb_UserMappedRoles.Add(userMappedRoles);
                    databaseEntitties.SaveChanges();
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Select Role Name");
                return View();
            }
            catch(Exception e)
            {
                return View();
            }
        }
    }
}
