using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class ParteProdutoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ParteProdutoes
        public ActionResult Index()
        {
            var parteProdutos = db.ParteProdutos.Include(p => p.Dominio).Include(p => p.GrupoRateio).Include(p => p.Pcp).Include(p => p.Produto).Include(p => p.TipoProducao);
            return View(parteProdutos.ToList());
        }

        // GET: ParteProdutoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParteProduto parteProduto = db.ParteProdutos
                .Include(p => p.Dominio)
                .Include(p => p.GrupoRateio)
                .Include(p => p.Pcp)
                .Include(p => p.Produto)
                .Include(p => p.TipoProducao)
                .SingleOrDefault(p => p.ParteProdutoId == id);
            if (parteProduto == null)
            {
                return HttpNotFound();
            }
            return View(parteProduto);
        }

        // GET: ParteProdutoes/Create
        public ActionResult Create()
        {
            ViewBag.DominioId = new SelectList(db.Dominios, "DominioId", "Descricao");
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao");
            ViewBag.PcpId = new SelectList(db.Pcps, "PcpId", "Descricao");
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido");
            ViewBag.TipoProducaoId = new SelectList(db.TiposProducao, "TipoProducaoId", "Descricao");
            return View();
        }

        // POST: ParteProdutoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ParteProdutoId,GrupoRateioId,Peso,Status,Ipi,QtdUndd,DominioId,TipoProducaoId,PcpId,QtdUndArmz,ProdutoId")] ParteProduto parteProduto)
        {
            if (ModelState.IsValid)
            {
                db.ParteProdutos.Add(parteProduto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DominioId = new SelectList(db.Dominios, "DominioId", "Descricao", parteProduto.DominioId);
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", parteProduto.GrupoRateioId);
            ViewBag.PcpId = new SelectList(db.Pcps, "PcpId", "Descricao", parteProduto.PcpId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", parteProduto.ProdutoId);
            ViewBag.TipoProducaoId = new SelectList(db.TiposProducao, "TipoProducaoId", "Descricao", parteProduto.TipoProducaoId);
            return View(parteProduto);
        }

        // GET: ParteProdutoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParteProduto parteProduto = db.ParteProdutos.Find(id);
            if (parteProduto == null)
            {
                return HttpNotFound();
            }
            ViewBag.DominioId = new SelectList(db.Dominios, "DominioId", "Descricao", parteProduto.DominioId);
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", parteProduto.GrupoRateioId);
            ViewBag.PcpId = new SelectList(db.Pcps, "PcpId", "Descricao", parteProduto.PcpId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", parteProduto.ProdutoId);
            ViewBag.TipoProducaoId = new SelectList(db.TiposProducao, "TipoProducaoId", "Descricao", parteProduto.TipoProducaoId);
            return View(parteProduto);
        }

        // POST: ParteProdutoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ParteProdutoId,GrupoRateioId,Peso,Status,Ipi,QtdUndd,DominioId,TipoProducaoId,PcpId,QtdUndArmz,ProdutoId")] ParteProduto parteProduto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parteProduto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DominioId = new SelectList(db.Dominios, "DominioId", "Descricao", parteProduto.DominioId);
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", parteProduto.GrupoRateioId);
            ViewBag.PcpId = new SelectList(db.Pcps, "PcpId", "Descricao", parteProduto.PcpId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", parteProduto.ProdutoId);
            ViewBag.TipoProducaoId = new SelectList(db.TiposProducao, "TipoProducaoId", "Descricao", parteProduto.TipoProducaoId);
            return View(parteProduto);
        }

        // GET: ParteProdutoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParteProduto parteProduto = db.ParteProdutos
                .Include(p => p.Dominio)
                .Include(p => p.GrupoRateio)
                .Include(p => p.Pcp)
                .Include(p => p.Produto)
                .Include(p => p.TipoProducao)
                .SingleOrDefault(p => p.ParteProdutoId == id);
            if (parteProduto == null)
            {
                return HttpNotFound();
            }
            return View(parteProduto);
        }

        // POST: ParteProdutoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParteProduto parteProduto = db.ParteProdutos.Find(id);
            db.ParteProdutos.Remove(parteProduto);
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
