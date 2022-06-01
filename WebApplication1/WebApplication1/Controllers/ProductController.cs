using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController:Controller
    {
        public ActionResult Detail(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            return View();
        }
    }
}
