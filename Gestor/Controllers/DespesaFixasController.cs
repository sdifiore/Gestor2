using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class DespesaFixasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DespesaFixas
        public ActionResult Index()
        {
            return View(db.DespesasFixas.ToList());
        }

        // GET: DespesaFixas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DespesaFixa despesaFixa = db.DespesasFixas.Find(id);
            if (despesaFixa == null)
            {
                return HttpNotFound();
            }
            return View(despesaFixa);
        }

        // GET: DespesaFixas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DespesaFixas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Despesa,ValorTotal,Comentario,CodCrit,CriterioRateio,RateioFitas,RateioTuboCordaoPerfil,RateioFioGaxPtfePuro,RateioFioGaxPtfeGraf,RateioGraxa,RateioSucatas,RateioRevenda,Somas")] DespesaFixa despesaFixa)
        {
            if (ModelState.IsValid)
            {
                db.DespesasFixas.Add(despesaFixa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(despesaFixa);
        }

        // GET: DespesaFixas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DespesaFixa despesaFixa = db.DespesasFixas.Find(id);
            if (despesaFixa == null)
            {
                return HttpNotFound();
            }
            return View(despesaFixa);
        }

        // POST: DespesaFixas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Despesa,ValorTotal,Comentario,CodCrit,CriterioRateio,RateioFitas,RateioTuboCordaoPerfil,RateioFioGaxPtfePuro,RateioFioGaxPtfeGraf,RateioGraxa,RateioSucatas,RateioRevenda,Somas")] DespesaFixa despesaFixa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(despesaFixa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(despesaFixa);
        }

        // GET: DespesaFixas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DespesaFixa despesaFixa = db.DespesasFixas.Find(id);
            if (despesaFixa == null)
            {
                return HttpNotFound();
            }
            return View(despesaFixa);
        }

        // POST: DespesaFixas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DespesaFixa despesaFixa = db.DespesasFixas.Find(id);
            db.DespesasFixas.Remove(despesaFixa);
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
