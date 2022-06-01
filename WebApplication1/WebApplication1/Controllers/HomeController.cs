using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewResult view = new ViewResult
            {
                ViewName = "HomePage"
            };
            return view;
        }

        public ViewResult About()
        {
            return new ViewResult { ViewName = "about" };
        }

        public ActionResult FAQ()
        {
            return View();

        }
        public ActionResult Contact()
        {
            return View();

        }

    }
}
