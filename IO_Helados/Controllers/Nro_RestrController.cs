using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IO_Helados.Models;

namespace IO_Helados.Controllers
{
    public class Nro_RestrController : Controller
    {
        // GET: Nro_Restr
        public ActionResult Index()
        {
            Nro_Restr nres = new Nro_Restr();
                return View(nres.getAllNro_Restr());
        }

        // GET: Nro_Restr/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Nro_Restr/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nro_Restr/Create
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

        // GET: Nro_Restr/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Nro_Restr/Edit/5
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

        // GET: Nro_Restr/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Nro_Restr/Delete/5
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
