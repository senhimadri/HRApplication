using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;
using HRApplication.Domain.EmployeeManagement;
using HRApplication.Persistence.Repositories.CommonServices;

namespace HRApplication.Persistence.Repositories.EmployeeManagement;

public class DepartmentInfoRepository : GenericRepository<TblDepartmentInfo>, IDepartmentInfoRepository
{
	private readonly HRApplicationDBContext _dbContext;
	public DepartmentInfoRepository(HRApplicationDBContext dbContext) : base(dbContext) => _dbContext = dbContext;
}