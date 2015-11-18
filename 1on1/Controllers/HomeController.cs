using _1on1.Filter;
using System.Web.Mvc;

namespace _1on1.Controllers
{
    public class HomeController : Controller
    {
        [NotificationFilter]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}