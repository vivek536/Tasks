using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using ReflectionUriDemo.Models;

namespace ReflectionUriDemo
{
    public class UrlReflection
    {
        public List<String> getControllerNames()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            var actionResultList = asm.GetTypes()
                 .Where(type => typeof(System.Web.Mvc.Controller).IsAssignableFrom(type)) //filter controllers
                 .SelectMany(type => type.GetMethods())
                 .Where(method => method.IsPublic && !method.IsDefined(typeof(System.Web.Mvc.NonActionAttribute)) &&(method.ReturnType==typeof(System.Web.Mvc.ActionResult))).ToList();
            List<String> routeList = new List<String>();
            foreach(var controller in actionResultList)
            {
                StringBuilder routeUrl= new StringBuilder(controller.DeclaringType.Name.Substring(0,controller.DeclaringType.Name.Length-10)+"/"+controller.Name);
                var parameters = controller.GetParameters();
                foreach(var parameter in parameters)
                {
                    routeUrl.Append("/" + parameter);
                }
                routeList.Add(routeUrl.ToString());
            }
            return routeList;
        }
        public void AddRouteUri()
        {
            List <String> routeList= getControllerNames();
            Controller_Reflection_DBEntities3 databaseEntities = new Controller_Reflection_DBEntities3();
            foreach(var route in routeList)
            {
                var routeUri = databaseEntities.tb_Controller.Where(controllerUri => controllerUri.ControllerUrl == route).FirstOrDefault();
                if (routeUri == null)
                {
                    tb_Controller _Controller = new tb_Controller();
                    _Controller.ControllerUrl = route;
                    databaseEntities.tb_Controller.Add(_Controller);
                    databaseEntities.SaveChanges();
                }
            }
        }
    }
}