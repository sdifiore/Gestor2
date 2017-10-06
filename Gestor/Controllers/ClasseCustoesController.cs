using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor
{
    public class ClasseCustoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ClasseCustoes
        public ActionResult Index()
        {
            return View(db.ClassesCusto.ToList());
        }

        // GET: ClasseCustoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasseCusto classeCusto = db.ClassesCusto.Find(id);
            if (classeCusto == null)
            {
                return HttpNotFound();
            }
            return View(classeCusto);
        }

        // GET: ClasseCustoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClasseCustoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClasseCustoId,Apelido,Descricao")] ClasseCusto classeCusto)
        {
            if (ModelState.IsValid)
            {
                db.ClassesCusto.Add(classeCusto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classeCusto);
        }

        // GET: ClasseCustoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasseCusto classeCusto = db.ClassesCusto.Find(id);
            if (classeCusto == null)
            {
                return HttpNotFound();
            }
            return View(classeCusto);
        }

        // POST: ClasseCustoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClasseCustoId,Apelido,Descricao")] ClasseCusto classeCusto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classeCusto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classeCusto);
        }

        // GET: ClasseCustoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasseCusto classeCusto = db.ClassesCusto.Find(id);
            if (classeCusto == null)
            {
                return HttpNotFound();
            }
            return View(classeCusto);
        }

        // POST: ClasseCustoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClasseCusto classeCusto = db.ClassesCusto.Find(id);
            db.ClassesCusto.Remove(classeCusto);
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
