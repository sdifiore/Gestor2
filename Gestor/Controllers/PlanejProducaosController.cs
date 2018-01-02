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
    public class PlanejProducaosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PlanejProducaos
        public ActionResult Index()
        {
            var planejProducoes = db.PlanejProducoes.Include(p => p.PlanejVenda).Include(p => p.Produto);
            return View(planejProducoes.ToList());
        }

        // GET: PlanejProducaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanejProducao planejProducao = db.PlanejProducoes.Find(id);
            if (planejProducao == null)
            {
                return HttpNotFound();
            }
            return View(planejProducao);
        }

        // GET: PlanejProducaos/Create
        public ActionResult Create()
        {
            ViewBag.PlanejVendaId = new SelectList(db.PlanejVendas, "Id", "ComentarioCelulaBi");
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido");
            return View();
        }

        // POST: PlanejProducaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProdutoId,PlanejVendaId,PmpAnoMenos11,PmpAnoMenos10,PmpAnoMenos09,PmpAnoMenos08,PmpAnoMenos07,PmpAnoMenos06,PmpAnoMenos05,PmpAnoMenos04,PmpAnoMenos03,PmpAnoMenos02,PmpAnoMenos01,PmpAnoMenos00,SfmAnoMenos11,SfmAnoMenos10,SfmAnoMenos09,SfmAnoMenos08,SfmAnoMenos07,SfmAnoMenos06,SfmAnoMenos05,SfmAnoMenos04,SfmAnoMenos03,SfmAnoMenos02,SfmAnoMenos01,SfmAnoMenos00")] PlanejProducao planejProducao)
        {
            if (ModelState.IsValid)
            {
                db.PlanejProducoes.Add(planejProducao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlanejVendaId = new SelectList(db.PlanejVendas, "Id", "ComentarioCelulaBi", planejProducao.PlanejVendaId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", planejProducao.ProdutoId);
            return View(planejProducao);
        }

        // GET: PlanejProducaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanejProducao planejProducao = db.PlanejProducoes.Find(id);
            if (planejProducao == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlanejVendaId = new SelectList(db.PlanejVendas, "Id", "ComentarioCelulaBi", planejProducao.PlanejVendaId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", planejProducao.ProdutoId);
            return View(planejProducao);
        }

        // POST: PlanejProducaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProdutoId,PlanejVendaId,PmpAnoMenos11,PmpAnoMenos10,PmpAnoMenos09,PmpAnoMenos08,PmpAnoMenos07,PmpAnoMenos06,PmpAnoMenos05,PmpAnoMenos04,PmpAnoMenos03,PmpAnoMenos02,PmpAnoMenos01,PmpAnoMenos00,SfmAnoMenos11,SfmAnoMenos10,SfmAnoMenos09,SfmAnoMenos08,SfmAnoMenos07,SfmAnoMenos06,SfmAnoMenos05,SfmAnoMenos04,SfmAnoMenos03,SfmAnoMenos02,SfmAnoMenos01,SfmAnoMenos00")] PlanejProducao planejProducao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(planejProducao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlanejVendaId = new SelectList(db.PlanejVendas, "Id", "ComentarioCelulaBi", planejProducao.PlanejVendaId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", planejProducao.ProdutoId);
            return View(planejProducao);
        }

        // GET: PlanejProducaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanejProducao planejProducao = db.PlanejProducoes.Find(id);
            if (planejProducao == null)
            {
                return HttpNotFound();
            }
            return View(planejProducao);
        }

        // POST: PlanejProducaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlanejProducao planejProducao = db.PlanejProducoes.Find(id);
            db.PlanejProducoes.Remove(planejProducao);
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
