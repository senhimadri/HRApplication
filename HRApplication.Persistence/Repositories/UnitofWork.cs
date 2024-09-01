using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;
using HRApplication.Persistence.Repositories.EmployeeManagement;
using Microsoft.EntityFrameworkCore;
namespace HRApplication.Persistence.Repositories;

public class UnitofWork : IUnitofWork
{
    private readonly HRApplicationDBContext _context;
    private IEmployeeBasicInfoRepository? _employeeBasicInfoRepository;
    private IDepartmentInfoRepository? _departmentInfoRepository;
    public UnitofWork(HRApplicationDBContext context) => _context = context;

    public IEmployeeBasicInfoRepository EmployeeBasicInfoRepository =>
                                    _employeeBasicInfoRepository ??= new EmployeeBasicInfoRepository(_context);

    public IDepartmentInfoRepository DepartmentInfoRepository =>
                                    _departmentInfoRepository ??= new DepartmentInfoRepository(_context);

    public async Task SaveAsync() => await _context.SaveChangesAsync();
    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}