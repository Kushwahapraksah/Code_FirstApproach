using Code_FirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_FirstApproach.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext DbContext = new ApplicationDbContext();

        // GET: Products
        public ActionResult Index()
        {
            var products = DbContext.Products.ToList();

            return View(products);
        }


        public ActionResult CreatePro()
        {
            

            return View();
        }
        [HttpPost]
        public ActionResult CreatePro(Products product)
        {
            DbContext.Products.Add(product);
            DbContext.SaveChanges();



            return RedirectToAction("Index");
        }

     

      
        public ActionResult Delete(int id)
        {
            var res = DbContext.Products.SingleOrDefault(m => m.Id == id);
            DbContext.Products.Remove(res);
            DbContext.SaveChanges();
           
            
            return RedirectToAction("Index");
        }





        public ActionResult EditPro(int id)
        {
            var product = DbContext.Products.SingleOrDefault(m => m.Id == id);

            return View(product);
        }
        [HttpPost]
        public ActionResult EditPro(Products product)
        {
            DbContext.Entry(product).State = System.Data.Entity.EntityState.Modified;

            DbContext.SaveChanges();


            return RedirectToAction("Index");
        }

    }
}