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
    public class QtdMaquinasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: QtdMaquinas
        public ActionResult Index()
        {
            return View(db.QtdMaquinas.ToList());
        }

        // GET: QtdMaquinas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QtdMaquinas qtdMaquinas = db.QtdMaquinas.Find(id);
            if (qtdMaquinas == null)
            {
                return HttpNotFound();
            }
            return View(qtdMaquinas);
        }

        // GET: QtdMaquinas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QtdMaquinas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Linha,Descricao,QuantidadeMaquinas")] QtdMaquinas qtdMaquinas)
        {
            if (ModelState.IsValid)
            {
                db.QtdMaquinas.Add(qtdMaquinas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qtdMaquinas);
        }

        // GET: QtdMaquinas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QtdMaquinas qtdMaquinas = db.QtdMaquinas.Find(id);
            if (qtdMaquinas == null)
            {
                return HttpNotFound();
            }
            return View(qtdMaquinas);
        }

        // POST: QtdMaquinas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Linha,Descricao,QuantidadeMaquinas")] QtdMaquinas qtdMaquinas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qtdMaquinas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qtdMaquinas);
        }

        // GET: QtdMaquinas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QtdMaquinas qtdMaquinas = db.QtdMaquinas.Find(id);
            if (qtdMaquinas == null)
            {
                return HttpNotFound();
            }
            return View(qtdMaquinas);
        }

        // POST: QtdMaquinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QtdMaquinas qtdMaquinas = db.QtdMaquinas.Find(id);
            db.QtdMaquinas.Remove(qtdMaquinas);
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
