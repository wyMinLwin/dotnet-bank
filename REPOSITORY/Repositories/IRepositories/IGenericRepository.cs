using System;
using System.Linq.Expressions;
namespace REPOSITORY.Repositories.IRepositories
{
	public interface IGenericRepository<T> where T : class
	{
		Task Create(T entity);
		Task<IEnumerable<T>> GetByCondition(Expression<Func<T,bool>> expression);
	}
}

