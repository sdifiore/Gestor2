using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class ResinasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Resinas
        public ActionResult Index()
        {
            return View(db.Resinas.ToList());
        }

        // GET: Resinas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resina resina = db.Resinas.Find(id);
            if (resina == null)
            {
                return HttpNotFound();
            }
            return View(resina);
        }

        // GET: Resinas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resinas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao")] Resina resina)
        {
            if (ModelState.IsValid)
            {
                db.Resinas.Add(resina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(resina);
        }

        // GET: Resinas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resina resina = db.Resinas.Find(id);
            if (resina == null)
            {
                return HttpNotFound();
            }
            return View(resina);
        }

        // POST: Resinas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao")] Resina resina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(resina);
        }

        // GET: Resinas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resina resina = db.Resinas.Find(id);
            if (resina == null)
            {
                return HttpNotFound();
            }
            return View(resina);
        }

        // POST: Resinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Resina resina = db.Resinas.Find(id);
            db.Resinas.Remove(resina);
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
