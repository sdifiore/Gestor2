﻿using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    [RoutePrefix("DespesasExportacao")]
    public class DespesaExportacaosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DespesaExportacaos
        [Route]
        public ActionResult Index()
        {
            return View(db.DespesasExportacao.ToList());
        }

        // GET: DespesaExportacaos/Details/5
        [Route("Details")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DespesaExportacao despesaExportacao = db.DespesasExportacao.Find(id);
            if (despesaExportacao == null)
            {
                return HttpNotFound();
            }
            return View(despesaExportacao);
        }

        // GET: DespesaExportacaos/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: DespesaExportacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tipo,Valor,Descricao")] DespesaExportacao despesaExportacao)
        {
            if (ModelState.IsValid)
            {
                db.DespesasExportacao.Add(despesaExportacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(despesaExportacao);
        }

        // GET: DespesaExportacaos/Edit/5
        [Route("Edit")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DespesaExportacao despesaExportacao = db.DespesasExportacao.Find(id);
            if (despesaExportacao == null)
            {
                return HttpNotFound();
            }

            despesaExportacao.Valor = despesaExportacao.Valor * 100;

            return View(despesaExportacao);
        }

        // POST: DespesaExportacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tipo,Valor,Descricao")] DespesaExportacao despesaExportacao)
        {
            if (ModelState.IsValid)
            {
                despesaExportacao.Valor = despesaExportacao.Valor / 100;
                db.Entry(despesaExportacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(despesaExportacao);
        }

        // GET: DespesaExportacaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DespesaExportacao despesaExportacao = db.DespesasExportacao.Find(id);
            if (despesaExportacao == null)
            {
                return HttpNotFound();
            }
            return View(despesaExportacao);
        }

        // POST: DespesaExportacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DespesaExportacao despesaExportacao = db.DespesasExportacao.Find(id);
            db.DespesasExportacao.Remove(despesaExportacao);
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
