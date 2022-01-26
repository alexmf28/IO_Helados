using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IO_Helados.Models;

namespace IO_Helados.Controllers
{
    public class Ing_UndController : Controller
    {
        // GET: Ing_Und
        public ActionResult Index()
        {
            Ing_Und iu = new Ing_Und();
            return View(iu.getAllIng_Und());
        }

        // GET: Ing_Und/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ing_Und/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ing_Und/Create
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

        // GET: Ing_Und/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ing_Und/Edit/5
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

        // GET: Ing_Und/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ing_Und/Delete/5
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
