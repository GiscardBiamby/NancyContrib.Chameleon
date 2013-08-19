using System.Web.Mvc;

namespace NancyContrib.Chameleon.Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
