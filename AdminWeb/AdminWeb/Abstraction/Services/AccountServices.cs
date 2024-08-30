using AdminWeb.Abstraction.IServices;
using AdminWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
				if (request != null)
				{

					var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Email && x.Contact == request.Contact);

					if (user == null)
					{
						Users users = new();
						users.Name = request.Name;
						users.Email = request.Email;
						users.Password = request.Password;
						users.Contact = request.Contact;
						users.Role = request.Role;

						_context.Users.Add(users);
						await _context.SaveChangesAsync();

						return ResultModels.Success("Successfully Registered");
					}
					else
					{
						return ResultModels.Fail("User Already Exist");
					}
				}
				else
				{
					return ResultModels.Fail("Fatal Error");
				}

			}
			catch (Exception)
			{
				return ResultModels.Fail("Fatal Error");
				throw;
			}
		}

		public async Task<ResultModels> Login(UserLoginRequest request)
		{
			try
			{
				if (request != null)
				{

					var checkUser = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Username && x.Password == request.Password);

					if (checkUser != null)
					{
						return ResultModels.Success("Login Successfull");
					}
					else
					{
						return ResultModels.Success("Incorrect Credentials");
					}
				}
				else
				{
					return ResultModels.Fail("Fatal Error");
				}
			}
			catch (Exception)
			{
				return ResultModels.Fail("Fatal Error");
				throw;
			}
		}


	}
}
