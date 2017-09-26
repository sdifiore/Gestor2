using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class ParametersController : Controller
    {
        private ApplicationDbContext _context;

        public ParametersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Parameters
        public ActionResult Index()
        {
            var parameters = _context.Parameters.ToList();
            return View(parameters);
        }

        // GET: Parameters/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Parameters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parameters/Create
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

        // GET: Parameters/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Parameters/Edit/5
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

        // GET: Parameters/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Parameters/Delete/5
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

        public ActionResult Save(Parametros parm)
        {
            _context.Parameters.Add(parm);
            _context.SaveChanges();
            return RedirectToAction("Index", "Parameters");
        }
    }
}
