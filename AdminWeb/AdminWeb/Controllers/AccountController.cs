using AdminWeb.Abstraction.IServices;
using Microsoft.AspNetCore.Mvc;
using Shared.Requests;
using Shared.ResultModel;

namespace AdminWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountServices _accountServices;
        public AccountController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ResultModels> RegisterUser(RegisterUserRequests request)
        {
            return await _accountServices.RegisterUser(request);
        }

        [HttpPost]
        public async Task<ResultModels> Login(UserLoginRequest request)
        {
            return await _accountServices.Login(request);
        }

	}
}
