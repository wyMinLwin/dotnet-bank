using System;
namespace MODEL.DTOs.Employee
{
	public class CreateEmployeeDTO
	{
        public string EmployeeName { get; set; } = null!;
        public string EmployeeEmail { get; set; } = null!;
        public string EmployeePassword { get; set; } = null!;
    }
}

