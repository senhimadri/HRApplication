using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Domain.EmployeeManagement;
using HRApplication.Persistence.Repositories.CommonServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace HRApplication.Persistence.Repositories.EmployeeManagement;

public class EmployeeBasicInfoRepository : GenericRepository<TblEmployeeBasicInfo>, IEmployeeBasicInfoRepository
{
    private readonly HRApplicationDBContext _dbContext;
    public EmployeeBasicInfoRepository(HRApplicationDBContext dbContext) : base(dbContext) => _dbContext = dbContext;

    public IQueryable<TblEmployeeBasicInfo> GetEmployeeDetailsbyId(long EmployeeId)
    {
        var employeeDetails = GetEmployeeDetailsQuery(x => x.IntPrimaryId == EmployeeId);
        return employeeDetails;
    }

    public async Task<List<TblEmployeeBasicInfo>> GetEmployeeDetailsList(Expression<Func<TblEmployeeBasicInfo, bool>> filter)
    {
        var employeeDetails = await GetEmployeeDetailsQuery(filter)
                                    .ToListAsync();
        return employeeDetails;
    }

    public IQueryable<TblEmployeeBasicInfo> GetEmployeeDetailsQuery(Expression<Func<TblEmployeeBasicInfo, bool>> filter)
    {
        var employeeDetailsQuery = _dbContext.TblEmployeeBasicInfo
                                        .Include(x => x.TblDepartmentInfo)
                                        .Include(x => x.TblDesignationInfo)
                                        .Include(x => x.TblGenderInfo)
                                        .Include(x => x.TblReligionInfo)
                                   .Where(filter);
        return employeeDetailsQuery;
    }
}

