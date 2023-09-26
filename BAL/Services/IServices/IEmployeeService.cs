using System;
using MODEL.DTOs.Employee;
using MODEL;
namespace BAL.Services.IServices
{
	public interface IEmployeeService
	{
		Task<ServiceReponse<bool>> CreateEmployee(CreateEmployeeDTO request);
	}
}

