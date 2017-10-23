using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class DetalheEstruturasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DetalheEstruturas
        public ActionResult Index()
        {
            var detalheEstruturas = db.DetalheEstruturas.Include(d => d.Estrutura);
            return View(detalheEstruturas.ToList());
        }

        // GET: DetalheEstruturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheEstrutura detalheEstrutura = db.DetalheEstruturas.Find(id);
            if (detalheEstrutura == null)
            {
                return HttpNotFound();
            }
            return View(detalheEstrutura);
        }

        // GET: DetalheEstruturas/Create
        public ActionResult Create()
        {
            ViewBag.EstruturaId = new SelectList(db.Estruturas, "Id", "Apelido");
            return View();
        }

        // POST: DetalheEstruturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DetalheEstruturaId,PartCusto,QtEftvUntrCmpnt,CstCmprUndPrd,TpItmCst,AlrtSbPrdt,TempMaq,QtdUndd,PsLiqdFnl,PsLiqdPrcdt,HrsModFnl,HrsModPrec1,HrsModPrec2,IdCmpnt,PdrHoraria,ProdComp,CstMtrlDrt,CstMtrlPrcd1,CstMtrlPrcd2,CstMtrlPrcd3,EstruturaId")] DetalheEstrutura detalheEstrutura)
        {
            if (ModelState.IsValid)
            {
                db.DetalheEstruturas.Add(detalheEstrutura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstruturaId = new SelectList(db.Estruturas, "Id", "Apelido", detalheEstrutura.EstruturaId);
            return View(detalheEstrutura);
        }

        // GET: DetalheEstruturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheEstrutura detalheEstrutura = db.DetalheEstruturas.Find(id);
            if (detalheEstrutura == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstruturaId = new SelectList(db.Estruturas, "Id", "Apelido", detalheEstrutura.EstruturaId);
            return View(detalheEstrutura);
        }

        // POST: DetalheEstruturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DetalheEstruturaId,PartCusto,QtEftvUntrCmpnt,CstCmprUndPrd,TpItmCst,AlrtSbPrdt,TempMaq,QtdUndd,PsLiqdFnl,PsLiqdPrcdt,HrsModFnl,HrsModPrec1,HrsModPrec2,IdCmpnt,PdrHoraria,ProdComp,CstMtrlDrt,CstMtrlPrcd1,CstMtrlPrcd2,CstMtrlPrcd3,EstruturaId")] DetalheEstrutura detalheEstrutura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalheEstrutura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstruturaId = new SelectList(db.Estruturas, "Id", "Apelido", detalheEstrutura.EstruturaId);
            return View(detalheEstrutura);
        }

        // GET: DetalheEstruturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheEstrutura detalheEstrutura = db.DetalheEstruturas.Find(id);
            if (detalheEstrutura == null)
            {
                return HttpNotFound();
            }
            return View(detalheEstrutura);
        }

        // POST: DetalheEstruturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetalheEstrutura detalheEstrutura = db.DetalheEstruturas.Find(id);
            db.DetalheEstruturas.Remove(detalheEstrutura);
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
