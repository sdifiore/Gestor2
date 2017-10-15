using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class InsumoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Insumoes
        public ActionResult Index()
        {
            var insumos = db.Insumos.Include(i => i.Cotacao).Include(i => i.Finalidade).Include(i => i.Produto).Include(i => i.UnidadeConsumo);
            return View(insumos.ToList());
        }

        // GET: Insumoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insumo insumo = db.Insumos
                .Include(i => i.Cotacao)
                .Include(i => i.Finalidade)
                .Include(i => i.Produto)
                .Include(i => i.UnidadeConsumo)
                .SingleOrDefault(i => i.InsumoId == id);

            if (insumo == null)
            {
                return HttpNotFound();
            }
            return View(insumo);
        }

        // GET: Insumoes/Create
        public ActionResult Create()
        {
            ViewBag.CotacaoId = new SelectList(db.Cotacoes, "CotacaoId", "Descricao");
            ViewBag.FinalidadeId = new SelectList(db.Finalidades, "FinalidadeId", "Descricao");
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido");
            ViewBag.UnddId = new SelectList(db.Unidades, "UnidadeId", "Apelido");
            return View();
        }

        // POST: Insumoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InsumoId,Apelido,Peso,CotacaoId,PrecoUsd,PrecoRs,Icms,Ipi,Pis,Cofins,DespExtra,DespImport,Ativo,FinalidadeId,UnddId,QtdUnddConsumo,QtdMltplCompra,ProdutoId")] Insumo insumo)
        {
            if (ModelState.IsValid)
            {
                insumo.Icms = insumo.Icms / 100;
                insumo.Ipi = insumo.Ipi / 100;
                insumo.Pis = insumo.Pis / 100;
                insumo.Cofins = insumo.Cofins / 100;
                insumo.DespExtra = insumo.DespExtra / 100;
                insumo.DespImport = insumo.DespImport / 100;

                db.Insumos.Add(insumo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CotacaoId = new SelectList(db.Cotacoes, "CotacaoId", "Descricao", insumo.CotacaoId);
            ViewBag.FinalidadeId = new SelectList(db.Finalidades, "FinalidadeId", "Descricao", insumo.FinalidadeId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", insumo.ProdutoId);
            ViewBag.UnddId = new SelectList(db.Unidades, "UnidadeId", "Apelido", insumo.UnddId);
            return View(insumo);
        }

        // GET: Insumoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insumo insumo = db.Insumos.Find(id);
            if (insumo == null)
            {
                return HttpNotFound();
            }

            insumo.Icms = insumo.Icms * 100;
            insumo.Ipi = insumo.Ipi * 100;
            insumo.Pis = insumo.Pis * 100;
            insumo.Cofins = insumo.Cofins * 100;
            insumo.DespExtra = insumo.DespExtra * 100;
            insumo.DespImport = insumo.DespImport * 100;

            ViewBag.CotacaoId = new SelectList(db.Cotacoes, "CotacaoId", "Descricao", insumo.CotacaoId);
            ViewBag.FinalidadeId = new SelectList(db.Finalidades, "FinalidadeId", "Descricao", insumo.FinalidadeId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", insumo.ProdutoId);
            ViewBag.UnddId = new SelectList(db.Unidades, "UnidadeId", "Apelido", insumo.UnddId);

            return View(insumo);
        }

        // POST: Insumoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InsumoId,Apelido,Peso,CotacaoId,PrecoUsd,PrecoRs,Icms,Ipi,Pis,Cofins,DespExtra,DespImport,Ativo,FinalidadeId,UnddId,QtdUnddConsumo,QtdMltplCompra,ProdutoId")] Insumo insumo)
        {
            if (ModelState.IsValid)
            {
                insumo.Icms = insumo.Icms / 100;
                insumo.Ipi = insumo.Ipi / 100;
                insumo.Pis = insumo.Pis / 100;
                insumo.Cofins = insumo.Cofins / 100;
                insumo.DespExtra = insumo.DespExtra / 100;
                insumo.DespImport = insumo.DespImport / 100;

                db.Entry(insumo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CotacaoId = new SelectList(db.Cotacoes, "CotacaoId", "Descricao", insumo.CotacaoId);
            ViewBag.FinalidadeId = new SelectList(db.Finalidades, "FinalidadeId", "Descricao", insumo.FinalidadeId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", insumo.ProdutoId);
            ViewBag.UnddId = new SelectList(db.Unidades, "UnidadeId", "Apelido", insumo.UnddId);
            return View(insumo);
        }

        // GET: Insumoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Insumo insumo = db.Insumos
                .Include(i => i.Cotacao)
                .Include(i => i.Finalidade)
                .Include(i => i.Produto)
                .Include(i => i.UnidadeConsumo)
                .SingleOrDefault(i => i.InsumoId == id);

            if (insumo == null)
            {
                return HttpNotFound();
            }
            return View(insumo);
        }

        // POST: Insumoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insumo insumo = db.Insumos.Find(id);
            db.Insumos.Remove(insumo);
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
