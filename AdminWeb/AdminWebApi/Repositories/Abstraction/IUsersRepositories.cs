
using Shared.Response;
using Shared.ResultModel;

namespace AdminWebApi.Repositories.Abstraction
{
	public interface IUsersRepositories
	{
		Task<IEnumerable<UsersModel>> GetUsersAllAsync();
	}
}
