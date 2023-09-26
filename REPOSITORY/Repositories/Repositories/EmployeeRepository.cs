using System;
using REPOSITORY.Repositories.IRepositories;
using MODEL.Entities;
namespace REPOSITORY.Repositories.Repositories
{
	internal class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
	{
		public EmployeeRepository(DataContext dataContext) : base(dataContext)
		{

		}
	}
}

