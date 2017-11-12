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

            return Redirect("/");
        }

        public ActionResult Insumo()
        {
            Populate.Insumo();

            return Redirect("/");
        }

        public ActionResult Produto()
        {
            Populate.Produto();

            return Redirect("/");
        }

        public ActionResult EncapTubo()
        {
            Populate.EncapTubos();

            return Redirect("/");
        }

        public ActionResult Graxas()
        {
            Populate.Graxas();

            return Redirect("/");
        }

        public ActionResult PreForma()
        {
            Populate.PreForma();

            return Redirect("/");
        }

        public ActionResult ResinaPtfe()
        {
            Populate.ResinaPtfe();

            return Redirect("/");
        }

        public ActionResult Tudo()
        {
            Populate.Insumo();
            Populate.Estrutura();
            Populate.Produto();
            Populate.EncapTubos();
            Populate.Graxas();
            Populate.PreForma();
            Populate.ResinaPtfe();

            return Redirect("/");
        }
    }
}