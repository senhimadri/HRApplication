using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;
using HRApplication.Domain.EmployeeManagement;
using HRApplication.Persistence.Repositories.CommonServices;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HRApplication.Persistence.Repositories.EmployeeManagement;

public class EmployeeBasicInfoRepository : GenericRepository<TblEmployeeBasicInfo> , IEmployeeBasicInfoRepository
{
    private readonly HRApplicationDBContext _dbContext;
	public EmployeeBasicInfoRepository(HRApplicationDBContext dbContext) : base(dbContext) => _dbContext = dbContext;

    public async Task<TblEmployeeBasicInfo?> GetEmployeeDetailsbyId(long EmployeeId)
    {
        var employeeDetails = await GetEmployeeDetailsQuery(x=>x.IntPrimaryId==EmployeeId)
                                        .FirstOrDefaultAsync();
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