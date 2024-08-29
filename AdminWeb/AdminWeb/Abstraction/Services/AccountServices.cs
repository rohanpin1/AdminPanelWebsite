using AdminWeb.Abstraction.IServices;
using AdminWeb.Models;
using Shared.Requests;
using Shared.ResultModel;

namespace AdminWeb.Abstraction.Services
{
	public class AccountServices : IAccountServices
	{
		private readonly AdminPnlContext _context;
        public AccountServices(AdminPnlContext context)
        {
                _context = context;
        }

        public async Task<ResultModels> RegisterUser(RegisterUserRequests request)
        {
			try
			{

				return ResultModels.Success("hi", 34);
			}
			catch (Exception)
			{

				throw;
			}
        }


	}
}
