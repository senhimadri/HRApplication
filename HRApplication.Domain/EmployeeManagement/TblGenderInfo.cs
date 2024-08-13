using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.EmployeeManagement;

public class TblGenderInfo :BaseDomainEntity
{
    public string? StrGenderName { get; set; }
    public string? StrGenderCode { get; set; }
    public ICollection<TblEmployeeBasicInfo>? TblEmployeeBasicInfo { get; set; }
}

