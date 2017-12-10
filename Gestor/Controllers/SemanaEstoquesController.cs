using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    [RoutePrefix("SemanasEstoque")]
    public class SemanaEstoquesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SemanaEstoques
        [Route]
        public ActionResult Index()
        {
            return View(db.SemanasEstoque.ToList());
        }

        // GET: SemanaEstoques/Details/5
        [Route("Details")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SemanaEstoque semanaEstoque = db.SemanasEstoque.Find(id);
            if (semanaEstoque == null)
            {
                return HttpNotFound();
            }
            return View(semanaEstoque);
        }

        // GET: SemanaEstoques/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SemanaEstoques/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Apelido,Semanas")] SemanaEstoque semanaEstoque)
        {
            if (ModelState.IsValid)
            {
                db.SemanasEstoque.Add(semanaEstoque);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(semanaEstoque);
        }

        // GET: SemanaEstoques/Edit/5
        [Route("Edit")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SemanaEstoque semanaEstoque = db.SemanasEstoque.Find(id);
            if (semanaEstoque == null)
            {
                return HttpNotFound();
            }
            return View(semanaEstoque);
        }

        // POST: SemanaEstoques/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Apelido,Semanas")] SemanaEstoque semanaEstoque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(semanaEstoque).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(semanaEstoque);
        }

        // GET: SemanaEstoques/Delete/5
        [Route("Delete")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SemanaEstoque semanaEstoque = db.SemanasEstoque.Find(id);
            if (semanaEstoque == null)
            {
                return HttpNotFound();
            }
            return View(semanaEstoque);
        }

        // POST: SemanaEstoques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SemanaEstoque semanaEstoque = db.SemanasEstoque.Find(id);
            db.SemanasEstoque.Remove(semanaEstoque);
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
