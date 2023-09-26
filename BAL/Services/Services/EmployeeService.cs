using System;
using MODEL.DTOs.Employee;
using MODEL.Entities;
using AutoMapper;
using REPOSITORY.UnitOfWork;
using BAL.Services.IServices;
using MODEL;
namespace BAL.Services.Services
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mappper;
		public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper )
		{
			_unitOfWork = unitOfWork;
			_mappper = mapper;
		}

		public async Task<ServiceReponse<bool>> CreateEmployee (CreateEmployeeDTO request)
		{
			ServiceReponse<bool> reponse = new ServiceReponse<bool>();
			Helper.CreatePasswordHash(request.EmployeePassword, out byte[] passwordHash, out byte[] passwordSalt);
			Employee employee = _mappper.Map<Employee>(request);
			employee.EmployeePasswordHash = passwordHash;
			employee.EmployeePasswordSalt = passwordSalt;
			await _unitOfWork.Employee.Create(employee);
			await _unitOfWork.SaveChangesAsync();
			reponse.Data = true;
			reponse.Message = "Employee successfully created";
			reponse.Response = 200;
			return reponse;
		}
	}
}

