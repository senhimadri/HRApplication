using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.EmployeeManagement;

public class TblGenderInfo :BaseDomainEntity
{
    public string StrGenderName { get; set; } = string.Empty;
    public string StrGenderCode { get; set; } = string.Empty;
    public ICollection<TblEmployeeBasicInfo> TblEmployeeBasicInfo { get; set; } = new Collection<TblEmployeeBasicInfo>();
}

