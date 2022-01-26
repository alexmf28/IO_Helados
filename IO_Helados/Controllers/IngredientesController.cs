using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IO_Helados.Models;

namespace IO_Helados.Controllers
{
    public class IngredientesController : Controller
    {
        // GET: Ingredientes
        public ActionResult Index()
        {
            Ingredientes ing = new Ingredientes();
            return View(ing.getAllIngredientes());
        }

        // GET: Ingredientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ingredientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ingredientes/Create
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

        // GET: Ingredientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ingredientes/Edit/5
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

        // GET: Ingredientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ingredientes/Delete/5
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
