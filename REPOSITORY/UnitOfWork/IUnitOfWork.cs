
using REPOSITORY.Repositories.IRepositories;
using System;
namespace REPOSITORY.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		IEmployeeRepository Employee {get;}
		Task<int> SaveChangesAsync();
	}
}

