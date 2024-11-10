﻿using GlobalIdentityServer.Models.CommonModel;
using System.Linq.Expressions;

namespace GlobalIdentityServer.Repository.CommonRepository;

public interface IGenericRepository<T> where T : BaseDomain
{
    Task CreateAsync(T entity);
    Task<IReadOnlyCollection<T>> GetAllAsync();
    Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);
    Task<T> GetAsync(Guid id);
    Task RemoveAsync(Guid id);
    Task UpdateAsync(T entity);
}
