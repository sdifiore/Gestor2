using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class IndicesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Indices
        public ActionResult Index()
        {
            return View(db.Indices.ToList());
        }

        // GET: Indices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indice indice = db.Indices.Find(id);
            if (indice == null)
            {
                return HttpNotFound();
            }
            return View(indice);
        }

        // GET: Indices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Indices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,Proprio,Terceiros,Exportacao")] Indice indice)
        {
            if (ModelState.IsValid)
            {
                db.Indices.Add(indice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(indice);
        }

        // GET: Indices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indice indice = db.Indices.Find(id);
            if (indice == null)
            {
                return HttpNotFound();
            }
            return View(indice);
        }

        // POST: Indices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Proprio,Terceiros,Exportacao")] Indice indice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(indice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(indice);
        }

        // GET: Indices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indice indice = db.Indices.Find(id);
            if (indice == null)
            {
                return HttpNotFound();
            }
            return View(indice);
        }

        // POST: Indices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Indice indice = db.Indices.Find(id);
            db.Indices.Remove(indice);
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
