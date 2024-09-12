using AdminWebApi.Repositories.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Response;

namespace AdminWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
        private readonly IUsersRepositories _usersRepositories;
        public UserController(IUsersRepositories usersRepositories)
        {
            _usersRepositories = usersRepositories;
        }

        [HttpGet("GetAllUsers")]
		public async Task<IEnumerable<UsersModel>> GetUsersAllAsync()
		{
			return await _usersRepositories.GetUsersAllAsync();
		}

	}
}
