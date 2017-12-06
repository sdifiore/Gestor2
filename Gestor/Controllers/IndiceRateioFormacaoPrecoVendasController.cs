using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class IndiceRateioFormacaoPrecoVendasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: IndiceRateioFormacaoPrecoVendas
        public ActionResult Index()
        {
            var indiceRateioFormacaoPrecoVendas = db.IndiceRateioFormacaoPrecoVendas.Include(i => i.GrupoRateio);
            return View(indiceRateioFormacaoPrecoVendas.ToList());
        }

        // GET: IndiceRateioFormacaoPrecoVendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            IndiceRateioFormacaoPrecoVenda indiceRateioFormacaoPrecoVenda = db.IndiceRateioFormacaoPrecoVendas
                .Include(i => i.GrupoRateio)
                .SingleOrDefault(i => i.Id == id);

            if (indiceRateioFormacaoPrecoVenda == null)
            {
                return HttpNotFound();
            }
            return View(indiceRateioFormacaoPrecoVenda);
        }

        // GET: IndiceRateioFormacaoPrecoVendas/Create
        public ActionResult Create()
        {
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao");
            return View();
        }

        // POST: IndiceRateioFormacaoPrecoVendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GrupoRateioId,TotalCustoFixo,MoiFabricacao,OutroCustoFixoFabricacao,CustoFixoComacs,CustoFixoComtex,CustoFixoAdminLog")] IndiceRateioFormacaoPrecoVenda indiceRateioFormacaoPrecoVenda)
        {
            if (ModelState.IsValid)
            {
                db.IndiceRateioFormacaoPrecoVendas.Add(indiceRateioFormacaoPrecoVenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", indiceRateioFormacaoPrecoVenda.GrupoRateioId);
            return View(indiceRateioFormacaoPrecoVenda);
        }

        // GET: IndiceRateioFormacaoPrecoVendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndiceRateioFormacaoPrecoVenda indiceRateioFormacaoPrecoVenda = db.IndiceRateioFormacaoPrecoVendas.Find(id);
            if (indiceRateioFormacaoPrecoVenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", indiceRateioFormacaoPrecoVenda.GrupoRateioId);
            return View(indiceRateioFormacaoPrecoVenda);
        }

        // POST: IndiceRateioFormacaoPrecoVendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GrupoRateioId,TotalCustoFixo,MoiFabricacao,OutroCustoFixoFabricacao,CustoFixoComacs,CustoFixoComtex,CustoFixoAdminLog")] IndiceRateioFormacaoPrecoVenda indiceRateioFormacaoPrecoVenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(indiceRateioFormacaoPrecoVenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", indiceRateioFormacaoPrecoVenda.GrupoRateioId);
            return View(indiceRateioFormacaoPrecoVenda);
        }

        // GET: IndiceRateioFormacaoPrecoVendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            IndiceRateioFormacaoPrecoVenda indiceRateioFormacaoPrecoVenda = db.IndiceRateioFormacaoPrecoVendas
                .Include(i => i.GrupoRateio)
                .SingleOrDefault(i => i.Id == id);

            if (indiceRateioFormacaoPrecoVenda == null)
            {
                return HttpNotFound();
            }
            return View(indiceRateioFormacaoPrecoVenda);
        }

        // POST: IndiceRateioFormacaoPrecoVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IndiceRateioFormacaoPrecoVenda indiceRateioFormacaoPrecoVenda = db.IndiceRateioFormacaoPrecoVendas.Find(id);
            db.IndiceRateioFormacaoPrecoVendas.Remove(indiceRateioFormacaoPrecoVenda);
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
