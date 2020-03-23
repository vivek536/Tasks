using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReflectionUriDemo.Models;
namespace ReflectionUriDemo.Controllers
{
    public class UserController : Controller
    {
        static Controller_Reflection_DBEntities3 databaseEntitties = new Controller_Reflection_DBEntities3();
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var username = collection["UserName"];
                var password = collection["Passwod"];
                var userPresent = databaseEntitties.tb_Users.Where(user => user.UserName == username && user.Passwod == password).FirstOrDefault();
                if (userPresent != null)
                {
                    Session["User"] = userPresent;
                    var rolesForUser = databaseEntitties.tb_UserMappedRoles.Where(role => role.userId == userPresent.UserId).Select(role=>role.roleId).ToList();
                    String roleName= databaseEntitties.tb_Roles.Where(role => rolesForUser.Contains(role.RoleID)).Select(role=>role.RoleName).FirstOrDefault();
                    return RedirectToAction("Index",roleName.TrimEnd());
                }
                if (userPresent == null)
                {
                    ModelState.AddModelError("", "Invalid UserName or Password");
                    return View();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
       
    }
}
