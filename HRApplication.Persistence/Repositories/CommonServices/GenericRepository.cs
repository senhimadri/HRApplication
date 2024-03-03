using HRApplication.Application.Contracts.Parsistence.CommonServices;
using HRApplication.Domain.CommonDomain;
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

    public Task<List<T>> AddMultiple(List<T> entitys)
    {
        throw new NotImplementedException();
    }

    public Task<T> AddOne(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMultiple(List<T> entitys)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMultiple(List<long> entitys)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOne(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOne(long IntPrimaryId)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<T>> FindMultiple()
    {
        throw new NotImplementedException();
    }

    public Task<T> FindOne(long Id)
    {
        throw new NotImplementedException();
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

    public Task<bool> IsExist(long PrimaryId)
    {
        throw new NotImplementedException();
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

