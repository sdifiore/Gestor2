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
    public class OperacaosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Operacaos
        public ActionResult Index()
        {
            var operacoe = db.Operacoes.Include(o => o.Setor);
            return View(operacoe.ToList());
        }

        // GET: Operacaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operacao operacao = db.Operacoes.Find(id);
            if (operacao == null)
            {
                return HttpNotFound();
            }
            return View(operacao);
        }

        // GET: Operacaos/Create
        public ActionResult Create()
        {
            ViewBag.SetorId = new SelectList(db.Setores, "SetorId", "Codigo");
            return View();
        }

        // POST: Operacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OperacaoId,CodigoOperacao,SetorProducao,Descricao,TaxaOcupacao,IneficienciaAdotada,Comentario,QtdMaquinas,Custo,SetorId")] Operacao operacao)
        {
            if (ModelState.IsValid)
            {
                operacao.IneficienciaAdotada = operacao.IneficienciaAdotada / 100;
                operacao.TaxaOcupacao = operacao.TaxaOcupacao / 100;
                db.Operacoes.Add(operacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SetorId = new SelectList(db.Setores, "SetorId", "Codigo", operacao.SetorId);
            return View(operacao);
        }

        // GET: Operacaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operacao operacao = db.Operacoes.Find(id);
            if (operacao == null)
            {
                return HttpNotFound();
            }

            operacao.TaxaOcupacao = operacao.TaxaOcupacao * 100;
            operacao.IneficienciaAdotada = operacao.IneficienciaAdotada * 100;

            ViewBag.SetorId = new SelectList(db.Setores, "SetorId", "Codigo", operacao.SetorId);
            return View(operacao);
        }

        // POST: Operacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OperacaoId,CodigoOperacao,SetorProducao,Descricao,TaxaOcupacao,IneficienciaAdotada,Comentario,QtdMaquinas,Custo,SetorId")] Operacao operacao)
        {
            if (ModelState.IsValid)
            {
                operacao.TaxaOcupacao = operacao.TaxaOcupacao / 100;
                operacao.IneficienciaAdotada = operacao.IneficienciaAdotada / 100;
                db.Entry(operacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SetorId = new SelectList(db.Setores, "SetorId", "Codigo", operacao.SetorId);
            return View(operacao);
        }

        // GET: Operacaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operacao operacao = db.Operacoes.Find(id);
            if (operacao == null)
            {
                return HttpNotFound();
            }
            return View(operacao);
        }

        // POST: Operacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Operacao operacao = db.Operacoes.Find(id);
            db.Operacoes.Remove(operacao);
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
