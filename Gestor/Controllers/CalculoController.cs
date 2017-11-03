using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gestor.Controllers
{
    public class CalculoController : Controller
    {
        // GET: Calculo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Estrutura()
        {
            Populate.Estrutura();

            return Redirect("/Calculo");
        }

        public ActionResult Insumo()
        {
            Populate.Insumo();

            return Redirect("/Calculo");
        }

        public ActionResult Produto()
        {
            Populate.Produto();

            return Redirect("/Calculo");
        }

        public ActionResult Tudo()
        {
            Populate.Insumo();
            Populate.Estrutura();
            Populate.Produto();

            return Redirect("/");
        }
    }
}