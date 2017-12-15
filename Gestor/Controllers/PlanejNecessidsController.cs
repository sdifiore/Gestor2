using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    [RoutePrefix("PlanejaNecessidades")]
    public class PlanejNecessidsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PlanejNecessids
        [Route]
        public ActionResult Index()
        {
            var planejNecessids = db.PlanejNecessids
                .Include(p => p.Estrutura)
                .Include(p => p.Estrutura.Produto)
                .Include(p => p.Estrutura.Unidade)
                .Include(p => p.Estrutura.UnidadeCompra)
                .Include(p => p.Estrutura.Sequencia);

            return View(planejNecessids.ToList());
        }

        // GET: PlanejNecessids/Details/5
        [Route("Details")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanejNecessid planejNecessid = db.PlanejNecessids.Find(id);
            if (planejNecessid == null)
            {
                return HttpNotFound();
            }
            return View(planejNecessid);
        }

        // GET: PlanejNecessids/Create
        [Route("Create")]
        public ActionResult Create()
        {
            ViewBag.EstruturaId = new SelectList(db.Estruturas, "Id", "Item");
            return View();
        }

        // POST: PlanejNecessids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EstruturaId,SetorProducao,Categoria,Familia,ListaPlanejProducao,NeedComponProducao,ListaNecessProdNivel1,NecCompListaP1,ListaNecessProdNivel2,NecCompListaP2,ListaNecessProdNivel3,NecCompListaP3,ListaNecessProdNivel4,NecCompListaP4,NecTotalComponente,Mes1,Mes2,Mes3,Mes4,Mes5,Mes6,Mes7,Mes8,Mes9,Mes10,Mes11,Mes12")] PlanejNecessid planejNecessid)
        {
            if (ModelState.IsValid)
            {
                db.PlanejNecessids.Add(planejNecessid);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstruturaId = new SelectList(db.Estruturas, "Id", "Item", planejNecessid.EstruturaId);
            return View(planejNecessid);
        }

        // GET: PlanejNecessids/Edit/5
        [Route("Edit")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanejNecessid planejNecessid = db.PlanejNecessids.Find(id);
            if (planejNecessid == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstruturaId = new SelectList(db.Estruturas, "Id", "Item", planejNecessid.EstruturaId);
            return View(planejNecessid);
        }

        // POST: PlanejNecessids/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EstruturaId,SetorProducao,Categoria,Familia,ListaPlanejProducao,NeedComponProducao,ListaNecessProdNivel1,NecCompListaP1,ListaNecessProdNivel2,NecCompListaP2,ListaNecessProdNivel3,NecCompListaP3,ListaNecessProdNivel4,NecCompListaP4,NecTotalComponente,Mes1,Mes2,Mes3,Mes4,Mes5,Mes6,Mes7,Mes8,Mes9,Mes10,Mes11,Mes12")] PlanejNecessid planejNecessid)
        {
            if (ModelState.IsValid)
            {
                db.Entry(planejNecessid).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstruturaId = new SelectList(db.Estruturas, "Id", "Item", planejNecessid.EstruturaId);
            return View(planejNecessid);
        }

        // GET: PlanejNecessids/Delete/5
        [Route("Delete")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanejNecessid planejNecessid = db.PlanejNecessids.Find(id);
            if (planejNecessid == null)
            {
                return HttpNotFound();
            }
            return View(planejNecessid);
        }

        // POST: PlanejNecessids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlanejNecessid planejNecessid = db.PlanejNecessids.Find(id);
            db.PlanejNecessids.Remove(planejNecessid);
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
