using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IO_Helados.Models;

namespace IO_Helados.Controllers
{
    public class Hel_UtiController : Controller
    {
        // GET: Hel_Uti
        public ActionResult Index()
        {
            Hel_Uti huti = new Hel_Uti();
                return View(huti.getAllHel_Uti());
        }

        // GET: Hel_Uti/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hel_Uti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hel_Uti/Create
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

        // GET: Hel_Uti/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hel_Uti/Edit/5
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

        // GET: Hel_Uti/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hel_Uti/Delete/5
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
