using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Controllers
{
    public class CarouselsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
