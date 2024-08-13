using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HRApplication.Domain.EmployeeManagement;

public class TblDepartmentInfo: BaseDomainEntity
{
    public string? StrDepartmentName { get; set; } 
    public string? StrDepartmentCode { get; set; }

    public ICollection<TblEmployeeBasicInfo>? TblEmployeeBasicInfo { get; set; }
}

