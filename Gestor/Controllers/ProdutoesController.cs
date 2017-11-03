using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    [RoutePrefix("Produtos")]
    public class ProdutoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Produtoes
        [Route]
        public ActionResult Index()
        {
            // Populate.Produto();

            var produtos = db.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.ClasseCusto)
                .Include(p => p.Dominio)
                .Include(p => p.Familia)
                .Include(p => p.GrupoRateio)
                .Include(p => p.Linha)
                .Include(p => p.Pcp)
                .Include(p => p.Tipo)
                .Include(p => p.Unidade)
                .OrderBy(p => p.Apelido);

            return View(produtos.ToList());
        }

        // GET: Produtoes/Details/5
        [Route("Details")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var produto = db.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.ClasseCusto)
                .Include(p => p.Dominio)
                .Include(p => p.Familia)
                .Include(p => p.GrupoRateio)
                .Include(p => p.Linha)
                .Include(p => p.Pcp)
                .Include(p => p.Tipo)
                .Include(p => p.Unidade)
                .SingleOrDefault(p => p.Id == id);

            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produtoes/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "Apelido");
            ViewBag.ClasseCustoId = new SelectList(db.ClassesCusto, "ClasseCustoId", "Apelido");
            ViewBag.DominioId = new SelectList(db.Dominios, "DominioId", "Descricao");
            ViewBag.FamiliaId = new SelectList(db.Familias, "FamiliaId", "Apelido");
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao");
            ViewBag.LinhaId = new SelectList(db.Linhas, "LinhaId", "Apelido");
            ViewBag.PcpId = new SelectList(db.Pcps, "PcpId", "Descricao");
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Apelido");
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido");
            return View();
        }

        // POST: Produtoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Apelido,Descricao,UnidadeId,TipoId,ClasseCustoId,CategoriaId,FamiliaId,LinhaId,GrupoRateioId,PesoLiquido,Ativo,Ipi,QtdUnid,DominioId,TipoProdId,PcpId,QtUnPorUnArmz,PesoLiquidoCalc,ItemStru,CustODirTotal,CstMatUltmEtapa,CstMatEtapa1,CstMatEtapa2,CstMatEtapa3,CstTotMaterial,CustoDirMod,HorasModUltmEtapa,HorasModEtapa1,HorasModEtapa2,HorasModTotal,CapProdHora,LoteMinimo,UsoStru,CustoDir,RelModCstDir,PctMatEtapaFinal,PctMatEtapa1,PctMatEtapa2,PctMatEtapa3")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Produtos.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "Apelido", produto.CategoriaId);
            ViewBag.ClasseCustoId = new SelectList(db.ClassesCusto, "ClasseCustoId", "Apelido", produto.ClasseCustoId);
            ViewBag.DominioId = new SelectList(db.Dominios, "DominioId", "Descricao", produto.DominioId);
            ViewBag.FamiliaId = new SelectList(db.Familias, "FamiliaId", "Apelido", produto.FamiliaId);
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", produto.GrupoRateioId);
            ViewBag.LinhaId = new SelectList(db.Linhas, "LinhaId", "Apelido", produto.LinhaId);
            ViewBag.PcpId = new SelectList(db.Pcps, "PcpId", "Descricao", produto.PcpId);
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Apelido", produto.TipoId);
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido", produto.UnidadeId);
            return View(produto);
        }

        // GET: Produtoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "Apelido", produto.CategoriaId);
            ViewBag.ClasseCustoId = new SelectList(db.ClassesCusto, "ClasseCustoId", "Apelido", produto.ClasseCustoId);
            ViewBag.DominioId = new SelectList(db.Dominios, "DominioId", "Descricao", produto.DominioId);
            ViewBag.FamiliaId = new SelectList(db.Familias, "FamiliaId", "Apelido", produto.FamiliaId);
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", produto.GrupoRateioId);
            ViewBag.LinhaId = new SelectList(db.Linhas, "LinhaId", "Apelido", produto.LinhaId);
            ViewBag.PcpId = new SelectList(db.Pcps, "PcpId", "Descricao", produto.PcpId);
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Apelido", produto.TipoId);
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido", produto.UnidadeId);
            return View(produto);
        }

        // POST: Produtoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Apelido,Descricao,UnidadeId,TipoId,ClasseCustoId,CategoriaId,FamiliaId,LinhaId,GrupoRateioId,PesoLiquido,Ativo,Ipi,QtdUnid,DominioId,TipoProdId,PcpId,QtUnPorUnArmz,PesoLiquidoCalc,ItemStru,CustODirTotal,CstMatUltmEtapa,CstMatEtapa1,CstMatEtapa2,CstMatEtapa3,CstTotMaterial,CustoDirMod,HorasModUltmEtapa,HorasModEtapa1,HorasModEtapa2,HorasModTotal,CapProdHora,LoteMinimo,UsoStru,CustoDir,RelModCstDir,PctMatEtapaFinal,PctMatEtapa1,PctMatEtapa2,PctMatEtapa3")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "Apelido", produto.CategoriaId);
            ViewBag.ClasseCustoId = new SelectList(db.ClassesCusto, "ClasseCustoId", "Apelido", produto.ClasseCustoId);
            ViewBag.DominioId = new SelectList(db.Dominios, "DominioId", "Descricao", produto.DominioId);
            ViewBag.FamiliaId = new SelectList(db.Familias, "FamiliaId", "Apelido", produto.FamiliaId);
            ViewBag.GrupoRateioId = new SelectList(db.GruposRateio, "GrupoRateioId", "Descricao", produto.GrupoRateioId);
            ViewBag.LinhaId = new SelectList(db.Linhas, "LinhaId", "Apelido", produto.LinhaId);
            ViewBag.PcpId = new SelectList(db.Pcps, "PcpId", "Descricao", produto.PcpId);
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Apelido", produto.TipoId);
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido", produto.UnidadeId);
            return View(produto);
        }

        // GET: Produtoes/Delete/5
        [Route("Delete")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var produto = db.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.ClasseCusto)
                .Include(p => p.Dominio)
                .Include(p => p.Familia)
                .Include(p => p.GrupoRateio)
                .Include(p => p.Linha)
                .Include(p => p.Pcp)
                .Include(p => p.Tipo)
                .Include(p => p.Unidade)
                .SingleOrDefault(p => p.Id == id);

            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produto = db.Produtos.Find(id);
            db.Produtos.Remove(produto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Search(string search)
        {
            var produto = db.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.ClasseCusto)
                .Include(p => p.Dominio)
                .Include(p => p.Familia)
                .Include(p => p.GrupoRateio)
                .Include(p => p.Linha)
                .Include(p => p.Pcp)
                .Include(p => p.Tipo)
                .Include(p => p.Unidade)
                .SingleOrDefault(p => p.Apelido == search);

            if (produto == null)
            {
                DbLogger.Log(Reason.Info, $"Procura pelo produto {search} não produziu resultado");
                return Content($"Item {search} não encontrado");
            }
            return View("Details", produto);
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
