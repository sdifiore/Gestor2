using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    [RoutePrefix("ResinaBase")]
    public class ResinaBasesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ResinaBases
        [Route]
        public ActionResult Index()
        {
            var model = db.ResinasBase.OrderBy(r => r.Apelido).ToList();

            return View(model);
        }

        // GET: ResinaBases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResinaBase resinaBase = db.ResinasBase.Find(id);
            if (resinaBase == null)
            {
                return HttpNotFound();
            }
            return View(resinaBase);
        }

        // GET: ResinaBases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResinaBases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Apelido,Descricao")] ResinaBase resinaBase)
        {
            if (ModelState.IsValid)
            {
                db.ResinasBase.Add(resinaBase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(resinaBase);
        }

        // GET: ResinaBases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResinaBase resinaBase = db.ResinasBase.Find(id);
            if (resinaBase == null)
            {
                return HttpNotFound();
            }
            return View(resinaBase);
        }

        // POST: ResinaBases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Apelido,Descricao")] ResinaBase resinaBase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resinaBase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(resinaBase);
        }

        // GET: ResinaBases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResinaBase resinaBase = db.ResinasBase.Find(id);
            if (resinaBase == null)
            {
                return HttpNotFound();
            }
            return View(resinaBase);
        }

        // POST: ResinaBases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ResinaBase resinaBase = db.ResinasBase.Find(id);
            db.ResinasBase.Remove(resinaBase);
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
