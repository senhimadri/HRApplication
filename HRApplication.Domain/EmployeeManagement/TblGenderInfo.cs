using HRApplication.Domain.CommonDomain;

namespace HRApplication.Domain.EmployeeManagement;

public class TblGenderInfo :BaseDomainEntity
{
    public string? StrGenderName { get; set; }
    public string? StrGenderCode { get; set; }
    public ICollection<TblEmployeeBasicInfo>? TblEmployeeBasicInfo { get; set; }
}

