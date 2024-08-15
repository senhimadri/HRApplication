using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;
using HRApplication.Persistence.Repositories.EmployeeManagement;
using Microsoft.EntityFrameworkCore;
namespace HRApplication.Persistence.Repositories;

public class UnitofWork : IUnitofWork
{
    private readonly DbContext _context;
    private IEmployeeBasicInfoRepository? _employeeBasicInfoRepository;
    public UnitofWork(DbContext context) => _context = context;

    public IEmployeeBasicInfoRepository EmployeeBasicInfoRepository => 
                                    _employeeBasicInfoRepository ??= new EmployeeBasicInfoRepository(_context);

    public async Task SaveAsync() => await _context.SaveChangesAsync();
    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}