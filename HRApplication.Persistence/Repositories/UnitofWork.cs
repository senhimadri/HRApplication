using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace HRApplication.Persistence.Repositories;

public class UnitofWork : IUnitofWork
{
    public readonly DbContext _context;
    public UnitofWork(DbContext context) => _context=context;


    private readonly IEmployeeBasicInfoRepository _employeeBasicInfoRepository;

    public IEmployeeBasicInfoRepository EmployeeBasicInfoRepository => throw new NotImplementedException();



    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}