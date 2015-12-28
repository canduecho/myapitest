using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myapitest.Controllers
{
    public class indexController : Controller
    {
        //
        // GET: /index/

        public ActionResult Index()
        {
            return View("index");
        }

        //
        // GET: /index/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /index/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /index/Create

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
        
        //
        // GET: /index/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /index/Edit/5

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

        //
        // GET: /index/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /index/Delete/5

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
