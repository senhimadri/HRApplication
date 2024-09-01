using HRApplication.Application.Contracts.Parsistence.CommonServices;
using HRApplication.Domain.CommonDomain;
using HRApplication.Identity;
using HRApplication.Identity.Domain;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace HRApplication.Persistence.Repositories.CommonServices;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly IMongoCollection<T> _collection;


    public GenericRepository(IMongoDatabase database, string collectionName) 
                                            => _collection = database.GetCollection<T>(collectionName);


    public async Task<T?> GetOne(long intPrimaryId)
    {
        var res = await _collection
                        .Find(Builders<T>.Filter.Eq("Id", intPrimaryId))
                        .FirstOrDefaultAsync();
        return res;
    }
    public async Task<List<T>> GetMany(Expression<Func<T, bool>> filter)
    {
        var res = await _collection
                        .Find(filter)
                        .ToListAsync();
        return res;
    }

    public async Task<T> InsertOne(T entity)
    {
        await _collection
                .InsertOneAsync(entity);
        return entity;
    }
    public async Task<List<T>> InsertMany(List<T> entitys)
    {
        await _collection
                .InsertManyAsync(entitys);
        return entitys;
    }

    public Task ModifyOne(T entity)
    {
        throw new NotImplementedException();
    }
    public Task ModifyMany(List<T> entitys)
    {
        throw new NotImplementedException();
    }
    public Task DeleteOne(long IntPrimaryId)
    {
        throw new NotImplementedException();
    }
    public Task DeleteMany(Expression<Func<T, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public Task InActiveOne(long IntPrimaryId)
    {
        throw new NotImplementedException();
    }

    public Task InActiveMany(Expression<Func<T, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public Task<long> GetCount(Expression<Func<T, bool>> filter)
    {
        throw new NotImplementedException();
    }


    public Task<bool> IsExist(Expression<Func<T, bool>> filter)
    {
        throw new NotImplementedException();
    }


}

