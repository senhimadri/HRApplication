using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HRApplication.Domain.MasterConfiguratio;

public class TblAccountInfo : BaseDomainEntity
{
    public string StrAccountName { get; set; } = string.Empty;
    public string StrAccountDescreption { get; set; } = string.Empty;

    public ICollection<TblBusinessUnitInfo> TblBusinessUnitInfo { get; set; } = new Collection<TblBusinessUnitInfo>();
    //public ICollection<TblWorkplaceGroupInfo> TblWorkplaceGroupInfo { get; set; } = new Collection<TblWorkplaceGroupInfo>();
    //public ICollection<TblWorkplaceInfo> TblWorkplaceInfo { get; set; } = new Collection<TblWorkplaceInfo>();

}

