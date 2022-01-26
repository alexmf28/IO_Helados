using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IO_Helados.Models;

namespace IO_Helados.Controllers
{
    public class HeladosController : Controller
    {
        // GET: Helados
        public ActionResult Index()
        {
            Helados he = new Helados();
            return View(he.getAllHelados());
        }

        // GET: Helados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Helados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Helados/Create
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

        // GET: Helados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Helados/Edit/5
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

        // GET: Helados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Helados/Delete/5
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
