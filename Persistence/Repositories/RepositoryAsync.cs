using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Abstractions;

namespace Persistence.Repositories
{
          public class RepositoryAsync<T> : IRepository<T> where T : class
          {
                    public Task<T> AddAsync(T entity)
                    {
                              throw new NotImplementedException();
                    }

                    public Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>> expression)
                    {
                              throw new NotImplementedException();
                    }

                    public Task<IReadOnlyList<T>> GetAllByConditionAsync(Expression<Func<T, bool>> expression)
                    {
                              throw new NotImplementedException();
                    }
                    public Task<T> GetAsync(Expression<Func<T, bool>> expression)
                    {
                              throw new NotImplementedException();
                    }
          }
}