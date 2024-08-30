using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Shared.Requests;
using Shared.ResultModel;

namespace AdminWeb.Abstraction.IServices
{
	public interface IAccountServices
	{
		Task<ResultModels> RegisterUser(RegisterUserRequests request);
		Task<ResultModels> Login(UserLoginRequest request);
	}
}
