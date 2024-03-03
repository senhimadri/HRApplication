using HRApplication.Application.Contract.Parsistence.CommonServices;
using HRApplication.Domain.CommonDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApplication.Persistence.Repositories.CommonServices;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseDomainEntity
{

    public Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> AddAllAsync(List<T> entitys)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAllAsync(List<T> entitys)
    {
        throw new NotImplementedException();
    }





    public Task DeleteAllAsync(List<T> entitys)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAsync(long Id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsExistAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task SoftDeleteAllAsync(List<T> entitys)
    {
        throw new NotImplementedException();
    }

    public Task SoftDeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }


}

