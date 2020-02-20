using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ProductMVC.Models;

namespace ProductMVC.Controllers
{
    public class ProduvtMVCController : Controller
    {
        // GET: ProduvtMVC
        public ActionResult Index()
        {
            IEnumerable<ProductModel> prodList;
            HttpResponseMessage response = GlobalVariable.webApiClient.GetAsync("Products").Result;
            prodList = response.Content.ReadAsAsync<IEnumerable<ProductModel>>().Result;
            return View(prodList);
        }
        public ActionResult AddOrEdit(int id = 0)
        {
            
            return View(new ProductModel());
          
        }
        [HttpPost]
        public ActionResult AddOrEdit(ProductModel p)
        {
            HttpResponseMessage response = GlobalVariable.webApiClient.PostAsJsonAsync("Products", p).Result;
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            HttpResponseMessage response = GlobalVariable.webApiClient.GetAsync("Products/" + id.ToString()).Result;
            return View(response.Content.ReadAsAsync<ProductModel>().Result);
        }
        [HttpPost]
        public ActionResult Edit(ProductModel p)
        {
            HttpResponseMessage response = GlobalVariable.webApiClient.PutAsJsonAsync("Products/" + p.Id, p).Result;
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            
      
            HttpResponseMessage response = GlobalVariable.webApiClient.DeleteAsync("Products/"+id.ToString()).Result;
            return RedirectToAction("Index");
      
    }


    }
}