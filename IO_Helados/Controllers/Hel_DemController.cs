using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IO_Helados.Models;

namespace IO_Helados.Controllers
{
    public class Hel_DemController : Controller
    {
        // GET: Hel_Dem
        public ActionResult Index()
        {
            Hel_Dem hede = new Hel_Dem();
            return View(hede.getAllHel_Dem());
        }

        // GET: Hel_Dem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hel_Dem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hel_Dem/Create
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

        // GET: Hel_Dem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hel_Dem/Edit/5
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

        // GET: Hel_Dem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hel_Dem/Delete/5
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
