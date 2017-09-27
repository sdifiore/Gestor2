using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class UnitsController : Controller
    {
        private ApplicationDbContext _context;

        public UnitsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Units
        public ActionResult Index()
        {
            var units = _context.Unidades.ToList();
            return View(units);
        }

        // GET: Units/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Units/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Units/Create
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

        // GET: Units/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Units/Edit/5
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

        // GET: Units/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Units/Delete/5
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

        public ActionResult Save(Unit unidade)
        {
            _context.Unidades.Add(unidade);
            _context.SaveChanges();
            return RedirectToAction("Index", "Unity");
        }
    }
}
