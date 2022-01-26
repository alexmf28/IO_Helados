using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IO_Helados.Models;

namespace IO_Helados.Controllers
{
    public class Hel_IngController : Controller
    {
        // GET: Hel_Ing
        public ActionResult Index()
        {
            Hel_Ing hi = new Hel_Ing();
            return View(hi.getAllHelIng());
        }

        // GET: Hel_Ing/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hel_Ing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hel_Ing/Create
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

        // GET: Hel_Ing/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hel_Ing/Edit/5
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

        // GET: Hel_Ing/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hel_Ing/Delete/5
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
