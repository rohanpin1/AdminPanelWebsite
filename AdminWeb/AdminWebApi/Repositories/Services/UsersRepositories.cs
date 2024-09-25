using AdminWebApi.Context;
using AdminWebApi.Repositories.Abstraction;
using Dapper;
using Shared.Response;
using Shared.ResultModel;

namespace AdminWebApi.Repositories.Services
{
	public class UsersRepositories : IUsersRepositories
	{
		private readonly DapperContext _context;
        public UsersRepositories(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<UsersModel>> GetUsersAllAsync()
		{
			try
			{
				List<UsersModel> users = new();
				using (var connection = _context.CreateConnection())
				{
					var result = await connection.QueryAsync<UsersModel>("GetAllUsers",commandType:System.Data.CommandType.StoredProcedure);

					return result.ToList();
				}				
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<bool> DeleteUser(Guid id)
		{	
			try
			{
				using(var connection = _context.CreateConnection())
				{
					//var result = await connection.ExecuteAsync("deleteuser", new {id = id},commandType:System.Data.CommandType.StoredProcedure)>0;

					//return result;
					return true;
				}
			}
			catch (Exception)
			{
				
				throw;
			}
		}
	}
}
