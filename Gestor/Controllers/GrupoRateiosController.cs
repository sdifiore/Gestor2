using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Gestor.Models
{
    public class GrupoRateiosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GrupoRateios
        public ActionResult Index()
        {
            return View(db.GruposRateio.ToList());
        }

        // GET: GrupoRateios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoRateio grupoRateio = db.GruposRateio.Find(id);
            if (grupoRateio == null)
            {
                return HttpNotFound();
            }
            return View(grupoRateio);
        }

        // GET: GrupoRateios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GrupoRateios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrupoRateioId,Descricao")] GrupoRateio grupoRateio)
        {
            if (ModelState.IsValid)
            {
                db.GruposRateio.Add(grupoRateio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grupoRateio);
        }

        // GET: GrupoRateios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoRateio grupoRateio = db.GruposRateio.Find(id);
            if (grupoRateio == null)
            {
                return HttpNotFound();
            }
            return View(grupoRateio);
        }

        // POST: GrupoRateios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrupoRateioId,Descricao")] GrupoRateio grupoRateio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grupoRateio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grupoRateio);
        }

        // GET: GrupoRateios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoRateio grupoRateio = db.GruposRateio.Find(id);
            if (grupoRateio == null)
            {
                return HttpNotFound();
            }
            return View(grupoRateio);
        }

        // POST: GrupoRateios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GrupoRateio grupoRateio = db.GruposRateio.Find(id);
            db.GruposRateio.Remove(grupoRateio);
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
