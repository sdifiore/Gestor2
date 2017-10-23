using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class EstruturasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Estruturas
        public ActionResult Index()
        {
            var estruturas = db.Estruturas.Include(e => e.Sequencia).Include(e => e.Unidade);
            return View(estruturas.ToList());
        }

        // GET: Estruturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Estrutura estrutura = db.Estruturas
                .Include(e => e.Sequencia)
                .Include(e => e.Unidade)
                .SingleOrDefault(e => e.Id == id);

            if (estrutura == null)
            {
                return HttpNotFound();
            }

            return View(estrutura);
        }

        // GET: Estruturas/Create
        public ActionResult Create()
        {
            ViewBag.SequenciaId = new SelectList(db.Sequencias, "SequenciaId", "Tipo");
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido");
            return View();
        }

        // POST: Estruturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Apelido,UnidadeId,QtdCusto,SequenciaId,Item,Onera,Lote,Perda,Observacao")] Estrutura estrutura)
        {
            if (ModelState.IsValid)
            {
                estrutura.Perda = estrutura.Perda / 100;
                db.Estruturas.Add(estrutura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SequenciaId = new SelectList(db.Sequencias, "SequenciaId", "Tipo", estrutura.SequenciaId);
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido", estrutura.UnidadeId);
            return View(estrutura);
        }

        // GET: Estruturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estrutura estrutura = db.Estruturas.Find(id);
            if (estrutura == null)
            {
                return HttpNotFound();
            }
            ViewBag.SequenciaId = new SelectList(db.Sequencias, "SequenciaId", "Tipo", estrutura.SequenciaId);
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido", estrutura.UnidadeId);

            estrutura.Perda = estrutura.Perda * 100;

            return View(estrutura);
        }

        // POST: Estruturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Apelido,UnidadeId,QtdCusto,SequenciaId,Item,Onera,Lote,Perda,Observacao")] Estrutura estrutura)
        {
            if (ModelState.IsValid)
            {
                estrutura.Perda = estrutura.Perda / 100;
                db.Entry(estrutura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SequenciaId = new SelectList(db.Sequencias, "SequenciaId", "Tipo", estrutura.SequenciaId);
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido", estrutura.UnidadeId);
            return View(estrutura);
        }

        // GET: Estruturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Estrutura estrutura = db.Estruturas
                .Include(e => e.Sequencia)
                .Include(e => e.Unidade)
                .SingleOrDefault(e => e.Id == id);

            if (estrutura == null)
            {
                return HttpNotFound();
            }
            return View(estrutura);
        }

        // POST: Estruturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estrutura estrutura = db.Estruturas.Find(id);
            db.Estruturas.Remove(estrutura);
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
