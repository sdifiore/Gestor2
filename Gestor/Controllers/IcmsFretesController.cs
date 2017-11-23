using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class IcmsFretesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: IcmsFretes
        public ActionResult Index()
        {
            return View(db.IcmsFretes.ToList());
        }

        // GET: IcmsFretes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IcmsFrete icmsFrete = db.IcmsFretes.Find(id);
            if (icmsFrete == null)
            {
                return HttpNotFound();
            }
            return View(icmsFrete);
        }

        // GET: IcmsFretes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IcmsFretes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Rotulo,Icms,Frete")] IcmsFrete icmsFrete)
        {
            if (ModelState.IsValid)
            {
                db.IcmsFretes.Add(icmsFrete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(icmsFrete);
        }

        // GET: IcmsFretes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IcmsFrete icmsFrete = db.IcmsFretes.Find(id);
            if (icmsFrete == null)
            {
                return HttpNotFound();
            }
            return View(icmsFrete);
        }

        // POST: IcmsFretes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Rotulo,Icms,Frete")] IcmsFrete icmsFrete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(icmsFrete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(icmsFrete);
        }

        // GET: IcmsFretes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IcmsFrete icmsFrete = db.IcmsFretes.Find(id);
            if (icmsFrete == null)
            {
                return HttpNotFound();
            }
            return View(icmsFrete);
        }

        // POST: IcmsFretes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IcmsFrete icmsFrete = db.IcmsFretes.Find(id);
            db.IcmsFretes.Remove(icmsFrete);
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
