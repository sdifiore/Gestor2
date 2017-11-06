using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class ParmGraxasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ParmGraxas
        public ActionResult Index()
        {
            return View(db.ParmGraxas.ToList());
        }

        // GET: ParmGraxas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParmGraxa parmGraxa = db.ParmGraxas.Find(id);
            if (parmGraxa == null)
            {
                return HttpNotFound();
            }
            return View(parmGraxa);
        }

        // GET: ParmGraxas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParmGraxas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,Pesagem,KgH")] ParmGraxa parmGraxa)
        {
            if (ModelState.IsValid)
            {
                db.ParmGraxas.Add(parmGraxa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parmGraxa);
        }

        // GET: ParmGraxas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParmGraxa parmGraxa = db.ParmGraxas.Find(id);
            if (parmGraxa == null)
            {
                return HttpNotFound();
            }
            return View(parmGraxa);
        }

        // POST: ParmGraxas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Pesagem,KgH")] ParmGraxa parmGraxa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parmGraxa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parmGraxa);
        }

        // GET: ParmGraxas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParmGraxa parmGraxa = db.ParmGraxas.Find(id);
            if (parmGraxa == null)
            {
                return HttpNotFound();
            }
            return View(parmGraxa);
        }

        // POST: ParmGraxas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParmGraxa parmGraxa = db.ParmGraxas.Find(id);
            db.ParmGraxas.Remove(parmGraxa);
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
