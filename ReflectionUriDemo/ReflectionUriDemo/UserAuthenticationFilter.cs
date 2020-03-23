using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using ReflectionUriDemo.Models;
namespace ReflectionUriDemo
    {
        public class UserAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
        {
        static Controller_Reflection_DBEntities3 databaseEntitties = new Controller_Reflection_DBEntities3();
        public void OnAuthentication(AuthenticationContext filterContext)
            {
            //Check Session is Empty Then set as Result is HttpUnauthorizedResult 
               if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["User"])))
               {
                 filterContext.Result = new HttpUnauthorizedResult();
                 return;
               }
                var user =(tb_Users) (filterContext.HttpContext.Session["User"]);
                var roles = databaseEntitties.tb_UserMappedRoles.Where(role => role.userId == user.UserId).Select(role=>role.roleId).ToList();
                var controllers= databaseEntitties.tb_ControllerMappedRoles.Where(controller =>roles.Contains(controller.roleId)).Select(controller=>controller.ControllerId).ToList();
                  var authorizedUrls = databaseEntitties.tb_Controller.Where(controller => controllers.Contains(controller.ControllerId)).Select(controller => controller.ControllerUrl).ToList();
                var currentURL = $"{filterContext.RouteData.Values["Controller"]}/{filterContext.RouteData.Values["Action"]}";
                foreach (var url in authorizedUrls)
                {
                String[] urlSplit = url.Split('/');
                if (urlSplit.Length == 3)
                {
                    String actualUrl = urlSplit[0] + "/" + urlSplit[1];
                    if (actualUrl.Equals(currentURL))
                    {
                        return;
                    }
                    
                }
                else if (urlSplit.Length == 4)
                {
                    String actualUrl = urlSplit[0] + "/" + urlSplit[1];
                    if (actualUrl.Equals(currentURL))
                    {
                        return;
                    }

                }
                   else if (url.Equals(currentURL))
                        return;
                }
                filterContext.Result = new HttpUnauthorizedResult();


            }

            public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
            {
                if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
                {
                    filterContext.Result = new ViewResult
                    {
                        ViewName = "AccessDenied"
                    };
                }
            }
        }
    }