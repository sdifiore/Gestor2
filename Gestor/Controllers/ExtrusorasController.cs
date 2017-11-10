using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class ExtrusorasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Extrusoras
        public ActionResult Index()
        {
            var model = db.Extrusoras.OrderBy(e => e.Apelido).ToList();

            return View(model);
        }

        // GET: Extrusoras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Extrusora extrusora = db.Extrusoras.Find(id);
            if (extrusora == null)
            {
                return HttpNotFound();
            }
            return View(extrusora);
        }

        // GET: Extrusoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Extrusoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Apelido,Descricao")] Extrusora extrusora)
        {
            if (ModelState.IsValid)
            {
                db.Extrusoras.Add(extrusora);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(extrusora);
        }

        // GET: Extrusoras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Extrusora extrusora = db.Extrusoras.Find(id);
            if (extrusora == null)
            {
                return HttpNotFound();
            }
            return View(extrusora);
        }

        // POST: Extrusoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Apelido,Descricao")] Extrusora extrusora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(extrusora).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(extrusora);
        }

        // GET: Extrusoras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Extrusora extrusora = db.Extrusoras.Find(id);
            if (extrusora == null)
            {
                return HttpNotFound();
            }
            return View(extrusora);
        }

        // POST: Extrusoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Extrusora extrusora = db.Extrusoras.Find(id);
            db.Extrusoras.Remove(extrusora);
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
