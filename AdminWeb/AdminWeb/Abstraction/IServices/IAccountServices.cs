using Microsoft.AspNetCore.Mvc;
using Shared.Requests;
using Shared.ResultModel;

namespace AdminWeb.Abstraction.IServices
{
	public interface IAccountServices
	{
		Task<ResultModels> RegisterUser(RegisterUserRequests request);
	}
}
