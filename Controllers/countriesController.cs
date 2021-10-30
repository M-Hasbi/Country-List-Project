using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Country_List_Project.Controllers
{
    public class countriesController : ApiController
    {
        // GET: countries
        public IEnumerable<string> Get()
        {
            return new string[] { "CAN", "USA", "MEX", "BLZ", "GTM", "SLV", "HND", "NIC", "CRI", "PAN", };
        }

        // GET: countries/Details/5
        public ActionResult Details(int id)
        {
           
        }




        //// GET: countries/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: countries/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: countries/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: countries/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: countries/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: countries/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
