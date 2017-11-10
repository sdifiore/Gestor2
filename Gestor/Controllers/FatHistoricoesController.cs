using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    [RoutePrefix("FaturamentoHistorico")]
    public class FatHistoricoesController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FatHistoricoes
        [Route]
        public ActionResult Index()
        {
            return View(db.FatHistoricos.ToList());
        }

        // GET: FatHistoricoes/Details/5
        [Route("Details")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FatHistorico fatHistorico = db.FatHistoricos.Find(id);
            if (fatHistorico == null)
            {
                return HttpNotFound();
            }
            return View(fatHistorico);
        }

        // GET: FatHistoricoes/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: FatHistoricoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Rotulo,FitaRecLiq,FitaPeso,FitaHora,TuboRecLiq,TuboPeso,TuboHora,GxfPuroRecLiq,GxfPuroPeso,GxfPuroHora,GxfGrafRecLiq,GxfGrafPeso,GxfGrafHora,GraxaRecLiq,GraxaPeso,GraxaHora")] FatHistorico fatHistorico)
        {
            if (ModelState.IsValid)
            {
                db.FatHistoricos.Add(fatHistorico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fatHistorico);
        }

        // GET: FatHistoricoes/Edit/5
        [Route("Edit")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FatHistorico fatHistorico = db.FatHistoricos.Find(id);
            if (fatHistorico == null)
            {
                return HttpNotFound();
            }
            return View(fatHistorico);
        }

        // POST: FatHistoricoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Rotulo,FitaRecLiq,FitaPeso,FitaHora,TuboRecLiq,TuboPeso,TuboHora,GxfPuroRecLiq,GxfPuroPeso,GxfPuroHora,GxfGrafRecLiq,GxfGrafPeso,GxfGrafHora,GraxaRecLiq,GraxaPeso,GraxaHora")] FatHistorico fatHistorico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fatHistorico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fatHistorico);
        }

        // GET: FatHistoricoes/Delete/5
        [Route("Delete")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FatHistorico fatHistorico = db.FatHistoricos.Find(id);
            if (fatHistorico == null)
            {
                return HttpNotFound();
            }
            return View(fatHistorico);
        }

        // POST: FatHistoricoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FatHistorico fatHistorico = db.FatHistoricos.Find(id);
            db.FatHistoricos.Remove(fatHistorico);
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
