using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class TipoProducaosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoProducaos
        public ActionResult Index()
        {
            return View(db.TiposProducao.ToList());
        }

        // GET: TipoProducaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoProducao tipoProducao = db.TiposProducao.Find(id);
            if (tipoProducao == null)
            {
                return HttpNotFound();
            }
            return View(tipoProducao);
        }

        // GET: TipoProducaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoProducaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoProducaoId,Descricao")] TipoProducao tipoProducao)
        {
            if (ModelState.IsValid)
            {
                db.TiposProducao.Add(tipoProducao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoProducao);
        }

        // GET: TipoProducaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoProducao tipoProducao = db.TiposProducao.Find(id);
            if (tipoProducao == null)
            {
                return HttpNotFound();
            }
            return View(tipoProducao);
        }

        // POST: TipoProducaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoProducaoId,Descricao")] TipoProducao tipoProducao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoProducao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoProducao);
        }

        // GET: TipoProducaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoProducao tipoProducao = db.TiposProducao.Find(id);
            if (tipoProducao == null)
            {
                return HttpNotFound();
            }
            return View(tipoProducao);
        }

        // POST: TipoProducaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoProducao tipoProducao = db.TiposProducao.Find(id);
            db.TiposProducao.Remove(tipoProducao);
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
