using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class EmbalsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Embals
        public ActionResult Index()
        {
            var embals = db.Embals.Include(e => e.Insumo);
            return View(embals.ToList());
        }

        // GET: Embals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Embal embal = db.Embals
                .Include(e => e.Insumo)
                .SingleOrDefault(e => e.Id == id);

            if (embal == null)
            {
                return HttpNotFound();
            }
            return View(embal);
        }

        // GET: Embals/Create
        public ActionResult Create()
        {
            ViewBag.InsumoId = new SelectList(db.Insumos, "InsumoId", "Apelido");
            return View();
        }

        // POST: Embals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Sigla,InsumoId")] Embal embal)
        {
            if (ModelState.IsValid)
            {
                db.Embals.Add(embal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InsumoId = new SelectList(db.Insumos, "InsumoId", "Apelido", embal.InsumoId);
            return View(embal);
        }

        // GET: Embals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Embal embal = db.Embals.Find(id);
            if (embal == null)
            {
                return HttpNotFound();
            }
            ViewBag.InsumoId = new SelectList(db.Insumos, "InsumoId", "Apelido", embal.InsumoId);
            return View(embal);
        }

        // POST: Embals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Sigla,InsumoId")] Embal embal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(embal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InsumoId = new SelectList(db.Insumos, "InsumoId", "Apelido", embal.InsumoId);
            return View(embal);
        }

        // GET: Embals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Embal embal = db.Embals
                .Include(e => e.Insumo)
                .SingleOrDefault(e => e.Id == id);

            if (embal == null)
            {
                return HttpNotFound();
            }
            return View(embal);
        }

        // POST: Embals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Embal embal = db.Embals.Find(id);
            db.Embals.Remove(embal);
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
