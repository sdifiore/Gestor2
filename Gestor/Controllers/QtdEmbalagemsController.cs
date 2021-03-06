﻿using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class QtdEmbalagemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: QtdEmbalagems
        public ViewResult Index()
        {
            var viewModel = db.QtdEmbalagems.Include(m => m.MedidaFita);
            return View(viewModel);
        }

        // GET: QtdEmbalagems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QtdEmbalagem qtdEmbalagem = db.QtdEmbalagems.Find(id);
            if (qtdEmbalagem == null)
            {
                return HttpNotFound();
            }
            return View(qtdEmbalagem);
        }

        // GET: QtdEmbalagems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QtdEmbalagems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QtdEmbalagemId,CartuchoRolCx,CartuchoCxPlt,DisplayRolCx,CarretelRolCx,CarretelCxPlt,MedidaFitasId")] QtdEmbalagem qtdEmbalagem)
        {
            if (ModelState.IsValid)
            {
                db.QtdEmbalagems.Add(qtdEmbalagem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qtdEmbalagem);
        }

        // GET: QtdEmbalagems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QtdEmbalagem qtdEmbalagem = db.QtdEmbalagems.Find(id);
            if (qtdEmbalagem == null)
            {
                return HttpNotFound();
            }
            return View(qtdEmbalagem);
        }

        // POST: QtdEmbalagems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QtdEmbalagemId,CartuchoRolCx,CartuchoCxPlt,DisplayRolCx,CarretelRolCx,CarretelCxPlt,MedidaFitasId")] QtdEmbalagem qtdEmbalagem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qtdEmbalagem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qtdEmbalagem);
        }

        // GET: QtdEmbalagems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QtdEmbalagem qtdEmbalagem = db.QtdEmbalagems.Find(id);
            if (qtdEmbalagem == null)
            {
                return HttpNotFound();
            }
            return View(qtdEmbalagem);
        }

        // POST: QtdEmbalagems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QtdEmbalagem qtdEmbalagem = db.QtdEmbalagems.Find(id);
            db.QtdEmbalagems.Remove(qtdEmbalagem);
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
