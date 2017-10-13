using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class DominiosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Dominios
        public ActionResult Index()
        {
            return View(db.Dominios.ToList());
        }

        // GET: Dominios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dominio dominio = db.Dominios.Find(id);
            if (dominio == null)
            {
                return HttpNotFound();
            }
            return View(dominio);
        }

        // GET: Dominios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dominios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DominioId,Descricao")] Dominio dominio)
        {
            if (ModelState.IsValid)
            {
                db.Dominios.Add(dominio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dominio);
        }

        // GET: Dominios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dominio dominio = db.Dominios.Find(id);
            if (dominio == null)
            {
                return HttpNotFound();
            }
            return View(dominio);
        }

        // POST: Dominios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DominioId,Descricao")] Dominio dominio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dominio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dominio);
        }

        // GET: Dominios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dominio dominio = db.Dominios.Find(id);
            if (dominio == null)
            {
                return HttpNotFound();
            }
            return View(dominio);
        }

        // POST: Dominios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dominio dominio = db.Dominios.Find(id);
            db.Dominios.Remove(dominio);
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
