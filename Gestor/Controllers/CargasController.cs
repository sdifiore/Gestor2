using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class CargasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cargas
        public ActionResult Index()
        {
            var model = db.Cargas.OrderBy(c => c.Apelido).ToList();

            return View(model);
        }

        // GET: Cargas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carga carga = db.Cargas.Find(id);
            if (carga == null)
            {
                return HttpNotFound();
            }
            return View(carga);
        }

        // GET: Cargas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cargas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Apelido,Descricao")] Carga carga)
        {
            if (ModelState.IsValid)
            {
                db.Cargas.Add(carga);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carga);
        }

        // GET: Cargas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carga carga = db.Cargas.Find(id);
            if (carga == null)
            {
                return HttpNotFound();
            }
            return View(carga);
        }

        // POST: Cargas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Apelido,Descricao")] Carga carga)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carga).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carga);
        }

        // GET: Cargas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carga carga = db.Cargas.Find(id);
            if (carga == null)
            {
                return HttpNotFound();
            }
            return View(carga);
        }

        // POST: Cargas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Carga carga = db.Cargas.Find(id);
            db.Cargas.Remove(carga);
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
