using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class PcpsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Pcps
        public ActionResult Index()
        {
            return View(db.Pcps.ToList());
        }

        // GET: Pcps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pcp pcp = db.Pcps.Find(id);
            if (pcp == null)
            {
                return HttpNotFound();
            }
            return View(pcp);
        }

        // GET: Pcps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pcps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PcpId,Descricao")] Pcp pcp)
        {
            if (ModelState.IsValid)
            {
                db.Pcps.Add(pcp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pcp);
        }

        // GET: Pcps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pcp pcp = db.Pcps.Find(id);
            if (pcp == null)
            {
                return HttpNotFound();
            }
            return View(pcp);
        }

        // POST: Pcps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PcpId,Descricao")] Pcp pcp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pcp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pcp);
        }

        // GET: Pcps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pcp pcp = db.Pcps.Find(id);
            if (pcp == null)
            {
                return HttpNotFound();
            }
            return View(pcp);
        }

        // POST: Pcps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pcp pcp = db.Pcps.Find(id);
            db.Pcps.Remove(pcp);
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
