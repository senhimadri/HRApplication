using HRApplication.Application.Contracts.Parsistence.CommonServices;
using HRApplication.Domain.CommonDomain;
using HRApplication.Domain.EmployeeManagement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApplication.Persistence.Repositories.CommonServices;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseDomainEntity
{

    private readonly HRApplicationDBContext _context;
    public GenericRepository(HRApplicationDBContext context) => _context = context;


    public async Task<T> AddOne(T entity)
    {
        await _context.AddAsync(entity);
        return entity;


    }
    public async Task<List<T>> AddMultiple(List<T> entitys)
    {
        await _context.AddRangeAsync(entitys);
        return entitys;
    }

    public async Task DeleteMultiple(List<T> entitys)
    {
        _context.Set<T>().RemoveRange(entitys);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMultiple(List<long> entitys)
    {
        await _context.Set<T>()
                      .Where(x => entitys.Contains(x.IntPrimaryId))
                      .ExecuteUpdateAsync(setters => setters
                                            .SetProperty(b => b.IsActive, false));
                        
    }

    public async Task DeleteOne(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteOne(long IntPrimaryId)
    {
        await _context.Set<T>()
              .Where(x => x.IntPrimaryId == IntPrimaryId)
              .ExecuteUpdateAsync(setters => setters
                                    .SetProperty(b => b.IsActive, false));
    }

    public async Task<IReadOnlyList<T>> FindAll()
    {
        return await _context.Set<T>().ToListAsync();
    }
    public async Task<T> FindOne(long Id)
    {
        return await _context.Set<T>().FindAsync(Id) ?? Activator.CreateInstance<T>();
    }


    public Task HardDeleteMultiple(List<T> entitys)
    {
        throw new NotImplementedException();
    }

    public Task HardDeleteMultiple(List<long> entitys)
    {
        throw new NotImplementedException();
    }

    public Task HardDeleteOne(T entity)
    {
        throw new NotImplementedException();
    }

    public Task HardDeleteOne(long IntPrimaryId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> IsExist(long PrimaryId)
    {
        var entity = await FindOne(PrimaryId);
        return entity is not null;
    }

    public Task<bool> IsExist(T entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateMultiple(List<T> entitys)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOne(T entity)
    {
        throw new NotImplementedException();
    }
}

