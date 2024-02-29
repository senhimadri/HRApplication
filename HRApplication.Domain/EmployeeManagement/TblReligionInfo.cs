using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.EmployeeManagement;

public class TblReligionInfo: BaseDomainEntity
{
    public string StrReligionName { get; set; } = string.Empty;
    public string StrReligionCode { get; set; } = string.Empty;
    public ICollection<TblEmployeeBasicInfo> TblEmployeeBasicInfo { get; set; } = new Collection<TblEmployeeBasicInfo>();
}

