using System.Linq.Expressions;
namespace Application.Abstractions;

public interface IRepository<T> where T : class
{
          Task<T> AddAsync(T entity);
           Task<T> GetAsync(Expression<Func<T, bool>> expression);
          Task<IReadOnlyList<T>> GetAllByConditionAsync(Expression<Func<T, bool>> expression);
          Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>> expression);
}
