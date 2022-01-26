using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IO_Helados.Models;

namespace IO_Helados.Controllers
{
    public class Hel_CantController : Controller
    {
        // GET: Hel_Cant
        public ActionResult Index()
        {
            Hel_Cant hec = new Hel_Cant();
                return View(hec.getAllHel_Cant());           
        }

        // GET: Hel_Cant/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hel_Cant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hel_Cant/Create
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

        // GET: Hel_Cant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hel_Cant/Edit/5
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

        // GET: Hel_Cant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hel_Cant/Delete/5
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
