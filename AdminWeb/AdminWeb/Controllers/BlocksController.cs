using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Controllers
{
    public class BlocksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
