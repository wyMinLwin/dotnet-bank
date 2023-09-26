using System;
using REPOSITORY.Repositories.IRepositories;
using REPOSITORY.Repositories.Repositories;
namespace REPOSITORY.UnitOfWork
{
	public class UnitOfWork: IUnitOfWork
	{
		private DataContext _dataContext;
		public UnitOfWork(DataContext dataContext)
		{
			_dataContext = dataContext;
			Employee = new EmployeeRepository(_dataContext);
		}

        public IEmployeeRepository Employee { get; private set; }
        
        public void Dispose()
        {
            _dataContext.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dataContext.SaveChangesAsync();
        }
    }
}

