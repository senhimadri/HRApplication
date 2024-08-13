using HRApplication.Domain.CommonDomain;

namespace HRApplication.Domain.EmployeeManagement;

public class TblReligionInfo: BaseDomainEntity
{
    public string? StrReligionName { get; set; }
    public string? StrReligionCode { get; set; }
    public ICollection<TblEmployeeBasicInfo>? TblEmployeeBasicInfo { get; set; }
}

