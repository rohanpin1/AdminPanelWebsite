using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
