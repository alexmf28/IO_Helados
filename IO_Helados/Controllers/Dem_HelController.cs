using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IO_Helados.Models;

namespace IO_Helados.Controllers
{
    public class Dem_HelController : Controller
    {
        // GET: Dem_Hel
        public ActionResult Index()
        {
            Dem_Hel dehe = new Dem_Hel();
            return View(dehe.getAllDem_Hel());
        }

        // GET: Dem_Hel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dem_Hel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dem_Hel/Create
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

        // GET: Dem_Hel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dem_Hel/Edit/5
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

        // GET: Dem_Hel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dem_Hel/Delete/5
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
