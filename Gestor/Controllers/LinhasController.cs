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
    public class LinhasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Linhas
        public ActionResult Index()
        {
            return View(db.Linhas.ToList());
        }

        // GET: Linhas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Linha linha = db.Linhas.Find(id);
            if (linha == null)
            {
                return HttpNotFound();
            }
            return View(linha);
        }

        // GET: Linhas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Linhas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Apelido,Descricao")] Linha linha)
        {
            if (ModelState.IsValid)
            {
                db.Linhas.Add(linha);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(linha);
        }

        // GET: Linhas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Linha linha = db.Linhas.Find(id);
            if (linha == null)
            {
                return HttpNotFound();
            }
            return View(linha);
        }

        // POST: Linhas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Apelido,Descricao")] Linha linha)
        {
            if (ModelState.IsValid)
            {
                db.Entry(linha).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(linha);
        }

        // GET: Linhas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Linha linha = db.Linhas.Find(id);
            if (linha == null)
            {
                return HttpNotFound();
            }
            return View(linha);
        }

        // POST: Linhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Linha linha = db.Linhas.Find(id);
            db.Linhas.Remove(linha);
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
