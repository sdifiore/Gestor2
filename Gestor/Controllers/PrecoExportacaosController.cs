using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    [RoutePrefix("PrecosExportacao")]
    public class PrecoExportacaosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PrecoExportacaos
        [Route]
        public ActionResult Index()
        {
            var precosExpostacao = db.PrecosExpostacao.Include(p => p.CondicaoPreco);
            return View(precosExpostacao.ToList());
        }

        // GET: PrecoExportacaos/Details/5
        [Route("Detail")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrecoExportacao precoExportacao = db.PrecosExpostacao.Find(id);
            if (precoExportacao == null)
            {
                return HttpNotFound();
            }
            return View(precoExportacao);
        }

        // GET: PrecoExportacaos/Create
        [Route("Create")]
        public ActionResult Create()
        {
            ViewBag.CondicaoPrecoId = new SelectList(db.CondicoesPrecos, "Id", "Apelido");
            return View();
        }

        // POST: PrecoExportacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LinhaUn,Descricao,Apelido,PesoLiquido,QtUnid,De2A5,De5A10,De10A20,Acima20,Com,LlMin,CondicaoPrecoId,PctRateio,CondPag,IEfetiva,PctEspecFrete,DespExpPadrao,PctDespExportEspec,PvFobMax,CustoDireto,RateioCustoFixo,PvFobMin,ValorCifPtfe,RelPtfeSobrePv")] PrecoExportacao precoExportacao)
        {
            if (ModelState.IsValid)
            {
                db.PrecosExpostacao.Add(precoExportacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CondicaoPrecoId = new SelectList(db.CondicoesPrecos, "Id", "Apelido", precoExportacao.CondicaoPrecoId);
            return View(precoExportacao);
        }

        // GET: PrecoExportacaos/Edit/5
        [Route("Edit")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrecoExportacao precoExportacao = db.PrecosExpostacao.Find(id);
            if (precoExportacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.CondicaoPrecoId = new SelectList(db.CondicoesPrecos, "Id", "Apelido", precoExportacao.CondicaoPrecoId);
            return View(precoExportacao);
        }

        // POST: PrecoExportacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LinhaUn,Descricao,Apelido,PesoLiquido,QtUnid,De2A5,De5A10,De10A20,Acima20,Com,LlMin,CondicaoPrecoId,PctRateio,CondPag,IEfetiva,PctEspecFrete,DespExpPadrao,PctDespExportEspec,PvFobMax,CustoDireto,RateioCustoFixo,PvFobMin,ValorCifPtfe,RelPtfeSobrePv")] PrecoExportacao precoExportacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(precoExportacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CondicaoPrecoId = new SelectList(db.CondicoesPrecos, "Id", "Apelido", precoExportacao.CondicaoPrecoId);
            return View(precoExportacao);
        }

        // GET: PrecoExportacaos/Delete/5
        [Route("Delete")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrecoExportacao precoExportacao = db.PrecosExpostacao.Find(id);
            if (precoExportacao == null)
            {
                return HttpNotFound();
            }
            return View(precoExportacao);
        }

        // POST: PrecoExportacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PrecoExportacao precoExportacao = db.PrecosExpostacao.Find(id);
            db.PrecosExpostacao.Remove(precoExportacao);
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
