using HRApplication.Domain.CommonDomain;
using System.Linq.Expressions;
namespace HRApplication.Application.Contracts.Parsistence.CommonServices;

public interface IGenericRepository<T> where T : class
{
    Task<T?> GetOne(long intPrimaryId);
    Task<List<T>> GetMany(Expression<Func<T, bool>> filter);

    Task<T> InsertOne(T entity);
    Task<List<T>> InsertMany(List<T> entitys);

    Task ModifyOne(T entity);
    Task ModifyMany(List<T> entitys);

    Task DeleteOne(long IntPrimaryId);
    Task DeleteMany(Expression<Func<T, bool>> filter);

    Task InActiveOne(long IntPrimaryId);
    Task InActiveMany(Expression<Func<T, bool>> filter);

    Task<bool> IsExist(Expression<Func<T, bool>> filter);
    Task<long> GetCount(Expression<Func<T, bool>> filter);
}
