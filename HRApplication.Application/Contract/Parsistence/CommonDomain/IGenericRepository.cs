using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApplication.Application.Contract.Parsistence.CommonDomain;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync(long Id);
    Task<IReadOnlyList<T>> GetAllAsync();

    Task<T> AddAsync(T entity);
    Task<List<T>> AddAllAsync(List<T> entitys);

    Task UpdateAsync(T entity);
    Task UpdateAllAsync(List<T> entitys);

    Task DeleteAsync(T entity);
    Task DeleteAllAsync(List<T> entitys);

    Task SoftDeleteAsync(T entity);
    Task SoftDeleteAllAsync(List<T> entitys);

    Task<bool> IsExistAsync(long id);
}
