using System;
namespace MODEL.Entities
{
	public class Employee
	{
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; } = null!;
		public string EmployeeEmail { get; set; } = null!;
		public byte[] EmployeePasswordHash { get; set; } = null!;
		public byte[] EmployeePasswordSalt { get; set; } = null!;
	}
}

