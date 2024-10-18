using HRApplication.Application.Contracts.Parsistence.CommonServices;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Domain.EmployeeManagement;
using System.Linq.Expressions;

namespace HRApplication.Application.Contracts.Parsistence.EmployeeManagement;

public interface IEmployeeBasicInfoRepository : IGenericRepository<TblEmployeeBasicInfo>
{
    public IQueryable<TblEmployeeBasicInfo> GetEmployeeDetailsQuery(Expression<Func<TblEmployeeBasicInfo, bool>> filter);
    public Task<List<TblEmployeeBasicInfo>> GetEmployeeDetailsList(Expression<Func<TblEmployeeBasicInfo, bool>> filter);
    public IQueryable<TblEmployeeBasicInfo> GetEmployeeDetailsbyId(long EmployeeId);
}

