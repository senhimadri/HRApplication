namespace HRApplication.Application.Contracts.Parsistence.CommonServices;

public interface IGenericRepository<T> where T : class
{
    Task<T> FindOne(long Id);
    Task<IReadOnlyList<T>> FindAll();

    Task<T> AddOne(T entity);
    Task<List<T>> AddMultiple(List<T> entitys);

    Task UpdateOne(T entity);
    Task UpdateMultiple(List<T> entitys);

    Task HardDeleteOne(T entity);
    Task HardDeleteOne(long IntPrimaryId);
    Task HardDeleteMultiple(List<T> entitys);
    Task HardDeleteMultiple(List<long> entitys);

    Task DeleteOne(T entity);
    Task DeleteOne(long IntPrimaryId);
    Task DeleteMultiple(List<T> entitys);
    Task DeleteMultiple(List<long> entitys);

    Task<bool> IsExist (long PrimaryId);
    Task<bool> IsExist(T entity);

    // FindExistMultiple
}
