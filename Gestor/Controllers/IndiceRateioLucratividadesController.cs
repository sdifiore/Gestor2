using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class IndiceRateioLucratividadesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: IndiceRateioLucratividades
        public ActionResult Index()
        {
            var indiceRateioLucratividades = db.IndiceRateioLucratividades.Include(i => i.GrupoRateio);
            return View(indiceRateioLucratividades.ToList());
        }

        // GET: IndiceRateioLucratividades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            IndiceRateioLucratividade indiceRateioLucratividade = db.IndiceRateioLucratividades
                .Include(i => i.GrupoRateio)
                .SingleOrDefault(i => i.Id == id);

            if (indiceRateioLucratividade == null)
            {
                return HttpNotFound();
            }
            return View(indiceRateioLucratividade);
        }

        // GET: IndiceRateioLucratividades/Create
        public ActionResult Create()
        {
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao");
            return View();
        }

        // POST: IndiceRateioLucratividades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GrupoRateioId,TotalCustoFixo,MoiFabricacao,OutroCustoFixoFabricacao,CustoFixoComacs,CustoFixoComtex,CustoFixoAdminLog")] IndiceRateioLucratividade indiceRateioLucratividade)
        {
            if (ModelState.IsValid)
            {
                db.IndiceRateioLucratividades.Add(indiceRateioLucratividade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", indiceRateioLucratividade.GrupoRateioId);
            return View(indiceRateioLucratividade);
        }

        // GET: IndiceRateioLucratividades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndiceRateioLucratividade indiceRateioLucratividade = db.IndiceRateioLucratividades.Find(id);
            if (indiceRateioLucratividade == null)
            {
                return HttpNotFound();
            }
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", indiceRateioLucratividade.GrupoRateioId);
            return View(indiceRateioLucratividade);
        }

        // POST: IndiceRateioLucratividades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GrupoRateioId,TotalCustoFixo,MoiFabricacao,OutroCustoFixoFabricacao,CustoFixoComacs,CustoFixoComtex,CustoFixoAdminLog")] IndiceRateioLucratividade indiceRateioLucratividade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(indiceRateioLucratividade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", indiceRateioLucratividade.GrupoRateioId);
            return View(indiceRateioLucratividade);
        }

        // GET: IndiceRateioLucratividades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            IndiceRateioLucratividade indiceRateioLucratividade = db.IndiceRateioLucratividades
                .Include(i => i.GrupoRateio)
                .SingleOrDefault(i => i.Id == id);

            if (indiceRateioLucratividade == null)
            {
                return HttpNotFound();
            }
            return View(indiceRateioLucratividade);
        }

        // POST: IndiceRateioLucratividades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IndiceRateioLucratividade indiceRateioLucratividade = db.IndiceRateioLucratividades.Find(id);
            db.IndiceRateioLucratividades.Remove(indiceRateioLucratividade);
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
