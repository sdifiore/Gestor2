using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Gestor.Models;

namespace Gestor.Controllers
{
    public class PlanejVendasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PlanejVendas
        public ActionResult Index()
        {
            var planejVendas = db.PlanejVendas
                .Include(p => p.Produto);

            return View(planejVendas.ToList());
        }

        // GET: PlanejVendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PlanejVenda planejVenda = db.PlanejVendas
                .Include(p => p.Produto)
                .SingleOrDefault(p => p.Id == id);

            if (planejVenda == null)
            {
                return HttpNotFound();
            }
            return View(planejVenda);
        }

        // GET: PlanejVendas/Create
        public ActionResult Create()
        {
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido");
            return View();
        }

        // POST: PlanejVendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProdutoId,PesoUnitario,HorasMod,CustoDiretoTotal,CustoDiretoMats,CustoDiretoMod,CustoFixoFabrica,CustoFixAdmCom,AliquotaIpi,QvQtNacAnoMenos12,QvQtNacAnoMenos11,QvQtNacAnoMenos10,QvQtNacAnoMenos9,QvQtNacAnoMenos8,QvQtNacAnoMenos7,QvQtNacAnoMenos6,QvQtNacAnoMenos5,QvQtNacAnoMenos4,QvQtNacAnoMenos3,QvQtNacAnoMenos2,QvQtNacAno,QtNacMediaMensal,PvMed1o3m,PvMed2o3m,PvMed3o3m,PvMed4o3m,PvNacAdotado,StMedia,IcmsMedio,ComissaoMediaNac,FreteNacPct,MesRecebMedNac,QtExpAnoMenos12,QtExpAnoMenos11,QtExpAnoMenos10,QtExpAnoMenos9,QtExpAnoMenos8,QtExpAnoMenos7,QtExpAnoMenos6,QtExpAnoMenos5,QtExpAnoMenos4,QtExpAnoMenos3,QtExpAnoMenos2,QtExpAno,QtExpMediaMensal,PvMedEx1o3m,PvMedEx2o3m,PvMedEx3o3m,PvMedEx4o3m,PvMedExAdotado,ComissaoExpPct,PrazoRecebMedExp,ComentarioCelulaBi,Criterio,VartC1,VarTc2,VartC3,VartC4,PqQtNacAnoMenos12,PqQtNacAnoMenos11,PqQtNacAnoMenos10,PqQtNacAnoMenos9,PqQtNacAnoMenos8,PqQtNacAnoMenos7,PqQtNacAnoMenos6,PqQtNacAnoMenos5,PqQtNacAnoMenos4,PqQtNacAnoMenos3,PqQtNacAnoMenos2,PqQtNacAno,PqQtNacTotal,PplKgNacAnoMenos12,PplKgNacAnoMenos11,PplKgNacAnoMenos10,PplKgNacAnoMenos9,PplKgNacAnoMenos8,PplKgNacAnoMenos7,PplKgNacAnoMenos6,PplKgNacAnoMenos5,PplKgNacAnoMenos4,PplKgNacAnoMenos3,PplKgNacAnoMenos2,PplKgNacAno,PplKgNacTotal,PvvpvaVarPvAnoMenos12,PvvpvaVarPvAnoMenos11,PvvpvaVarPvAnoMenos10,PvvpvaVarPvAnoMenos9,PvvpvaVarPvAnoMenos8,PvvpvaVarPvAnoMenos7,PvvpvaVarPvAnoMenos6,PvvpvaVarPvAnoMenos5,PvvpvaVarPvAnoMenos4,PvvpvaVarPvAnoMenos3,PvvpvaVarPvAnoMenos2,PvvpvaVarPvAno,PcbRbNacAnoMenos12,PcbRbNacAnoMenos11,PcbRbNacAnoMenos10,PcbRbNacAnoMenos9,PcbRbNacAnoMenos8,PcbRbNacAnoMenos7,PcbRbNacAnoMenos6,PcbRbNacAnoMenos5,PcbRbNacAnoMenos4,PcbRbNacAnoMenos3,PcbRbNacAnoMenos2,PcbRbNacAno,PcbRbNacTotal,PipiIpiNacAnoMenos12,PipiIpiNacAnoMenos11,PipiIpiNacAnoMenos10,PipiIpiNacAnoMenos9,PipiIpiNacAnoMenos8,PipiIpiNacAnoMenos7,PipiIpiNacAnoMenos6,PipiIpiNacAnoMenos5,PipiIpiNacAnoMenos4,PipiIpiNacAnoMenos3,PipiIpiNacAnoMenos2,PipiIpiNacAno,PstStNacAnoMenos12,PstStNacAnoMenos11,PstStNacAnoMenos10,PstStNacAnoMenos9,PstStNacAnoMenos8,PstStNacAnoMenos7,PstStNacAnoMenos6,PstStNacAnoMenos5,PstStNacAnoMenos4,PstStNacAnoMenos3,PstStNacAnoMenos2,PstStNacAno,PfbFatBrAnoMenos12,PfbFatBrAnoMenos11,PfbFatBrAnoMenos10,PfbFatBrAnoMenos9,PfbFatBrAnoMenos8,PfbFatBrAnoMenos7,PfbFatBrAnoMenos6,PfbFatBrAnoMenos5,PfbFatBrAnoMenos4,PfbFatBrAnoMenos3,PfbFatBrAnoMenos2,PfbFatBrAno,PicmsIcmsNacAnoMenos12,PicmsIcmsNacAnoMenos11,PicmsIcmsNacAnoMenos10,PicmsIcmsNacAnoMenos9,PicmsIcmsNacAnoMenos8,PicmsIcmsNacAnoMenos7,PicmsIcmsNacAnoMenos6,PicmsIcmsNacAnoMenos5,PicmsIcmsNacAnoMenos4,PicmsIcmsNacAnoMenos3,PicmsIcmsNacAnoMenos2,PicmsIcmsNacAno,CrnFatBrutoNac,CrnImpostos,CrnRecLiquidaNacional,CrnComissaoNac,CrnFreteNac,CrnRecLiquidaVendaNac,CrnCustoDirMateriaisNac,CrnCustoDirModNac,CrnFixoFabricaNac,CrnMCNac,CrnMCNacPct,CrnCustoFixoAdmComNac,CrnResultadoBrutoNac,CrnResultadoBrutoNacPct,CrnComentario,PqeCriterio,PqeAumDim,PqeQtExpAnoMenos12,PqeQtExpAnoMenos11,PqeQtExpAnoMenos10,PqeQtExpAnoMenos9,PqeQtExpAnoMenos8,PqeQtExpAnoMenos7,PqeQtExpAnoMenos6,PqeQtExpAnoMenos5,PqeQtExpAnoMenos4,PqeQtExpAnoMenos3,PqeQtExpAnoMenos2,PqeQtExpAno,PqeQtExpTotal,PpleKgExpAnoMenos12,PpleKgExpAnoMenos11,PpleKgExpAnoMenos10,PpleKgExpAnoMenos9,PpleKgExpAnoMenos8,PpleKgExpAnoMenos7,PpleKgExpAnoMenos6,PpleKgExpAnoMenos5,PpleKgExpAnoMenos4,PpleKgExpAnoMenos3,PpleKgExpAnoMenos2,PpleKgExpAno,PpleKgExpTotal,PvppvaVPVexAnoMenos12,PvppvaVPVexAnoMenos11,PvppvaVPVexAnoMenos10,PvppvaVPVexAnoMenos9,PvppvaVPVexAnoMenos8,PvppvaVPVexAnoMenos7,PvppvaVPVexAnoMenos6,PvppvaVPVexAnoMenos5,PvppvaVPVexAnoMenos4,PvppvaVPVexAnoMenos3,PvppvaVPVexAnoMenos2,PvppvaVPVexAno,PreUsdRcExpUsAnoMenos12,PreUsdRcExpUsAnoMenos11,PreUsdRcExpUsAnoMenos10,PreUsdRcExpUsAnoMenos9,PreUsdRcExpUsAnoMenos8,PreUsdRcExpUsAnoMenos7,PreUsdRcExpUsAnoMenos6,PreUsdRcExpUsAnoMenos5,PreUsdRcExpUsAnoMenos4,PreUsdRcExpUsAnoMenos3,PreUsdRcExpUsAnoMenos2,PreUsdRcExpUsAno,PreUsdRcExpUsRecExportUSD,CreRecExportRs,CreComissaoExportRs,CreFreteDespExportRs,CreRecLiqVendaExportRs,CreCustoDiretoMatModExptRs,CreCustoFixoFabExpRs,CreMCExportRs,CreMCExportPct,CreCustoFixoAdmComExpRs,CreResultadoBrutoExpRs,CreResBrutoExpPct,FbQuantTotal,FbPesoTotal,FbFaturamentoBrutoTotal,RlImpostoTotal,RlReceitaLiquidaTotal,RlComissaoTotal,RlFreteDespExpTotal,RlRecLiqVendaTotal,McCustoDirMatModTotal,McCustoFixoFabricaTotal,McMargemContribTotal,McMCbTotalPct,RoCustoFixoComAdmTotal,RoCustoFixoComAdmAjustadoTotal,RoResultadoOperacionalTotal,RoResultadoOperacionalTotalPct,CdTotAnoMenos12,CdTotAnoMenos11,CdTotAnoMenos10,CdTotAnoMenos9,CdTotAnoMenos8,CdTotAnoMenos7,CdTotAnoMenos6,CdTotAnoMenos5,CdTotAnoMenos4,CdTotAnoMenos3,CdTotAnoMenos2,CdTotAno,GifTotAnoMenos12,GifTotAnoMenos11,GifTotAnoMenos10,GifTotAnoMenos9,GifTotAnoMenos8,GifTotAnoMenos7,GifTotAnoMenos6,GifTotAnoMenos5,GifTotAnoMenos4,GifTotAnoMenos3,GifTotAnoMenos2,GifTotAno,ComTotAnoMenos12,ComTotAnoMenos11,ComTotAnoMenos10,ComTotAnoMenos9,ComTotAnoMenos8,ComTotAnoMenos7,ComTotAnoMenos6,ComTotAnoMenos5,ComTotAnoMenos4,ComTotAnoMenos3,ComTotAnoMenos2,ComTotAno,FrtNacAnoMenos12,FrtNacAnoMenos11,FrtNacAnoMenos10,FrtNacAnoMenos9,FrtNacAnoMenos8,FrtNacAnoMenos7,FrtNacAnoMenos6,FrtNacAnoMenos5,FrtNacAnoMenos4,FrtNacAnoMenos3,FrtNacAnoMenos2,FrtNacAno,FrDexpAnoMenos12,FrDexpAnoMenos11,FrDexpAnoMenos10,FrDexpAnoMenos9,FrDexpAnoMenos8,FrDexpAnoMenos7,FrDexpAnoMenos6,FrDexpAnoMenos5,FrDexpAnoMenos4,FrDexpAnoMenos3,FrDexpAnoMenos2,FrDexpAno,CdsmtCfMatAnoMenos12,CdsmtCfMatAnoMenos11,CdsmtCfMatAnoMenos10,CdsmtCfMatAnoMenos9,CdsmtCfMatAnoMenos8,CdsmtCfMatAnoMenos7,CdsmtCfMatAnoMenos6,CdsmtCfMatAnoMenos5,CdsmtCfMatAnoMenos4,CdsmtCfMatAnoMenos3,CdsmtCfMatAnoMenos2,CdsmtCfMatAno,QtvQtTottAnoMenos12,QtvQtTottAnoMenos11,QtvQtTottAnoMenos10,QtvQtTottAnoMenos9,QtvQtTottAnoMenos8,QtvQtTottAnoMenos7,QtvQtTottAnoMenos6,QtvQtTottAnoMenos5,QtvQtTottAnoMenos4,QtvQtTottAnoMenos3,QtvQtTottAnoMenos2,QtvQtTottAno,HorasProdAnoMenos12,HorasProdAnoMenos11,HorasProdAnoMenos10,HorasProdAnoMenos9,HorasProdAnoMenos8,HorasProdAnoMenos7,HorasProdAnoMenos6,HorasProdAnoMenos5,HorasProdAnoMenos4,HorasProdAnoMenos3,HorasProdAnoMenos2,HorasProdAno,RecNacAnoMenos12,RecNacAnoMenos11,RecNacAnoMenos10,RecNacAnoMenos9,RecNacAnoMenos8,RecNacAnoMenos7,RecNacAnoMenos6,RecNacAnoMenos5,RecNacAnoMenos4,RecNacAnoMenos3,RecNacAnoMenos2,RecNacAno,RecExpAnoMenos12,RecExpAnoMenos11,RecExpAnoMenos10,RecExpAnoMenos9,RecExpAnoMenos8,RecExpAnoMenos7,RecExpAnoMenos6,RecExpAnoMenos5,RecExpAnoMenos4,RecExpAnoMenos3,RecExpAnoMenos2,RecExpAno")] PlanejVenda planejVenda)
        {
            if (ModelState.IsValid)
            {
                db.PlanejVendas.Add(planejVenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", planejVenda.ProdutoId);
            return View(planejVenda);
        }

        // GET: PlanejVendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanejVenda planejVenda = db.PlanejVendas.Find(id);
            if (planejVenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", planejVenda.ProdutoId);
            return View(planejVenda);
        }

        // POST: PlanejVendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProdutoId,PesoUnitario,HorasMod,CustoDiretoTotal,CustoDiretoMats,CustoDiretoMod,CustoFixoFabrica,CustoFixAdmCom,AliquotaIpi,QvQtNacAnoMenos12,QvQtNacAnoMenos11,QvQtNacAnoMenos10,QvQtNacAnoMenos9,QvQtNacAnoMenos8,QvQtNacAnoMenos7,QvQtNacAnoMenos6,QvQtNacAnoMenos5,QvQtNacAnoMenos4,QvQtNacAnoMenos3,QvQtNacAnoMenos2,QvQtNacAno,QtNacMediaMensal,PvMed1o3m,PvMed2o3m,PvMed3o3m,PvMed4o3m,PvNacAdotado,StMedia,IcmsMedio,ComissaoMediaNac,FreteNacPct,MesRecebMedNac,QtExpAnoMenos12,QtExpAnoMenos11,QtExpAnoMenos10,QtExpAnoMenos9,QtExpAnoMenos8,QtExpAnoMenos7,QtExpAnoMenos6,QtExpAnoMenos5,QtExpAnoMenos4,QtExpAnoMenos3,QtExpAnoMenos2,QtExpAno,QtExpMediaMensal,PvMedEx1o3m,PvMedEx2o3m,PvMedEx3o3m,PvMedEx4o3m,PvMedExAdotado,ComissaoExpPct,PrazoRecebMedExp,ComentarioCelulaBi,Criterio,VartC1,VarTc2,VartC3,VartC4,PqQtNacAnoMenos12,PqQtNacAnoMenos11,PqQtNacAnoMenos10,PqQtNacAnoMenos9,PqQtNacAnoMenos8,PqQtNacAnoMenos7,PqQtNacAnoMenos6,PqQtNacAnoMenos5,PqQtNacAnoMenos4,PqQtNacAnoMenos3,PqQtNacAnoMenos2,PqQtNacAno,PqQtNacTotal,PplKgNacAnoMenos12,PplKgNacAnoMenos11,PplKgNacAnoMenos10,PplKgNacAnoMenos9,PplKgNacAnoMenos8,PplKgNacAnoMenos7,PplKgNacAnoMenos6,PplKgNacAnoMenos5,PplKgNacAnoMenos4,PplKgNacAnoMenos3,PplKgNacAnoMenos2,PplKgNacAno,PplKgNacTotal,PvvpvaVarPvAnoMenos12,PvvpvaVarPvAnoMenos11,PvvpvaVarPvAnoMenos10,PvvpvaVarPvAnoMenos9,PvvpvaVarPvAnoMenos8,PvvpvaVarPvAnoMenos7,PvvpvaVarPvAnoMenos6,PvvpvaVarPvAnoMenos5,PvvpvaVarPvAnoMenos4,PvvpvaVarPvAnoMenos3,PvvpvaVarPvAnoMenos2,PvvpvaVarPvAno,PcbRbNacAnoMenos12,PcbRbNacAnoMenos11,PcbRbNacAnoMenos10,PcbRbNacAnoMenos9,PcbRbNacAnoMenos8,PcbRbNacAnoMenos7,PcbRbNacAnoMenos6,PcbRbNacAnoMenos5,PcbRbNacAnoMenos4,PcbRbNacAnoMenos3,PcbRbNacAnoMenos2,PcbRbNacAno,PcbRbNacTotal,PipiIpiNacAnoMenos12,PipiIpiNacAnoMenos11,PipiIpiNacAnoMenos10,PipiIpiNacAnoMenos9,PipiIpiNacAnoMenos8,PipiIpiNacAnoMenos7,PipiIpiNacAnoMenos6,PipiIpiNacAnoMenos5,PipiIpiNacAnoMenos4,PipiIpiNacAnoMenos3,PipiIpiNacAnoMenos2,PipiIpiNacAno,PstStNacAnoMenos12,PstStNacAnoMenos11,PstStNacAnoMenos10,PstStNacAnoMenos9,PstStNacAnoMenos8,PstStNacAnoMenos7,PstStNacAnoMenos6,PstStNacAnoMenos5,PstStNacAnoMenos4,PstStNacAnoMenos3,PstStNacAnoMenos2,PstStNacAno,PfbFatBrAnoMenos12,PfbFatBrAnoMenos11,PfbFatBrAnoMenos10,PfbFatBrAnoMenos9,PfbFatBrAnoMenos8,PfbFatBrAnoMenos7,PfbFatBrAnoMenos6,PfbFatBrAnoMenos5,PfbFatBrAnoMenos4,PfbFatBrAnoMenos3,PfbFatBrAnoMenos2,PfbFatBrAno,PicmsIcmsNacAnoMenos12,PicmsIcmsNacAnoMenos11,PicmsIcmsNacAnoMenos10,PicmsIcmsNacAnoMenos9,PicmsIcmsNacAnoMenos8,PicmsIcmsNacAnoMenos7,PicmsIcmsNacAnoMenos6,PicmsIcmsNacAnoMenos5,PicmsIcmsNacAnoMenos4,PicmsIcmsNacAnoMenos3,PicmsIcmsNacAnoMenos2,PicmsIcmsNacAno,CrnFatBrutoNac,CrnImpostos,CrnRecLiquidaNacional,CrnComissaoNac,CrnFreteNac,CrnRecLiquidaVendaNac,CrnCustoDirMateriaisNac,CrnCustoDirModNac,CrnFixoFabricaNac,CrnMCNac,CrnMCNacPct,CrnCustoFixoAdmComNac,CrnResultadoBrutoNac,CrnResultadoBrutoNacPct,CrnComentario,PqeCriterio,PqeAumDim,PqeQtExpAnoMenos12,PqeQtExpAnoMenos11,PqeQtExpAnoMenos10,PqeQtExpAnoMenos9,PqeQtExpAnoMenos8,PqeQtExpAnoMenos7,PqeQtExpAnoMenos6,PqeQtExpAnoMenos5,PqeQtExpAnoMenos4,PqeQtExpAnoMenos3,PqeQtExpAnoMenos2,PqeQtExpAno,PqeQtExpTotal,PpleKgExpAnoMenos12,PpleKgExpAnoMenos11,PpleKgExpAnoMenos10,PpleKgExpAnoMenos9,PpleKgExpAnoMenos8,PpleKgExpAnoMenos7,PpleKgExpAnoMenos6,PpleKgExpAnoMenos5,PpleKgExpAnoMenos4,PpleKgExpAnoMenos3,PpleKgExpAnoMenos2,PpleKgExpAno,PpleKgExpTotal,PvppvaVPVexAnoMenos12,PvppvaVPVexAnoMenos11,PvppvaVPVexAnoMenos10,PvppvaVPVexAnoMenos9,PvppvaVPVexAnoMenos8,PvppvaVPVexAnoMenos7,PvppvaVPVexAnoMenos6,PvppvaVPVexAnoMenos5,PvppvaVPVexAnoMenos4,PvppvaVPVexAnoMenos3,PvppvaVPVexAnoMenos2,PvppvaVPVexAno,PreUsdRcExpUsAnoMenos12,PreUsdRcExpUsAnoMenos11,PreUsdRcExpUsAnoMenos10,PreUsdRcExpUsAnoMenos9,PreUsdRcExpUsAnoMenos8,PreUsdRcExpUsAnoMenos7,PreUsdRcExpUsAnoMenos6,PreUsdRcExpUsAnoMenos5,PreUsdRcExpUsAnoMenos4,PreUsdRcExpUsAnoMenos3,PreUsdRcExpUsAnoMenos2,PreUsdRcExpUsAno,PreUsdRcExpUsRecExportUSD,CreRecExportRs,CreComissaoExportRs,CreFreteDespExportRs,CreRecLiqVendaExportRs,CreCustoDiretoMatModExptRs,CreCustoFixoFabExpRs,CreMCExportRs,CreMCExportPct,CreCustoFixoAdmComExpRs,CreResultadoBrutoExpRs,CreResBrutoExpPct,FbQuantTotal,FbPesoTotal,FbFaturamentoBrutoTotal,RlImpostoTotal,RlReceitaLiquidaTotal,RlComissaoTotal,RlFreteDespExpTotal,RlRecLiqVendaTotal,McCustoDirMatModTotal,McCustoFixoFabricaTotal,McMargemContribTotal,McMCbTotalPct,RoCustoFixoComAdmTotal,RoCustoFixoComAdmAjustadoTotal,RoResultadoOperacionalTotal,RoResultadoOperacionalTotalPct,CdTotAnoMenos12,CdTotAnoMenos11,CdTotAnoMenos10,CdTotAnoMenos9,CdTotAnoMenos8,CdTotAnoMenos7,CdTotAnoMenos6,CdTotAnoMenos5,CdTotAnoMenos4,CdTotAnoMenos3,CdTotAnoMenos2,CdTotAno,GifTotAnoMenos12,GifTotAnoMenos11,GifTotAnoMenos10,GifTotAnoMenos9,GifTotAnoMenos8,GifTotAnoMenos7,GifTotAnoMenos6,GifTotAnoMenos5,GifTotAnoMenos4,GifTotAnoMenos3,GifTotAnoMenos2,GifTotAno,ComTotAnoMenos12,ComTotAnoMenos11,ComTotAnoMenos10,ComTotAnoMenos9,ComTotAnoMenos8,ComTotAnoMenos7,ComTotAnoMenos6,ComTotAnoMenos5,ComTotAnoMenos4,ComTotAnoMenos3,ComTotAnoMenos2,ComTotAno,FrtNacAnoMenos12,FrtNacAnoMenos11,FrtNacAnoMenos10,FrtNacAnoMenos9,FrtNacAnoMenos8,FrtNacAnoMenos7,FrtNacAnoMenos6,FrtNacAnoMenos5,FrtNacAnoMenos4,FrtNacAnoMenos3,FrtNacAnoMenos2,FrtNacAno,FrDexpAnoMenos12,FrDexpAnoMenos11,FrDexpAnoMenos10,FrDexpAnoMenos9,FrDexpAnoMenos8,FrDexpAnoMenos7,FrDexpAnoMenos6,FrDexpAnoMenos5,FrDexpAnoMenos4,FrDexpAnoMenos3,FrDexpAnoMenos2,FrDexpAno,CdsmtCfMatAnoMenos12,CdsmtCfMatAnoMenos11,CdsmtCfMatAnoMenos10,CdsmtCfMatAnoMenos9,CdsmtCfMatAnoMenos8,CdsmtCfMatAnoMenos7,CdsmtCfMatAnoMenos6,CdsmtCfMatAnoMenos5,CdsmtCfMatAnoMenos4,CdsmtCfMatAnoMenos3,CdsmtCfMatAnoMenos2,CdsmtCfMatAno,QtvQtTottAnoMenos12,QtvQtTottAnoMenos11,QtvQtTottAnoMenos10,QtvQtTottAnoMenos9,QtvQtTottAnoMenos8,QtvQtTottAnoMenos7,QtvQtTottAnoMenos6,QtvQtTottAnoMenos5,QtvQtTottAnoMenos4,QtvQtTottAnoMenos3,QtvQtTottAnoMenos2,QtvQtTottAno,HorasProdAnoMenos12,HorasProdAnoMenos11,HorasProdAnoMenos10,HorasProdAnoMenos9,HorasProdAnoMenos8,HorasProdAnoMenos7,HorasProdAnoMenos6,HorasProdAnoMenos5,HorasProdAnoMenos4,HorasProdAnoMenos3,HorasProdAnoMenos2,HorasProdAno,RecNacAnoMenos12,RecNacAnoMenos11,RecNacAnoMenos10,RecNacAnoMenos9,RecNacAnoMenos8,RecNacAnoMenos7,RecNacAnoMenos6,RecNacAnoMenos5,RecNacAnoMenos4,RecNacAnoMenos3,RecNacAnoMenos2,RecNacAno,RecExpAnoMenos12,RecExpAnoMenos11,RecExpAnoMenos10,RecExpAnoMenos9,RecExpAnoMenos8,RecExpAnoMenos7,RecExpAnoMenos6,RecExpAnoMenos5,RecExpAnoMenos4,RecExpAnoMenos3,RecExpAnoMenos2,RecExpAno")] PlanejVenda planejVenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(planejVenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Apelido", planejVenda.ProdutoId);
            return View(planejVenda);
        }

        // GET: PlanejVendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PlanejVenda planejVenda = db.PlanejVendas
                .Include(p => p.Produto)
                .SingleOrDefault(p => p.Id == id);

            if (planejVenda == null)
            {
                return HttpNotFound();
            }
            return View(planejVenda);
        }

        // POST: PlanejVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlanejVenda planejVenda = db.PlanejVendas.Find(id);
            db.PlanejVendas.Remove(planejVenda);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Search(string search)
        {
            var planejVenda = db.PlanejVendas
                .Include(p => p.Produto)
                .SingleOrDefault(p => p.Produto.Apelido == search);

            if (planejVenda == null)
            {
                DbLogger.Log(Reason.Info, $"Procura pelo produto {search} não produziu resultado em PlanejVenda");
                return Content($"Item {search} não encontrado");
            }
            return View("Details", planejVenda);
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
