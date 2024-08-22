using HRApplication.Application.Contracts.Parsistence.CommonServices;
using HRApplication.Domain.CommonDomain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HRApplication.Persistence.Repositories.CommonServices;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseDomainEntity
{
    private readonly HRApplicationDBContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(HRApplicationDBContext context) => (_context, _dbSet)=(context, context.Set<T>());

    public async Task<T?> GetOne(long intPrimaryId)
    {
        return await _dbSet.FindAsync(intPrimaryId);
    }

    public async Task<List<T>> GetMany(Expression<Func<T, bool>> filter)
    {
        return await _dbSet.Where(filter).ToListAsync();
    }

    public async Task<T> InsertOne(T entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public async Task<List<T>> InsertMany(List<T> entities)
    {
        await _dbSet.AddRangeAsync(entities);
        return entities;
    }

    public Task ModifyOne(T entity)
    {
        _dbSet.Update(entity);
        return Task.CompletedTask;
    }

    public Task ModifyMany(List<T> entities)
    {
        _dbSet.UpdateRange(entities);
        return Task.CompletedTask;
    }

    public async Task DeleteOne(long IntPrimaryId)
    {
        var entity = await GetOne(IntPrimaryId);
        if (entity is not null)
            _dbSet.Remove(entity);
    }

    public async Task DeleteMany(Expression<Func<T, bool>> filter)
    {
        var entities = await GetMany(filter);

        if (entities.Any())
            _dbSet.RemoveRange(entities);

    }

    public async Task InActiveOne(long IntPrimaryId)
    {
        var entity = await GetOne(IntPrimaryId);
        if (entity is null)
            throw new NullReferenceException();

        entity.IsActive = false;
        await ModifyOne(entity);
    }

    public async Task InActiveMany(Expression<Func<T, bool>> filter)
    {
        var entities = await GetMany(filter);

        if (entities.Any())
        {
            entities.ForEach(x => x.IsActive = false);
            await ModifyMany(entities);
        }
    }

    public async Task<bool> IsExist(long PrimaryId)
    {
        return await _dbSet.AnyAsync(e => e.IntPrimaryId == PrimaryId);
    }

    public async Task<long> GetCount(Expression<Func<T, bool>> filter)
    {
        return await _dbSet.CountAsync(filter);
    }
}

