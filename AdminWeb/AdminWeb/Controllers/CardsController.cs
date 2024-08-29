using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
