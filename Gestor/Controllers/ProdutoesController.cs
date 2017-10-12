using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class ProdutoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Produtoes
        public ActionResult Index()
        {
            var produtos = db.Produtos.Include(p => p.Categoria).Include(p => p.ClasseCusto).Include(p => p.Familia).Include(p => p.Linha).Include(p => p.Tipo).Include(p => p.Unidade);
            return View(produtos.ToList());
        }

        // GET: Produtoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.ClasseCusto)
                .Include(p => p.Familia)
                .Include(p => p.Linha)
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
            ViewBag.FamiliaId = new SelectList(db.Familias, "FamiliaId", "Apelido");
            ViewBag.LinhaId = new SelectList(db.Linhas, "LinhaId", "Apelido");
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Apelido");
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido");
            return View();
        }

        // POST: Produtoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Apelido,Descricao,UnidadeId,TipoId,ClasseCustoId,CategoriaId,FamiliaId,LinhaId,FlagProduto")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Produtos.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "Apelido", produto.CategoriaId);
            ViewBag.ClasseCustoId = new SelectList(db.ClassesCusto, "ClasseCustoId", "Apelido", produto.ClasseCustoId);
            ViewBag.FamiliaId = new SelectList(db.Familias, "FamiliaId", "Apelido", produto.FamiliaId);
            ViewBag.LinhaId = new SelectList(db.Linhas, "LinhaId", "Apelido", produto.LinhaId);
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
            ViewBag.FamiliaId = new SelectList(db.Familias, "FamiliaId", "Apelido", produto.FamiliaId);
            ViewBag.LinhaId = new SelectList(db.Linhas, "LinhaId", "Apelido", produto.LinhaId);
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Apelido", produto.TipoId);
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido", produto.UnidadeId);
            return View(produto);
        }

        // POST: Produtoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Apelido,Descricao,UnidadeId,TipoId,ClasseCustoId,CategoriaId,FamiliaId,LinhaId,FlagProduto")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "Apelido", produto.CategoriaId);
            ViewBag.ClasseCustoId = new SelectList(db.ClassesCusto, "ClasseCustoId", "Apelido", produto.ClasseCustoId);
            ViewBag.FamiliaId = new SelectList(db.Familias, "FamiliaId", "Apelido", produto.FamiliaId);
            ViewBag.LinhaId = new SelectList(db.Linhas, "LinhaId", "Apelido", produto.LinhaId);
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Apelido", produto.TipoId);
            ViewBag.UnidadeId = new SelectList(db.Unidades, "UnidadeId", "Apelido", produto.UnidadeId);
            return View(produto);
        }

        // GET: Produtoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.ClasseCusto)
                .Include(p => p.Familia)
                .Include(p => p.Linha)
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
