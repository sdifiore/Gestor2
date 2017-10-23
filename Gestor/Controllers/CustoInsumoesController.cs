using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;
using System.Collections.Generic;
using System.Linq;

namespace Gestor.Controllers
{
    public class CustoInsumoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CustoInsumoes
        public ActionResult Index()
        {
            var domain = Populate.CustoInsumo();

            return View(domain);
        }

        // GET: CustoInsumoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var domain = Populate.CustoInsumo();
            var custoInsumo = domain.FirstOrDefault(c => c.CustoInsumoId == id);

            if (custoInsumo == null)
            {
                return HttpNotFound();
            }
            return View(custoInsumo);
        }

        // GET: CustoInsumoes/Create
        public ActionResult Create()
        {
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido");
            return View();
        }

        // POST: CustoInsumoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustoInsumoId,PrcBrtCmpr,CrdtIcms,CrdtIpi,CrdtPis,CrdtCofins,SumCrdtImpostos,DespImport,CustoExtra,CstUndConsumo,FgmtoFornecImport,UsoStrut,ExisteRede,ProdutoId")] CustoInsumo custoInsumo)
        {
            if (ModelState.IsValid)
            {
                db.CustoInsumos.Add(custoInsumo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", custoInsumo.ProdutoId);
            return View(custoInsumo);
        }

        // GET: CustoInsumoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustoInsumo custoInsumo = db.CustoInsumos.Find(id);
            if (custoInsumo == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", custoInsumo.ProdutoId);
            return View(custoInsumo);
        }

        // POST: CustoInsumoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustoInsumoId,PrcBrtCmpr,CrdtIcms,CrdtIpi,CrdtPis,CrdtCofins,SumCrdtImpostos,DespImport,CustoExtra,CstUndConsumo,FgmtoFornecImport,UsoStrut,ExisteRede,ProdutoId")] CustoInsumo custoInsumo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(custoInsumo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", custoInsumo.ProdutoId);
            return View(custoInsumo);
        }

        // GET: CustoInsumoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustoInsumo custoInsumo = db.CustoInsumos.Find(id);
            if (custoInsumo == null)
            {
                return HttpNotFound();
            }
            return View(custoInsumo);
        }

        // POST: CustoInsumoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustoInsumo custoInsumo = db.CustoInsumos.Find(id);
            db.CustoInsumos.Remove(custoInsumo);
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
