using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    [RoutePrefix("Embalagens")]
    public class EmbalagemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Embalagems
        [Route]
        public ActionResult Index()
        {
            return View(db.Embalagens.ToList());
        }

        // GET: Embalagems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Embalagem embalagem = db.Embalagens.Find(id);
            if (embalagem == null)
            {
                return HttpNotFound();
            }
            return View(embalagem);
        }

        // GET: Embalagems/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Embalagems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao")] Embalagem embalagem)
        {
            if (ModelState.IsValid)
            {
                db.Embalagens.Add(embalagem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(embalagem);
        }

        // GET: Embalagems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Embalagem embalagem = db.Embalagens.Find(id);
            if (embalagem == null)
            {
                return HttpNotFound();
            }
            return View(embalagem);
        }

        // POST: Embalagems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao")] Embalagem embalagem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(embalagem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(embalagem);
        }

        // GET: Embalagems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Embalagem embalagem = db.Embalagens.Find(id);
            if (embalagem == null)
            {
                return HttpNotFound();
            }
            return View(embalagem);
        }

        // POST: Embalagems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Embalagem embalagem = db.Embalagens.Find(id);
            db.Embalagens.Remove(embalagem);
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
