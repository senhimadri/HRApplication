using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HRApplication.Domain.MasterConfiguratio;

public class TblAccountInfo : BaseDomainEntity
{
    public string? StrAccountName { get; set; }
    public string? StrAccountDescreption { get; set; }

    public ICollection<TblBusinessUnitInfo>? TblBusinessUnitInfo { get; set; }

}

