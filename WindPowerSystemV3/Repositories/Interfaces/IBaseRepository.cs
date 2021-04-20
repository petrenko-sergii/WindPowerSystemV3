using System;
using System.Linq;
using System.Linq.Expressions;

namespace WindPowerSystemV3.Repositories.Interfaces
{
	public interface IBaseRepository<T> where T : class
	{
		void Create(T item);
		T FindById(int id);
		IQueryable<T> GetAll();
		IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
		IQueryable<T> Get(Expression<Func<T, bool>> predicate);
		void Remove(T item);
		void Update(T item);
	}
}
