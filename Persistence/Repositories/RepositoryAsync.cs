using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Abstractions;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;

namespace Persistence.Repositories
{
          public class RepositoryAsync<T> :IRepository<T> where T : class, new()
          {
              public ApplicationContext _context;
              private IRepository<T> _repositoryImplementation;
              
                    public async Task<T> AddAsync(T entity)
                    {
                        _context.Set<T>().AddAsync(entity);
                        await _context.SaveChangesAsync();
                        return entity;
                    }

                    public async Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>> expression)
                    {
                        return await _context.Set<T>().ToListAsync();
                    } 

                    public Task<IReadOnlyList<T>> GetAllByConditionAsync(Expression<Func<T, bool>> expression)
                    {
                              throw new NotImplementedException();
                    }
                    public Task<T> GetAsync(Expression<Func<T, bool>> expression)
                    {
                        var ans = _context.Set<T>().FirstOrDefaultAsync(expression);
                        return ans;
                    }
          }
}