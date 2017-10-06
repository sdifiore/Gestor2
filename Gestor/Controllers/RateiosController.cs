using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class RateiosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rateios
        public ActionResult Index()
        {
            return View(db.Rateios.ToList());
        }

        // GET: Rateios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rateio rateio = db.Rateios.Find(id);
            if (rateio == null)
            {
                return HttpNotFound();
            }
            return View(rateio);
        }

        // GET: Rateios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rateios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RateioId,Grupo,Horas")] Rateio rateio)
        {
            if (ModelState.IsValid)
            {
                db.Rateios.Add(rateio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rateio);
        }

        // GET: Rateios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rateio rateio = db.Rateios.Find(id);
            if (rateio == null)
            {
                return HttpNotFound();
            }
            return View(rateio);
        }

        // POST: Rateios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RateioId,Grupo,Horas")] Rateio rateio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rateio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rateio);
        }

        // GET: Rateios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rateio rateio = db.Rateios.Find(id);
            if (rateio == null)
            {
                return HttpNotFound();
            }
            return View(rateio);
        }

        // POST: Rateios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rateio rateio = db.Rateios.Find(id);
            db.Rateios.Remove(rateio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
