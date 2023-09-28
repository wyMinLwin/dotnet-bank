using System;
using Microsoft.AspNetCore.Mvc;
using BAL.Services.IServices;
using MODEL;
using MODEL.DTOs.Employee;
using Microsoft.AspNetCore.Authorization;
namespace API.Controllers
{
	[ApiController]
	[Route("[controller]/api")]
	[Authorize]
	public class EmployeeController: ControllerBase
	{
		private readonly IEmployeeService _employeeService;
		public EmployeeController(IEmployeeService employeeService)
		{
			_employeeService = employeeService;
		}

		[HttpPost("CreateEmployee")]
		public async Task<ActionResult<ServiceReponse<bool>>> CreateEmployee(CreateEmployeeDTO request)
		{
			ServiceReponse<bool> response = await _employeeService.CreateEmployee(request);
			if (response?.Data == false)
			{
				return BadRequest(response);
			}
			return Ok(response);

		}

	}
}

