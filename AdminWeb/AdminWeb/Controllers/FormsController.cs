using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
