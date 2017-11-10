using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class PadraoFixoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PadraoFixoes
        public ActionResult Index()
        {
            return View(db.PadroesFixos.ToList());
        }

        // GET: PadraoFixoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PadraoFixo padraoFixo = db.PadroesFixos.Find(id);
            if (padraoFixo == null)
            {
                return HttpNotFound();
            }
            return View(padraoFixo);
        }

        // GET: PadraoFixoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PadraoFixoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,Valor")] PadraoFixo padraoFixo)
        {
            if (ModelState.IsValid)
            {
                db.PadroesFixos.Add(padraoFixo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(padraoFixo);
        }

        // GET: PadraoFixoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PadraoFixo padraoFixo = db.PadroesFixos.Find(id);
            if (padraoFixo == null)
            {
                return HttpNotFound();
            }
            return View(padraoFixo);
        }

        // POST: PadraoFixoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Valor")] PadraoFixo padraoFixo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(padraoFixo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(padraoFixo);
        }

        // GET: PadraoFixoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PadraoFixo padraoFixo = db.PadroesFixos.Find(id);
            if (padraoFixo == null)
            {
                return HttpNotFound();
            }
            return View(padraoFixo);
        }

        // POST: PadraoFixoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PadraoFixo padraoFixo = db.PadroesFixos.Find(id);
            db.PadroesFixos.Remove(padraoFixo);
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
