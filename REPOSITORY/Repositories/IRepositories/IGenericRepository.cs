using System;
namespace REPOSITORY.Repositories.IRepositories
{
	public interface IGenericRepository<T> where T : class
	{
		Task Create(T entity);
	}
}

