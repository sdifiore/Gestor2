using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class DetalheProdutoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DetalheProdutoes
        public ActionResult Index()
        {
            var domain = Populate.DetalheProduto();
            var detalheProdutoes = db.DetalheProdutoes.Include(d => d.Produto);
            return View(domain);
        }

        // GET: DetalheProdutoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheProduto detalheProduto = db.DetalheProdutoes.Find(id);
            if (detalheProduto == null)
            {
                return HttpNotFound();
            }
            return View(detalheProduto);
        }

        // GET: DetalheProdutoes/Create
        public ActionResult Create()
        {
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido");
            return View();
        }

        // POST: DetalheProdutoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DetalheProdutoId,PesoLiquido,ItemStrut,CstDirIndd,CstMtsUltmEtp,CstMtsEtp1,CstMtsEtp2,CstMtsEtp3,CstTotMts,CstDirMod,HrsMod,HrsMod1,HrsMod2,HrsTotMod,CpcdProdHrr,LoteMin,UsoStrut,CstDirRgKg,RelModCst,PctMtrFnl,PctMtrEtp1,PctMtrEtp2,PctMtrEtp3,ProdutoId")] DetalheProduto detalheProduto)
        {
            if (ModelState.IsValid)
            {
                db.DetalheProdutoes.Add(detalheProduto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", detalheProduto.ProdutoId);
            return View(detalheProduto);
        }

        // GET: DetalheProdutoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheProduto detalheProduto = db.DetalheProdutoes.Find(id);
            if (detalheProduto == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", detalheProduto.ProdutoId);
            return View(detalheProduto);
        }

        // POST: DetalheProdutoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DetalheProdutoId,PesoLiquido,ItemStrut,CstDirIndd,CstMtsUltmEtp,CstMtsEtp1,CstMtsEtp2,CstMtsEtp3,CstTotMts,CstDirMod,HrsMod,HrsMod1,HrsMod2,HrsTotMod,CpcdProdHrr,LoteMin,UsoStrut,CstDirRgKg,RelModCst,PctMtrFnl,PctMtrEtp1,PctMtrEtp2,PctMtrEtp3,ProdutoId")] DetalheProduto detalheProduto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalheProduto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", detalheProduto.ProdutoId);
            return View(detalheProduto);
        }

        // GET: DetalheProdutoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheProduto detalheProduto = db.DetalheProdutoes.Find(id);
            if (detalheProduto == null)
            {
                return HttpNotFound();
            }
            return View(detalheProduto);
        }

        // POST: DetalheProdutoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetalheProduto detalheProduto = db.DetalheProdutoes.Find(id);
            db.DetalheProdutoes.Remove(detalheProduto);
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
