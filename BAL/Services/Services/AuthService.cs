using System;
using BAL.Services.IServices;
using MODEL;
using REPOSITORY.UnitOfWork;
using MODEL.DTOs;
using MODEL.Entities;
using BAL;
using Microsoft.Extensions.Configuration;

namespace BAL.Services.Services
{
	public class AuthService: IAuthService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IConfiguration _configuration;
		public AuthService(IUnitOfWork unitOfWork,IConfiguration configuration)
		{
			_configuration = configuration;
			_unitOfWork = unitOfWork;
		}

		public async Task<ServiceReponse<string>> Login(LoginDTO request)
		{
			ServiceReponse<string> response = new ServiceReponse<string>();
			var employees = await _unitOfWork.Employee.GetByCondition(e => e.EmployeeEmail == request.Email);
			var employee = employees.FirstOrDefault();
			if (employee == null)
			{
                response.Data = null;
                response.Message = "Username or Password Wrong";
                response.Response = 400;
                return response;
            }

			bool passwordCheck = Helper.VerifyPassword(request.Password,employee.EmployeePasswordHash,employee.EmployeePasswordSalt);
			if (passwordCheck == false)
			{
				response.Data = null;
				response.Message = "Username or Password Wrong";
				response.Response = 400;
				return response;
			}
			string token = Helper.CreateJWTToken(_configuration, employee);
            response.Data = token;
			response.Message = "Successfully logined";
			response.Response = 200;
			return response;
		}
	}
}

