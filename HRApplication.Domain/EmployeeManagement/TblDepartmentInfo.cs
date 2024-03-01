using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HRApplication.Domain.EmployeeManagement;

public class TblDepartmentInfo: BaseDomainEntity
{
    public string StrDepartmentName { get; set; } = string.Empty;
    public string StrDepartmentCode { get; set; } = string.Empty;

    public ICollection<TblEmployeeBasicInfo> TblEmployeeBasicInfo { get; set; } = new Collection<TblEmployeeBasicInfo>();
}

