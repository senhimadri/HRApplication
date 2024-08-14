using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;
using HRApplication.Domain.EmployeeManagement;
using HRApplication.Persistence.Repositories.CommonServices;
using Microsoft.EntityFrameworkCore;

namespace HRApplication.Persistence.Repositories.EmployeeManagement;

public class EmployeeBasicInfoRepository : GenericRepository<TblEmployeeBasicInfo> , IEmployeeBasicInfoRepository
{
    private readonly DbContext _dbContext;
	public EmployeeBasicInfoRepository(DbContext dbContext) : base(dbContext) => _dbContext = dbContext;
}