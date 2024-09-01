using System.Linq.Expressions;

namespace HRApplication.Identity.IServices;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter);
    Task<T> GetByIdAsync(Guid id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(Guid id);
    Task<bool> IsExist(Expression<Func<T, bool>> filter);
    Task<long> GetCount(Expression<Func<T, bool>> filter);
}
